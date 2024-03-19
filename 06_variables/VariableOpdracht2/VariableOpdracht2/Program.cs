using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            twitchStream.name = "AWOOGA";
            //lastStreamName, waarde: de streamname van de laatste keer
            twitchStream.laststreamname = "Playing STS";
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            twitchStream.streamGame = new Game("STS");
            //followers, waarde: hoeveel followers
            twitchStream.followers = 1343213;
            //automod, waarde: staat automod aan?
            twitchStream.automod = true;


            Console.WriteLine("Hello, World!");
        }
    }
}