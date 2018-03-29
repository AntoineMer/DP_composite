using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_composite
{
    public class Nombre : Expression
    {
        private double valeur;
       

        public Nombre(double _valeur)
        {
            this.valeur = _valeur;
        }

        public override double SEvaluer()
        {
            return this.valeur;
        }
        public override string FormateGauche()
        {
            return this.valeur.ToString();
        }

    }
}
