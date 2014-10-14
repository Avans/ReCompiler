using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeinModel
{
    public class CalculatorTestResultaat
    {
        [Key]
        public int Id { get; set; }

        public bool ResultaatAdd { get; set; }

        public bool ResultaatMultiply { get; set; }
    }
}
