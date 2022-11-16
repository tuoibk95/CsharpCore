using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// enum is an abstract class.
/// Inside a namespace, class, or structure
/// </summary>
namespace OOP.DataTypes.Enumeration
{
    /// <summary>
    /// sử dụng với mục đích gom nhóm các hằng có liên quan với nhau thành 1 tên duy nhất 
    /// Gán tên Constant cho một nhóm các số nguyên 
    /// Enum thuộc bất kỳ kiểu dữ liệu như: byte, sbyte, short, ushort, int, uint, long, or ulong(chỉ định bằng cách thêm enumName : data type). Không được là string type
    /// </summary>
    enum WeekDays : int
    {
        Monday, // WeekDays.Monday dễ đọc hơn số 0 khi đề cập đến ngày trong tuần
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 6,
        // Khi khai báo Friday là 6 thì giá trị sau đó + 1 nếu k asign giá trị cụ thể
        Saturday,
        Sunday
    }

    public class ConvertIntToEnum
	{
        static void DoConvertInToEnum()
		{
            Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int)WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday

            int i = 2, j = 6, k = 10;
            WeekDays day1, day2, day3, day4, day5, day6;

            // Convert int to by Type Casting
            day1 = (WeekDays)i; //Wednesday
            day2 = (WeekDays)j; //Sunday
            day3 = (WeekDays)k; //10

            // Convert int to Enum using Enum.ToObject() Method
            day4 = (WeekDays)Enum.ToObject(typeof(WeekDays), i); //Wednesday
            day5 = (WeekDays)Enum.ToObject(typeof(WeekDays), j); //Sunday
            day6 = (WeekDays)Enum.ToObject(typeof(WeekDays), k); //10
        }
	} 
}
