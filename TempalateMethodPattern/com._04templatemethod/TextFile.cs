using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempalateMethodPattern.com._04templatemethod
{
    public class TextFile : DataProcessor
    {
         
        public override void ReadData()
        {
            Console.WriteLine("Reads data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data from text file");
        }

        
    }
}
