using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple
{
	/// <summary>
	/// Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
	/// what does it mean by extension and modification?
	/// The extension means adding new features to the system without modifying that system.
	/// OCP says the behavior of a method of a class should be changed without modifying its source code.
	/// You should not edit the code of a method (bug fixes are ok) instead you should use polymorphism or other techniques to change what it does.
	/// Adding new functionality by writing new code.
	/// 
	/// =>OCP using inheritance makes it "Open for extension and closed for modification"
	/// Easily add new functionalities by adding new classes wherein no current functionality depends on the new classes.
	/// Ưu điểm: Minimize the possibilities of error by not modifying existing classes.
	/// </summary>
	internal class O
	{
		#region  Open/Closed principle can be applied using the following approaches:
		/// Using Function Parameters
		/// Using Extension methods
		/// Using Classes, Abstract class, or Interface-based Inheritance
		/// Generics
		/// Composition and Dependency Injection
		#endregion
		public static void Log(string message)
		{
			Console.WriteLine(message);
		}

		public static void Info(string message)
		{
			Console.WriteLine($"Info: {message}");
		}

		public static void Debug(string message)
		{
			Console.WriteLine($"Debug: {message}");
		}
	}
}
