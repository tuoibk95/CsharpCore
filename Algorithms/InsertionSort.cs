using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class InsertionSort
	{
		public void InsertionSortEx(int[] arr)
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
							break;
						}
						count++;
					}
					else if (count >= 1 && temp >= arr[j])
					{
						arr[j + 1] = temp;
						break;
					}
				}
			}
		}

		void sort(int[] arr)
		{
			int n = arr.Length;
			for (int i = 1; i < n; ++i)
			{
				int key = arr[i];
				int j = i - 1;

				while (j >= 0 && arr[j] > key)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j + 1] = key;
			}
		}
	}
}
