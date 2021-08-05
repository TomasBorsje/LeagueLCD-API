# League LiveClientData API
An unofficial C# library for tracking statistics on locally-running League of Legends games.
Can provide all the data the official Riot LiveClientData API provides.

## How to use:
Create a new instance of **GameConnection** and wait for the **Connected** property to be true.

The **GameConnection** will automatically attempt to connect and poll a locally running League of Legends match.

Access the data through the **Game** property.

To stop polling, set the **Polling** property to false.

For more accurate data, set the **TickRate** to a higher value. The connection will poll this many times per second.
