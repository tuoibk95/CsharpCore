using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Asynchronous
{
    /// <summary>
    /// Khi trong cùng 1 luồng đồng bộ có các phương thức làm tốn thời gian thì ta không đợi mà tách các phương thức ra các luồng riêng biệt để thực hiện
    /// khi cần giá trị trả về của 1 phương thức bất đồng bộ thì thêm await đợi cho đến khi Async method hoàn thành để gán giá trị
    /// </summary>
	public class MultiAsynchronousMethod
	{
        public static async Task TestAsynchronousTask()
        {
            Task<int> result1 = LongProcess1();
            Task<int> result2 = LongProcess1();
            ShortProcess();
            //do something here
            Console.WriteLine("After two long processes.");

            var val1 = await result1; // wait untile get the return value
            Console.WriteLine("Result: {0}", val1);
            var val2 = await result2; // wait untile get the return value
            Console.WriteLine("Result: {0}", val2);
            Console.ReadKey();
        }

        public static async Task<int> LongProcess1()
        {
            Console.WriteLine("LongProcess1 Started");

            //some code that takes long execution time 
            await Task.Delay(1000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess1 Completed");
            return 10;
        }
        public static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess2 Started");

            //some code that takes long execution time 
            await Task.Delay(2000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess2 Completed");
            return 20;
        }

        public static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}
