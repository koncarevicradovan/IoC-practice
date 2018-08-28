using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_practice.Logger
{
    public class MyLogger : IMyLogger
    {
        
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
