﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.TestNumber;
using Test.Data;
using Test.JSON;

namespace Test
{
	public class Program
	{
		public static void Main(string[] args)
		{
			GrandFather person = new Son();
            Console.WriteLine(person.Name());
        }

		public abstract class GrandFather
		{
			public virtual string Name()
			{
				return "Grand Father";
			}
		}

		public class Father : GrandFather {
			public override string Name() { return "Father"; }
		}

        public class  Son : Father
        {
            public new string Name() { return "Son"; }
        }

        public static void Test()
		{
			TestNumber1 testNumber = new TestNumber1();
			testNumber.TestNumberQuestion1();

			Compare compare = new Compare();
			compare.CompareEqualAndBB();

			int? a = null;
			a = a != null ? a : 0;
			// Viết gọn với ??
			a = a ?? 0;
			Console.WriteLine(a);
			Console.WriteLine("+++++++++++++++++");
			ObjectToJSON.TestObjectToJSON();
			ObjectToJSON.TestObjectToJSONOption();

			JSONToObject.ConvertJsonToObject();
			JSONToObject.ConvertArrayJsonToObject();

			ObjectToJSON.TestObject();
			ObjectToJSON.TestObject2();
		}
	}
}
