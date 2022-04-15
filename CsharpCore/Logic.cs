using CsharpCore.AccessModifier;
using CsharpCore.Colection;
using CsharpCore.Delegate;

namespace CsharpCore
{
	internal class Logic
	{
		static void Main(string[] args)
		{
			//byte varByte = 3;
			//short varShort = 9;
			//int varInt = 10;
			//long varLong = 0;

			//// long = 3
			//varLong = varByte; // Biến Long có kiểu dữ liệu lớn hơn biến Byte nên giá trị biến byte có thể gán qua cho biến long
			//Console.WriteLine(" Bien Long = " + varLong);

			//// long = 10
			//varLong = varInt;
			//Console.WriteLine(" Bien Long = {0} ", varLong);

			//// short = 3
			//varShort = varByte;
			//Console.WriteLine(" Bien Short = {0} ", varShort);

			//// int = 3
			//varInt = varShort;
			//Console.WriteLine(" Bien Int = {0}", varInt);

			//Console.ReadKey();


			//#region example
			//// Các lỗi khi khai báo biến
			//int a;
			//Console.WriteLine("a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị

			//int b = 10.9; // Lỗi vì b là kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên (10.9 là kiểu số thực)

			//byte c = 1095; // Lỗi vì c là biến kiểu sbyte (-128,127), byte(0,255) nên không thể nhận giá trị ngoài vùng

			//string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thẻ hiểu là tập hợp nhiều ký tự => sử dụng nháy kép ""

			//long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte... ( có thể sửa lại giá trị không null hoặc thêm ? vào hậu tố long

			//long? f = null; // Lúc này kiểu dữ liệu của f là long

			//int g = 10;

			//byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn

			//string k = "Kteam";
			//Console.WriteLine(" k = " + K); // Lỗi vì C# có phân biệt hoa thường

			//Console.ReadKey();
			//#endregion
			//ArrayListEx arrayList = new ArrayListEx();
			//arrayList.toArrayListEx();

			//HashtableEx hashtableEx = new HashtableEx();
			//hashtableEx.toHashtableEx();

			//SortedListEx sortedListEx = new SortedListEx();
			//sortedListEx.toSortedList();

			//StackEx stackEx = new StackEx();
			//stackEx.toStack();

			//QueueEx queueEx = new QueueEx();
			//queueEx.toQueue();

			RefOutKeyword refOutKeyword = new RefOutKeyword();
			refOutKeyword.toRefOutKeyword();

			//GenericEx genericEx = new GenericEx();
			//genericEx.change();

			//MyGeneric<int> MyG = new MyGeneric<int>(5);
			//MyG.SetItemValue(0, 10);

			//static void Demo() => Console.WriteLine("abc");

			//DelegateEx a = new DelegateEx();
			//a.TinhToanUseDelegate();

			//int Value = 10;
			//object ObjectValue = Value;
			//int newValue = (int) ObjectValue;
			//Console.WriteLine(ObjectValue);
			//Demo();

			//SinhVien sv = new SinhVien();
			//sv.MaSV = "12345";
			//Console.WriteLine(sv.MaSV);
		}
	}
}
