using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CSVfileHandler
    {
        public string Location { get; set; }

        public CSVfileHandler()
        {
        }

        public List<Stock> inputStream(string location)
        {
            try
            {
                var reader = new StreamReader(File.OpenRead(location));
                List<Stock> csvList = new List<Stock>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(new char[] { ',' }, 2);  //TODO: need to have an if statement that looks to see if the file just has symbol,name or symbol, price,name
                    if (values[0].Length <= 6)
                    {
                        try
                        {
                            Stock stock = new Stock(values[0].PadRight(6), values[1]);
                            csvList.Add(stock);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                }

                return csvList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }
    }
}
