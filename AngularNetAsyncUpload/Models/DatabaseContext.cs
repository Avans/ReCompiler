using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularNetAsyncUpload.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=LocalHost")    
        {

        }

        public DbSet<CalculatorTestResult> CalculatorTestResults { get; set; }
    }
}