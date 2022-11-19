using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// [1, 10]
			IEnumerable<int> items1 = Enumerable.Range(1, 10);
			foreach(int item in items1)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("--------Q2分隔線--------");
			// [10, 15]
			IEnumerable<int> items2 = Enumerable.Range(10, 15);
			foreach (int item in items2)
			{
				Console.WriteLine(item);
			}
		}
	}
}
