using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfaceTutorials
{
	// Interface members must be implemented with the public modifier; otherwise, the compiler will give compile-time errors.
	/// The FileInfo class can also contain members other than interface members.
	public class FileInfo : IFile
	{
		public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void ReadFile()
		{
			Console.WriteLine("Reading File");
		}

		// Explicit Implementation: FileInfo sẽ không sử dụng đc => compile-time error 
		// Do not use public modifier with an explicit implementation. It will give a compile-time error.
		void IFile.WriteFile(string text)
		{
			Console.WriteLine("Writing to file");
		}

		public void Search(string text)
		{
			Console.WriteLine("Searching in file");
		}

		// Note: không kế thừa phương thức mặc định từ interface => không thể truy cập bằng instance
	}
}
