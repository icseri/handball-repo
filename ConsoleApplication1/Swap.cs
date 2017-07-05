using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  class Swap
  {
        public Swap(int min, int playerFrom, int playerTo)
        {
            Minutes = min;
            PlayerFrom = playerFrom;
            PlayerTo = playerTo;
        }

        public static Swap FromString(string s)
        {
            var data = s.Split('.', ' ', 'p', 'e', 'r', 'c', ',');
            return new Swap(
                int.Parse(data[0]),
                int.Parse(data[8]),
                int.Parse(data[10])
                );
        }


        public int Minutes { get; set; }
        public int PlayerFrom { get; set; }
        public int PlayerTo { get; set; }    
  }
}
