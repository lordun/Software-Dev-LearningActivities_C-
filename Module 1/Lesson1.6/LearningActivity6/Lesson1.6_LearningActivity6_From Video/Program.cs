using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._6_LearningActivity6_From_Video
{
    class Program
    {
        static float DistanceBetweenPoints(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int dz = z2 - z1;

            double distance = Math.Sqrt(dx * dx + dy * dy + dz * dz);
            return (float)distance;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Point:01 ");
            Console.WriteLine("Enter x co-ordinate value: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y co-ordinate value: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter z co-ordinate value: ");
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Point:02 ");
            Console.WriteLine("Enter x co-ordinate value: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y co-ordinate value: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter z co-ordinate value: ");
            int z2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Distance between point({0},{1},{2} from the origin(0,0,0) is:{3}",x1,y1,z1,DistanceBetweenPoints(x1,y1,z1,0, 0, 0));

            Console.WriteLine("Distance between point({0},{1},{2} from the origin(0,0,0) is:{3}", x2, y2, z2, DistanceBetweenPoints(x2, y2, z2, 0, 0, 0));

            Console.WriteLine("Distance between point({0},{1},{2} from the point({3},{4},{5}) is:{6}", x1, y1, z1, x2, y2, z2, DistanceBetweenPoints(x1, y1, z1, x2, y2, z2));

            Console.Read();
        }
    }
}
