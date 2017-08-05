using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patten加減乘除
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數字：");
            string strNumber1 = Console.ReadLine();

            Console.WriteLine("請輸入 + - * /任何一個運算符號：");
            string strOperate = Console.ReadLine();

            Console.WriteLine("請輸入第二個數字：");
            string strNumber2 = Console.ReadLine();

            //透過傳入的符號，決定New的類別是誰，把 + - * / 抽離
            //將來不管是 + - * / 任何一個邏輯要增加更改，都不應該修改到影響到其他運算的功能
            //或是未來要增加其他運算功能，彈性才夠大
            Operation oper = OperationFactoty.CreateOperatiom(strOperate);
            oper.Number1 = Convert.ToDouble(strNumber1);
            oper.Number2 = Convert.ToDouble(strNumber2);
            double result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
