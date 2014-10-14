using SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AngularNetAsyncUpload.Models
{
    public class DecompilerCalcy
    {
        public int Decompile(string location)
        {
            //Load assembly
            Assembly assembly = Assembly.LoadFrom(location);

            //Find the type that inherits from ICalcy and cast it to a calcy
            var iType = typeof(ICalcy);
            var type = assembly.GetTypes().First(p => iType.IsAssignableFrom(p));

            //Create a Caculcator based on the first type that was in the assembly
            ICalcy calculator = Activator.CreateInstance(type) as ICalcy;

            CalculatorTestResult result = new CalculatorTestResult();

            //Assert
            result.AddResult = calculator.Add(1, 1) == 2;
            result.MultiplyResult =  calculator.Multiply(2, 2) == 4;

            using(var context = new DatabaseContext())
            {
                result = context.CalculatorTestResults.Add(result);
                context.SaveChanges();
            }

            return result.Id;
        }
    }
}