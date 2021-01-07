using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempalateMethodPattern.com._04templatemethod
{
    class TestTemplateMethod
    {
        static void Main()
        {
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessSave();
            //obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            TextFile obj2 = new TextFile();
            obj2.ReadProcessSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();
        }
    }
}
