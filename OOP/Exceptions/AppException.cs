using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOP.Exceptions
{
    /// <summary>
    /// Trong quá trình thực thi, 1 ngoại lệ xảy ra => nhảy đến catch block phù hợp đầu tiên
    /// Khối try đi theo sau phải có khối catch hoặc finally hoặc cả 2 - nếu k sẽ compile-time error
    /// Multiple catch blocks with the same exception type are not allowed.
    /// A catch block with the base Exception type must be the last block.
    /// 
    /// Không được phép 1 khối catch không parameter và 1 khối có Exception parameter trong cùng 1 câu lệnh -vì cả 2 cùng thực hiện 1 việc
    /// Khối catch rỗng hoặc khối catch Exception phải được đặt xuống cuối cùng,
    /// trình biên dịch sẽ báo lỗi nếu sau khối catch k tham số or Exception catch có khối lệnh catch khác
    /// </summary>
    public class AppException
	{
		public static void TestException()
		{
            Console.Write("Please enter a number to divide 100: ");
            Student std = null;
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result1 = 100 / num;
                PrintStudentName(std);

                Console.WriteLine("100 / {0} = {1}", num, result1);
                try
                {
                    int result2 = 100 / num;

                    Console.WriteLine("100 / {0} = {1}", num, result2);

                }
				catch (DivideByZeroException ex)
				{
                    Console.Write("Cannot divide by zero. Please try again.");
                }
            }
            // Khối try catch lồng nhau thì ngoại lệ sẽ được bắt trong khối catch đầu tiên theo khối
            catch (DivideByZeroException ex)
            {
                Console.Write("1-Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid format. Please try again.");
            }
            // Nếu không có khối catch phù hợp nó sẽ nhảy đến khối catch không parameter or Exception
            catch (Exception ex)
            {
                Console.Write("Error occurred! Please try again.");
            }
            /// Không được có nhiều khối finally
            /// Không được có có từ khóa continue, break, return
			finally
			{
				Console.WriteLine("Clean up");
			}
        }

        public static void PrintStudentName(Student std)
        {
            if (std == null)
                /// Bất kì kiểu exception nào có nguồn gốc từ Exception đều có thể được ném ra bằng throw keyword
                /// throw new : tạo ra 1 đối tượng thuộc bất kỳ loại ngoại lệ hợp lệ nào
                /// Cũng có thể dùng throw; để ném ra ngoại lể cho đối tượng khác phù hợp gọi đến xử lý
                /// không nên dùng (throw ex) vì khi phương thức cuối bắt và sử lý ngoại lệ nó sẽ không in ra log ở vị trí gốc
                throw new NullReferenceException("Student object is null. ");
            Console.WriteLine(std.StudentName);
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
    }

    /// <summary>
    /// Custom exception
    /// </summary>
    [Serializable]
    class InvalidStudentNameException : Exception
    {
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
        }
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
}
