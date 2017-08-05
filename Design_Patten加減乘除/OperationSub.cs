using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patten加減乘除
{
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = Number1 - Number2;
            return result;
        }


    }
}
