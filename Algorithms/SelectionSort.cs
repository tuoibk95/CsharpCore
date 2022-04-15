using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class SelectionSort
	{
		public void SelectionSortEx(int[] arr)
		{
			int n = arr.Length;
			for (int i = 0; i < n; i++)
			{
				int temp = arr[i];
				for (int j = i + 1; j < n; j++)
				{
					if (temp > arr[j])
					{
						temp = arr[j];
						arr[j] = arr[i];
					}
				}
				arr[i] = temp;
			}
		}
	}
}
