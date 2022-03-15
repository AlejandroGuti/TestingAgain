using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAgain
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, \n\t Commission percentaje: {CommissionPercentaje:P2}, \n\t Sales: {Sales}, \n\t Value To Pay: {$"{GetValueToPay:C2}",15}  ";
        }
    }
}
