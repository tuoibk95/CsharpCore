using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Inside a namespace, class, or structure
/// </summary>
namespace OOP.DataTypes.Enumeration
{
    /// <summary>
    /// sử dụng với mục đích gom nhóm các hằng có liên quan với nhau thành 1 tên duy nhất 
    /// </summary>
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 6,
        // Khi khai báo Friday là 6 thì giá trị sau đó + 1 nếu k asign giá trị cụ thể
        Saturday,
        Sunday
    }
}
