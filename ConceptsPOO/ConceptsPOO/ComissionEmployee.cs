﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class ComissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;   
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $" \n\tCommission percentaje:{CommissionPercentaje:P2}"+
                 $" \n\tSales:{Sales:C2}" +
                $" \n\tValue to Pay: {GetValueToPay():C2}";
        }
    }
}
