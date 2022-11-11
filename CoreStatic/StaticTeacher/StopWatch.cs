using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic.StaticTeacher
{
	public class StopWatch
	{
        public static int NoOfInstances = 0;

        // A non-static class can contain a parameterless static constructor. Parameterized static constructors are not allowed.
        // The static constructor is called only once whenever the static method is used or creating an instance for the first time.
        // The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
        static StopWatch()
        {
			Console.WriteLine("Static constructor called");
        }
        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }
}
