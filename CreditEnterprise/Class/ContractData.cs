using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditEnterprise.Class
{
    public class ContractData
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public int PortionAmount { get; set; }
        private readonly double _taxPortion = 0.01;
        private readonly double _taxPayment = 0.02;

        public ContractData(int contractNumber, DateTime timeNow, double totalValue, int portionAmount)
        {
            Number = contractNumber;
            Date = timeNow;
            TotalValue = totalValue;
            PortionAmount = portionAmount;
        }

        public double GetPortion()
        {
            double eachPortionValue = TotalValue / PortionAmount;
            return eachPortionValue + eachPortionValue * (_taxPayment + _taxPortion);
        }

    }
}