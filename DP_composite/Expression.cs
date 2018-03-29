using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_composite
{
    public abstract class Expression
    {
        public Expression()
        {

        }

        abstract public double SEvaluer();


        public virtual string Formate()
        {
            return FormateGauche() + "=" + SEvaluer().ToString();
        }
        public virtual string FormateGauche()
        {
            return string.Empty;   
        }

    }
}
