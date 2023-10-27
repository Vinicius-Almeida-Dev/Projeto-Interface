using Projeto_Interface.Entities;
using System;
namespace Projeto_Interface.Services
{
    internal class ContractService
    {
        private IFees _Fees;

        public ContractService(IFees fees)
        {
            _Fees = fees;
        }

        public void ProcessContract(Contract contract, int month)
        {
            double InstallmentV = contract.TotalValue / month;                      

            for (int i = 1; i <= month; i++)
            {
                double DefinitiveInstallmentValue = _Fees.Interest(InstallmentV, i);
                DateTime DefinitiveDueDate = contract.Date.AddMonths(i);
                contract.Installments.Add( new Installment(DefinitiveDueDate, DefinitiveInstallmentValue));

            }

        }
    }
}
