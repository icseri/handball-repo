using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    static class FileHandler
    {
        const string SubFileName = "subs.txt";
        const string PlayersFileName = "players.txt";

        public static Player[] ReadPlayers()
        {
            var data = File.ReadAllLines(PlayersFileName);
            var numberOfPlayers = int.Parse(data[0].Substring(2));
            string[] line = data[1].Substring(2).Split(',');
            int[] startPlayers = new int[line.Length];
            for (int i = 0; i < startPlayers.Length; i++)
            {
                startPlayers[i] = int.Parse(line[i]);
            }
            var players = new Player[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players[i] = new Player();
                players[i].Number = i + 1;
                for (int j = 0; j < startPlayers.Length; j++)
                {
                    if (startPlayers[j] == players[i].Number)
                        players[i].IsOnPitch = true;                  
                }
            }
            return players;


        }


        public static Swap[] ReadSubs()
        {
            var data = File.ReadAllLines(SubFileName);
            var subs = new Swap[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                subs[i] = Swap.FromString(data[i]);
            }
            return subs;
        }

    }
}
