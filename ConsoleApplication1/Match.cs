using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Match
  {
    readonly Player[] _players;
    readonly Swap[] _swaps;


    public Match(Player[] players, Swap[] swaps)
    {
      _players = players;
      _swaps = swaps;
    }

    void PlayMatch()
    {

      for (int i = 1; i <= 60; i++)
      {
        Subs(i);
        SetTime();
      }
    }

    void Subs(int minute)
    {
      foreach (var swap in _swaps)
      {
        if (swap.Minutes == minute)
        {
          _players[swap.PlayerFrom - 1].IsOnPitch = false;
          _players[swap.PlayerTo - 1].IsOnPitch = true;
        }
      }
    }
    
    void SetTime()
    {
      foreach (var player in _players)
      {
        if (player.IsOnPitch)
        {
          player.MinsOnPitch++;          
        }
      }
    }

  }
}
