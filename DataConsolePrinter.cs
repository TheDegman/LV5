using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class DataConsolePrinter
    {

        public void PrintDataset(IDataset dataset)
        {
            if(dataset.GetData() == null)
            {
                Console.WriteLine("Invalid User");
               
            }
            else
            {
                foreach (List<string> row in dataset.GetData())
                {
                    foreach (var d in row)
                    {
                        Console.WriteLine(d + "\t");
                    }
                }

            }
            
        }
    }
}
