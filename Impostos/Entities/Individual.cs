using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impostos.Entities;

namespace Impostos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public object Anuallincome { get; }
        public double Health { get; }
        public object HealthExpenditures1 { get; }


        public Individual(string name, double anualIncome, object healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures1 = healthExpenditures;
        }

        public override double Tax()  // UTILIZAR IF E ELSE 
        {
            if(AnualIncome <= 20000)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.50;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.50;
            }
        }
    }



}
