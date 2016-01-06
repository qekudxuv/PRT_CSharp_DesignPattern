using DP.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Adapter.Implement
{
    //綠頭鴨
    public class MallardDuck : IDuck    
    {
        public void Duck_quack()
        {
            Console.WriteLine("鴨子叫");
        }
     
        public void Duck_walk()
        {
           Console.WriteLine("鴨子走路"); 
        }
   }
}
