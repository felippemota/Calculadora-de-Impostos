using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Impostos.Entities;

namespace Impostos.Entities
{
    class Company : TaxPayer
    {

        public int NumberofEmployees { get; set; }

        public Company(int numberofEmployees, double anualincome, string name)
        {
            NumberofEmployees = numberofEmployees;
            Name = name;
            AnualIncome = anualincome;

        }

        public Company(string name, double anualIncome, double income) : base(name, anualIncome)
        {
        }

        public override double Tax()
        {
            if (NumberofEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}