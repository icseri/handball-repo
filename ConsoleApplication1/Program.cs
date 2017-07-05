using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      StartMenu();
    }

    static void StartMenu()
    {
      string cmd = null;      
      do
      {
        Console.Clear();
        Console.WriteLine("---Handball simulation---");
        Console.Write("1: Szimuláció\n2:Eredmények\n3:Kilépés a programból\nParancs: ");
        cmd = Console.ReadLine();
        switch (cmd)
        {
          case "1":
            Console.Clear();
            //Match match = new Match();
            //match.PlayMatch();
            Console.ReadKey();
            break;
          case "2":
            Display.DisplayPlayers(new Player[] { new Player { Number = 1, MinsOnPitch = 10} });
            Console.ReadKey();
            break;
          case "3":
            break;          
          default:
            Console.WriteLine("Hibás parancs...");
            Thread.Sleep(500);
            break;
        }

      } while (cmd != "3");
    }
  }
}
