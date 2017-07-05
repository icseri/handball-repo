using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  static class Display
  {
    public static void DisplayPlayers(Player[] players)
    {
      foreach (var player in players)
      {
        Console.WriteLine($"Játékos: {player.Number}, Játkban töltött idő: {player.MinsOnPitch}");       
      }
    }
  }
}
