using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Asynchronous
{
    /// <summary>
    /// Đồng bộ: Như thấy ở Test method thì LongProcess phải thực hiện xong thì ShortProcess mới đưuọc thực thi
    /// </summary>
	public class Synchoronous
	{
        public static void TestSynchronous()
        {
            LongProcess();

            ShortProcess();
        }

        static void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
        }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}
