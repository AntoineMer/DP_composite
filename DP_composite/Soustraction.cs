using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_composite
{
    public class Soustraction : Binaire
    {
        public Soustraction(Expression _op1, Expression _op2) : base(_op1, _op2)
        {
        }

        public override double SEvaluer()
        {
            return op1.SEvaluer() - op2.SEvaluer();

        }

        public override string FormateGauche()
        {
            return op1.FormateGauche().ToString() + "-" + op2.FormateGauche().ToString();
        }

    }
}
