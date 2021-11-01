using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_game
{
    internal class Coin
    {
        public bool ishead { get; set; }
        public Coin(bool head)
        {
            this.ishead = head;
        }

        public bool flip(Random r)
        {
            var x = r.Next(10);
            if (x > 5)
            {
              return  ishead = true;
            }
            else
            {
                return ishead =  false;   
            }
        }
    }
}
