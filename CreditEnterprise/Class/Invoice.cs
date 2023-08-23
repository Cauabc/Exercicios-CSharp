using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditEnterprise.Interface;

namespace CreditEnterprise.Class
{
    public class Invoice : IContractInvoice
    {
        private readonly int _portionAmount;
        private DateTime _timeNow;
        private readonly double _value;
        public Invoice(DateTime timeNow, int portionAmount, double value)
        {
            _timeNow = timeNow;
            _portionAmount = portionAmount;
            _value = value;
        }

        public void GenerateInvoice()
        {
            for (int i = 1; i <= _portionAmount; i++)
            {
                _timeNow = _timeNow.AddDays(30);
                Console.WriteLine($"Data para pagar {i}° Parcela: {_timeNow}");
                Console.WriteLine($"Valor da parcela: R${_value:F}");
                Console.WriteLine("\n");
            }
        }
    }
}