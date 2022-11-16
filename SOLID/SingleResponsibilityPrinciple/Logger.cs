using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// Any changes in the logging requirement would cause the Student class to change.
    /// Để tránh khi admin quyết định ghi nhật ký tất cả các hoạt động trong tệp văn bản thì cần thayd đổi student class.
    /// => Tạo một lớp riêng chịu trách nhiệm cho tất cả các hoạt động ghi nhật ký (log)
    /// </summary>
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public static void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }
}
