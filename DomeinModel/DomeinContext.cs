using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeinModel
{
    public class DomeinContext : DbContext
    {
        public DbSet<CalculatorTestResultaat> CalculatorToetsResultaten { get; set; }
    }
}
