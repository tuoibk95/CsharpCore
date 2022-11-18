using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreStatic.StaticTeacher
{
    /// <summary>
    /// Static members are stored in a special area in the memory called High-Frequency Heap.
    /// Static members of non-static classes are shared across all the instances of the class.
    /// So, the changes done by one instance will be reflected in all the other instances.
    /// </summary>
	public class StopWatch
	{
        public string name = "LVT";
        public static int NoOfInstances = 0;
        /// <summary>
        /// A non-static class can contain a parameterless static constructor. Parameterized static constructors are not allowed.
        /// Called only once whenever (chỉ được gọi 1 lần) the static method is used or creating an instance for the first time.
        /// Static constructor will be executed only once in the lifetime.
        /// A static constructor can only access static members. It cannot contain or access instance members.
        /// The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
        /// </summary>
        static StopWatch()
        {
            // NoOfInstances++;
			Console.WriteLine("Static constructor called");
        }
        // instance constructor
        public StopWatch()
        {
            NoOfInstances++;
            Console.WriteLine("Instance constructor called");
        }

        /// <summary>
        /// Static methods can be overloaded but cannot be overridden.
        /// ??? Static methods can contain local static variables. biến static k thể được tạo trong phương thức static and non static method
        /// Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.
        /// </summary>
        public static void DisplayInfo()
        {
            // K thể access biến name vì name not static members
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }
}
