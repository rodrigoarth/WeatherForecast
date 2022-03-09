using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClimaTempo.Models;

namespace ClimaTempo.Repository
{
    interface IClimaTempo
    {
        IList<PrevisaoClima> GetMaxTemp();
        IList<PrevisaoClima> GetMinTemp();
    }
}
