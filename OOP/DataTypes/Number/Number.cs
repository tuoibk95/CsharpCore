using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DataTypes.Number
{
	/// <summary>
	/// Number in C#: Integer Types, Floating-point types
	/// Integer Types: byte(8),short(16),int(32),long(64) - không có số dấu thập phân. Nó có thể là số âm hoặc số dương
	/// Floating-point types: float(32),double(64), decimal(64) - có 1 hoặc nhiều số thập phân. Nó có thể là số âm hoặc số dương
	/// </summary>
	public class Number
	{
		#region Integer Types
		// Byte 0 - 255
		byte b1 = 255;
//		byte b2 = -128; // compile-time error: Constant value '-128' cannot be converted to a 'byte'
		// SByte -128 - 127

		short s1 = -32768;
		short s2 = 32767;
//		short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'
		ushort us1 = 65535;
//		ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

		int i = -2147483648;
		int j = 2147483647;
//		int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.
		uint ui1 = 4294967295;
//		uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'
		// hệ 16 và nhị phân
		int hex = 0x2F;
		int binary = 0b_0010_1111;

		long l1 = -9223372036854775808;
		long l2 = 9223372036854775807;
		ulong ul1 = 18223372036854775808ul;
		ulong ul2 = 18223372036854775808UL;


		#endregion
	}
}
