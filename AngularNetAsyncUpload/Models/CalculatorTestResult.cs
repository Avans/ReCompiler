using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularNetAsyncUpload.Models
{
    public class CalculatorTestResult
    {
        [Key]
        public int Id { get; set; }

        public bool AddResult { get; set; }

        public bool MultiplyResult { get; set; }
    }
}