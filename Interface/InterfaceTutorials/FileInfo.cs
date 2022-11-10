using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfaceTutorials
{
	// Interface members must be implemented with the public modifier; otherwise, the compiler will give compile-time errors.
	public class FileInfo : IFile
	{
		public void ReadFile()
		{
			Console.WriteLine("Reading File");
		}

		public void WriteFile(string text)
		{
			Console.WriteLine("Writing to file");
		}

		// Note: không kế thừa phương thức mặc định từ interface => không thể truy cập bằng instance
	}
}
