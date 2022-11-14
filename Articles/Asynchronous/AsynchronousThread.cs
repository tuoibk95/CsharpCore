using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Asynchronous
{
    /// <summary>
    /// Asynchronous: Một tác vụ thực thi trong thread mà không cần phải đợi 1 tác vụ I/O-bound or long-running task thực hiện xong mới chạy
    /// </summary>
    public class AsynchronousThread
	{
        /// <summary>
        /// Tất cả Phương thức trong chuỗi phương thức phải có await keyword để thực hiện bất đồng bộ
        /// Chương trình bắt đầu thực thi 
        /// </summary>
        /// <returns></returns>
        public static async Task TestAsynchronous()
        {
            // LongProcess được thực thi trong 1 lường riêng biệt
            LongProcess();
            // luồng ứng dụng chính tiếp tục thực hiện câu lệnh tiếp theo gọi phương thức ShortProcess() và không đợi LongProcess() hoàn tất.
            ShortProcess();
            Console.ReadKey();
        }

        // Sử dụng void mà k cần Task vì simple asynchronous: Không có giá trị được gọi lại ở await
        static async void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            await Task.Delay(2000); // hold execution for 4 seconds

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
