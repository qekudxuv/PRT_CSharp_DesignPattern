using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Strategy
{
    public interface IStrategy
    {
        int Calculate(int listPrice);
    }
}
