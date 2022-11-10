using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.InterfaceTutorials
{
	/// <summary>
	/// An interface can contain declarations of methods, properties, indexers, and events.
	/// Default interface methods with implementation body are supported from C# 8.0.
	/// An interface cannot contain constructors and fields.
	/// Interface members are by default abstract and public.
	/// C# 8.0 use access modifier
	/// </summary>
	public interface IFile
	{
		void ReadFile();
		void WriteFile(string text);
		void DisplayName() // default method of interface
		{
			Console.WriteLine("IFile C# 8.0 added suport for virtual extension method");
		}

		virtual void DisplayName(string text)
		{
			Console.WriteLine(text);
		}
		private void ABC()
		{
			Console.WriteLine("private");
		}
		internal void ABC1()
		{
			Console.WriteLine("internal");
		}

		sealed void ABCD()
		{
			Console.WriteLine("Sealed");
		}
	}
}
