using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Calculator : ICalculate
    {
        public double GetPayment(Credit credit)
        {
            return (credit.Total - credit.First) / (credit.Years * 12 - 1);
        }
    }
}