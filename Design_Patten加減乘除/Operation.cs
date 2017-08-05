using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patten加減乘除
{
    class Operation
    {       
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public virtual double GetResult()
        {

            double result = 0;
            return result;
        }
    }
}
