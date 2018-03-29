using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP_composite;

namespace DP_composite_Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Nombre(1),new Addition(new Nombre(1), new Soustraction(new Nombre(4), new Nombre(2))));
           // double resultat = exp1.SEvaluer();
            Console.WriteLine(exp1.Formate());
            Console.ReadLine();

            Expression exp2 = new Soustraction(new Nombre(8), new Nombre(4));
         //   double resultatS = exp2.SEvaluer();
            Console.WriteLine(exp2.Formate());
            Console.ReadLine();
        }
    }
}
