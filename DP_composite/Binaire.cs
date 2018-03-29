using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_composite
{
    public abstract class Binaire : Expression
    {
       protected Expression op1;
       protected Expression op2;

       public Binaire(Expression _op1, Expression _op2) 
       {
           this.op1 = _op1;
           this.op2 = _op2;
       }
       abstract override public double SEvaluer();
    }
}
