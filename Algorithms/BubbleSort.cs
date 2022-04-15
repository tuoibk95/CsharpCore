using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	internal class BubbleSort
	{
		public static void BubbleSortEx(int[] arr)
		{
			int n = arr.Length;
			int temp;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}

		public static void InsertionSort(int[] arr)
		{
			int n = arr.Length;
			int temp = 0;
			for (int i = 1; i < n; i++)
			{
				temp = arr[i];
				int count = 0;
				for (int j = i - 1; j >= 0; j--)
				{
					if (temp < arr[j])
					{
						arr[j + 1] = arr[j];
						if (j == 0)
						{
							arr[j] = temp;
							continue;
						}
						count++;
					}
					else if (count >= 1 && temp > arr[j])
					{
						arr[j + 1] = temp;
						break;
					}
				}
			}
		}
	}
}
