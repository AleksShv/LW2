using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW2.LW2_1
{
    class Recipient
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int AnnualIncome { get; init; }

        private static int _globalId;

        public Recipient(string name, int annualIncome)
        {
            Id = _globalId++;
            Name = name;
            AnnualIncome = annualIncome;
        }
    }
}
