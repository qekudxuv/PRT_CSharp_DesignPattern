using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Decorate.Component
{
    interface IMessageWriter
    {
        string Message { set; }
        void WriteMessage(string filePath);
    }
}
