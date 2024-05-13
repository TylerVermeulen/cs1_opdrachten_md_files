using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryOpdracht3
{
    internal class Game
    {
        private Dictionary<string, MonsterMaker> makers = new Dictionary<string, MonsterMaker>();
        private Room[] rooms = new Room[4];
        internal Game()
        {
            MonsterMaker orcMaker = new MonsterMaker() { Name = "orc" };
            MonsterMaker slimeMaker = new MonsterMaker() { Name = "slime" };
            MonsterMaker lamiaMaker = new MonsterMaker() { Name = "lamia" };
            MonsterMaker dryadMaker = new MonsterMaker() { Name = "dryad" };
            //voeg de orc en slime toe aan de dictionary

            makers.Add(orcMaker.Name, orcMaker);
            makers.Add(slimeMaker.Name, slimeMaker);
            makers.Add(lamiaMaker.Name, lamiaMaker);
            makers.Add(dryadMaker.Name, dryadMaker);
            //maak nog 2 andere monstermakers aan
            

            MakeRooms();
        }

        private void MakeRooms()
        {
            rooms[0] = new Room()
            {
                allowedMonsters = new string[] { "orc" },
                monsters = new Monster[2]
            };


            //maak nog 3 andere rooms aan. in de array voor index 1,2 & 3
            rooms[1] = new Room()
            {
                allowedMonsters = new string[] { "slime" },
                monsters = new Monster[2]
            };
            rooms[2] = new Room()
            {
                allowedMonsters = new string[] { "lamia" },
                monsters = new Monster[2]
            };
            rooms[3] = new Room()
            {
                allowedMonsters = new string[] { "dryad" },
                monsters = new Monster[2]
            };

        }

        internal void RunGameSim()
        {
            Random random = new Random();

            Room room = rooms[random.Next(rooms.Length)];

            //maak een monster voor elke monster in de room, gebruik room.monsters
            
            for (int i = 0; i < room.monsters.Length; i++)
            {
                //selecteer een monster type uit room.allowedMonsters met de random, zie ook de room random
                string toMake = room.allowedMonsters[random.Next(room.allowedMonsters.Length)];

                //haal de maker op uit de dictionary op basis van de naam
                MonsterMaker maker = makers[toMake];
                Monster m = maker.Make();
                Console.WriteLine(m.Name);
                room.monsters[i] = m;//zet het monster in de kamer
            }
        }
    }
}