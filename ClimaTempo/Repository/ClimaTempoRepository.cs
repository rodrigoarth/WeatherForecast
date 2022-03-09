using ClimaTempo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ClimaTempo.Repository
{
    public class ClimaTempoRepository : IClimaTempo
    {
        private readonly ClimaTempoContext _context;
        public ClimaTempoRepository(ClimaTempoContext context)
        {
            _context = context;
        }
        public IList<PrevisaoClima> GetMaxTemp()
        {
            var maxTemp = _context.Climas.OrderByDescending(c => c.TemperaturaMaxima);


            return ((IList<PrevisaoClima>)maxTemp);
        }

        public IList<PrevisaoClima> GetMinTemp()
        {
            var minTemp = _context.Climas.OrderBy(c => c.TemperaturaMinima);

            return ((IList<PrevisaoClima>)minTemp);
        }
    }
}