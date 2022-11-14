using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Asynchronous
{
    /// <summary>
    /// Sử dụng asynt, await & Task nếu phương thức async trả về 1 giá trị đang được gọi lại
    /// </summary>
	public class AsynchronousTask
	{
        public static async Task TestAsynchronousTask()
        {
            Task<int> result = LongProcess();
            ShortProcess();

            var val = await result; // wait untile get the return value
            Console.WriteLine("Result: {0}", val);
            Console.ReadKey();
        }

        public static async Task<int> LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
            return 10;
        }

        public static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}
