using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore.Colection
{
	/// <summary>
	/// Dictionary<TKey, TValue> : IDictionary<TKey, TValue> generic được lưu không theo thứ tự
	/// Keys must be unique and cannot be null.
	/// Values can be null or duplicate.
	/// Elements are stored as KeyValuePair<TKey, TValue> objects.
	/// </summary>
	internal class DictionaryEx
	{
		public static void TestDictionary()
		{
			#region
			IDictionary<int, string> numberNames = new Dictionary<int, string>();
			numberNames.Add(1, "One"); //adding a key/value using the Add() method
			numberNames.Add(2, "Two");
			numberNames.Add(3, "Three");

			//The following throws run-time exception: key already added.
			//numberNames.Add(3, "Three"); 

			foreach (KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			//creating a dictionary using collection-initializer syntax
			var cities = new Dictionary<string, string>(){
				{"UK", "London, Manchester, Birmingham"},
				{"USA", "Chicago, New York, Washington"},
				{"India", "Mumbai, New Delhi, Pune"}
			};

			foreach (var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
			#endregion
		}
	}
}
