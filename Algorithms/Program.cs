using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class Program
	{
		public static void PrintArr(int[] arr)
		{
			int m = arr.Length;
			for (int i = 0; i < m; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.ReadLine();
		}
		public static void Main(string[] args)
		{
			int[] arrex = new int[] { 64, 34, 25, 12, 22, 11, 90 };
			//int[] arrex = new int[] { 7, 8, 5, 2, 4, 6, 3 };
			//			BubbleSortEx(arrex);
			SelectionSort insertionSort = new SelectionSort();
			insertionSort.SelectionSortEx(arrex);
			PrintArr(arrex);
			Console.WriteLine("anh \n em");
		}

	}
}
