using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using LeagueLCD;
using Newtonsoft.Json;

namespace LCUTesting
{
    class Program
    {
        static GameConnection connection;
        static async Task Main(string[] args)
        {
            connection = new GameConnection();
            await LoopAsync();
            Console.ReadLine();
        }
        public static async Task LoopAsync()
        {
            int i = 0;
            while(i < 50)
            {
                if (connection.Connected)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"Player: {connection.Game.activePlayer.summonerName}");
                    Console.WriteLine($"Champion: {connection.Game.allPlayers[0].championName} Level: {connection.Game.allPlayers[0].level}");
                    Console.WriteLine($"Health: {connection.Game.activePlayer.championStats.currentHealth} Mana: {connection.Game.activePlayer.championStats.resourceValue} Gold: {connection.Game.activePlayer.currentGold}");
                }
                Thread.Sleep(250);
                i++;
            }
            connection.Polling = false;
            Console.WriteLine("Done polling.");
        }
    }

}
