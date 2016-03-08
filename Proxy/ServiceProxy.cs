using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Proxy
{
    public class ServiceProxy : IService
    {
        private IService _service = new Service();
        public void Execute()
        {
            //add log
            Console.WriteLine("start execution");
            _service.Execute();
            Console.WriteLine("end execution");
        }
    }
}
