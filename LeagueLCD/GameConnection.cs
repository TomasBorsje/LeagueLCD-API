using LeagueLCD.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;

namespace LeagueLCD
{
    public class GameConnection
    {
        private static HttpClient client;
        private static HttpClientHandler handler = new HttpClientHandler() { ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; } };
        private Thread backgroundThread;

        public LiveGame Game;
        /// <summary>
        /// Whether or not the game is open and connected.
        /// </summary>
        public bool Connected = false;
        /// <summary>
        /// Whether or not statistics are being tracked and updated.
        /// </summary>
        public bool Polling;
        /// <summary>
        /// How many times to poll game data every second.
        /// </summary>
        public int TickRate;
        public GameConnection(int tickRate = 4, bool beginAutomatically = true)
        {
            TickRate = tickRate;
            Polling = beginAutomatically;
            client = new HttpClient(handler);
            backgroundThread = new Thread(Poll);
            backgroundThread.Start();
        }
        public async void Poll()
        {
            while (true)
            {
                if (Polling)
                {
                    try
                    {
                        var response = await client.GetAsync("https://127.0.0.1:2999/liveclientdata/allgamedata"); // Request data
                        string json = await response.Content.ReadAsStringAsync(); // Extract json
                        Game = JsonConvert.DeserializeObject<LiveGame>(json); // Deserialize json
                        Connected = true;
                    }
                    catch (HttpRequestException e)
                    {
                        Connected = false; // The game is not open.
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("An error occured while attempting to poll the game. Polling stopped.");
                        Console.WriteLine(e);
                        Connected = false;
                        Polling = false;
                    }
                }
                Thread.Sleep(1000 / TickRate);
            }
        }
    }
}
