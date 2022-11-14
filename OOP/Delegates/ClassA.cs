using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates
{
	/// <summary>
	/// target function phải match với delegate (void MyDelegate(string msg) <=> void MethodA(string message))
	/// 1. Declare a delegate
	/// 2. Set a target method
	/// 3. Invoke a delegate
	/// </summary>
	internal class ClassA
	{
		public delegate void MyDelegate(string msg);

		// set target method
		// MyDelegate myDelegate = new MyDelegate(MethodA);
		// or
		// MyDelegate myDelegate1 = MethodA;
		// or
		// MyDelegate myDelegate2 = (string msg) => Console.WriteLine(msg);
		/// <summary>
		/// Truyền 1 hàm như 1 method
		/// </summary>
		/// <param name="myDelegate"></param>
		public static void InvokeDelegate(MyDelegate myDelegate)
		{
			myDelegate("A method can have a parameter of the delegate type.");
		}

		// target method
		static void MethodA(string message)
		{
			Console.WriteLine("Test delegate: " + message);
		}

		public static void TestDelegate()
		{
			MyDelegate myDelegate = new MyDelegate(MethodA);
			myDelegate.Invoke("Hello World!");
			InvokeDelegate(myDelegate);
		}
	}
}
