using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Any changes in the logging requirement would cause the Student class to change.
    /// Để tránh khi admin quyết định ghi nhật ký tất cả các hoạt động trong tệp văn bản thì cần thayd đổi student class.
    /// => Tạo một lớp riêng chịu trách nhiệm cho tất cả các hoạt động ghi nhật ký (log)
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// Mình là người viết ra class Logger và các dev khác muốn sử dụng lại lớp Logger để k phải mất tg viết lại. (SOLID thúc đẩy khả năng tái sử dụng)
        /// Ở đây thì có 2 loại dev muốn sử dụng lớp Logger của bạn:
        /// -Làm cách nào để có thể sử dụng cho cả 2 người mà k không ảnh hưởng đến các dev khác k muốn chỉnh sửa?
        /// => Sử dụng OCP principle: giai pháp của vấn đề này là sử dụng class based-inheritance(polymorphism)and override methods.
        /// => thêm từ khóa override methods khi muốn sửa đổi để dùng nó và kế thừa class Logger vào 1 class mới
        /// </summary>
        /// <param name="message"></param>
        public virtual void Log(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void Info(string message)
        {
            Console.WriteLine($"Info: {message}");
        }

        public virtual void Debug(string message)
        {
            Console.WriteLine($"Debug: {message}");
        }
    }
}
