using DP.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Adapter.Implement
{
    //國王企鵝
    public class KingPenguins : IPenguin   
    {
        public void Penguin_gobble()
        {
            Console.WriteLine("企鵝叫");
        }
     
        public void Penguin_walk()
        {
           Console.WriteLine("企鵝走路"); 
        }
   }
}
