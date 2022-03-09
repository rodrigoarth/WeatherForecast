using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClimaTempo.Models
{
    public class ClimaTempoContext : DbContext
    {
        public ClimaTempoContext(DbContextOptions<ClimaTempoContext> options)
            :base(options)
        {
        
        }

        public DbSet<PrevisaoClima> Climas { get; set; }
    }
}