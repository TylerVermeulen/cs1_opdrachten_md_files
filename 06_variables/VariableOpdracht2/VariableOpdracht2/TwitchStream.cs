using System;

namespace VariableOpdracht2
{
    internal class TwitchStream
    {
        //maak hier class variables aan:
        // type=string, naam: name,
        internal string name = "AWOOGA";
        // type=string, naam: lastStreamName
        internal string laststreamname = "Playing STS";
        // type=Game, naam: streamGame
        internal Game streamGame = new Game("balls");
        // type=int, naam: followers
        internal int followers = 1343213;
        // type=bool, naam: automod
        internal bool automod = true;
        
    }
}