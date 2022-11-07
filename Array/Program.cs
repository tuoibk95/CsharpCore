using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Program
    {
        public static void Main(String[] args)
        {
            DynamicArray<string> dynArray = new DynamicArray<string>();
            dynArray.Add("L");
            dynArray.Add("V");
            dynArray.Add("T");
            Console.WriteLine(dynArray.ToString());
        }
    }
}
