using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfaceTutorials
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//  can access IFile members with the IFile type variables as well as FileInfo type variable.
			IFile ifile = new FileInfo();
			FileInfo fileInfo = new FileInfo();
			ifile.ReadFile();
			ifile.WriteFile("content");
			ifile.DisplayName();
			ifile.ABCD();
			fileInfo.ReadFile();
			fileInfo.WriteFile("content");
		}
	}
}
