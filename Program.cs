using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210046
{
    internal class Program
    {
        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates;

            public SimpleDataBase() 
            {
                this.storedData = new List<T>();
                this.inputDates = new List<DateTime>();
            }

            public void AddNewData(T data)
            {
            
                this.storedData.Add(data);
                this.inputDates.Add(DateTime.Now);
   
            }

            public void PrintAllData()
            {
                for(int i = 0; i < storedData.Count(); i++)
                {
                    Console.WriteLine("Data " + i + " berisi " + storedData[i] + 
                        ", yang disimpan pada waktu UTC: " + inputDates[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.AddNewData(13);
            data.AddNewData(02);
            data.AddNewData(21);
            data.PrintAllData();

        }
    }
}
