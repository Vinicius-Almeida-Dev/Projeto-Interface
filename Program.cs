using System;
using Projeto_Interface.Entities;
using Projeto_Interface.Services;
using System.Globalization;

namespace Projeto_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double ContractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int Installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(Number, Date, ContractValue, Installments);
            ContractService cs = new ContractService(new InstallmentsFees());
            cs.ProcessContract(contract);

            Console.WriteLine("Installments: ");
            foreach (Installment obj in contract.Installments)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
