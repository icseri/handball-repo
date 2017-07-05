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

        public static Player[] CreatePlayers()
        {
            Player[] players = new Player[10];
            for (int i = 0; i < 10; i++)
            {
                players[i] = new Player();
                players[i].Number = i + 1;
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
