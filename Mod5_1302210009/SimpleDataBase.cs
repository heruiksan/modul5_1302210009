using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_1302210009
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData { get; set; }
        private List<DateTime> inputDates { get; set; }

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0;i< storedData.Count; i++)
            {
                Console.WriteLine("Data"+ (i+1) + "berisi" + storedData.ElementAt(i) + "Yang di simpan pada waktu UTC : " +inputDates.ElementAt(i)  );
            }
        }
    }
}
