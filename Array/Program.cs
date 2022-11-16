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
            DynamicArray<string> dynamicArray = new DynamicArray<string>();
            dynamicArray.Add("L");
            dynamicArray.Add("V");
            dynamicArray.Add("T");
            Console.WriteLine(dynamicArray.ToString());
        }
    }
}
