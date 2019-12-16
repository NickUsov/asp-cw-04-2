using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public interface ICalculate
    {
        double GetPayment(Credit credit);
    }
}
