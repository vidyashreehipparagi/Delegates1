using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c= new Calculation();
            MyDelegate mydel = new MyDelegate(c.Add);
            Console.WriteLine(mydel.Invoke(30, 30));
            Test t= new Test();
            Delegate1 d = new Delegate1(t.AcceptDetails);
            d.Invoke(1, "Vidyashree", 50000);
        }
    }
}
