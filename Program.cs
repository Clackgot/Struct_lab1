using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_lab1
{
    class Program
    {

		static int gcd(int a, int b, ref int x, ref int y)
		{
			if (a == 0)
			{
				x = 0; y = 1;
				return b;
			}
			int x1 = 0;
			int y1 = 0;
			int d = gcd(b % a, a, ref x1, ref y1);
			x = y1 - (b / a) * x1;
			y = x1;
			return d;
		}

		static void Main(string[] args)
        {
			int a, b;
			int x = 0;
			int y = 0;

			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			int result = gcd(a, b, ref x, ref y);
			Console.WriteLine("{0} {1} {2}", result, x, y);
			Console.WriteLine("ФИТУ 2-5 Леднев Евгений");

        }
    }
}
