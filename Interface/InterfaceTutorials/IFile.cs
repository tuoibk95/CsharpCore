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
	/// An interface cannot contain constructors, destructor and fields.
	/// Interface members are by default abstract and public.
	/// cannot apply access modifiers to interface members.
	/// C# 8.0 onwards, you may use private, protected, internal, public, virtual, abstract, sealed, static, extern, and partial modifiers on certain conditions.
	/// An interface can inherit one or more interfaces.
	/// </summary>
	public interface IFile
	{
		// Interface cannot contain fields, and auto-implemented properties.
		public string FileName { get; set; }
		void ReadFile();
		void WriteFile(string text);

		// Không thể kế thừa default method => k thể truy cập khi dùng instance
		void DisplayName() // default method of interface: Có thể implementation bên trong method
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
