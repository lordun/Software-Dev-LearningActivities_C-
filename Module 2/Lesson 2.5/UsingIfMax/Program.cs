using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIfMax
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = 5;
			int y = 17;
			int z = 12;
			int max;
			if (x > y)
			{
				max = x;
			}
			else if(y > z)
			{
				max = y;
			}
			else
			{
				max = z;
			}
			Console.WriteLine(max);
			Console.Read();
		}
    }
}
