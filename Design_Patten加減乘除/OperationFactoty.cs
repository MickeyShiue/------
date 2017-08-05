using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patten加減乘除
{
    class OperationFactoty
    {
        public static Operation CreateOperatiom(string operate)
        {
            Operation oper = null;

            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }

            return oper;
        }
    }
}
