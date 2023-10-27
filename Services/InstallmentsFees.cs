using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Interface.Services
{
    internal class InstallmentsFees : IFees
    {
        public double Interest(double amount, int month)
        {
            double N1 = (double) month / 100 * amount + amount;
            double instalment = N1 * 0.02 + N1;
            return instalment;
          }
    }
}
