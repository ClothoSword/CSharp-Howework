using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1.0f, 2.0f, 3.0f);
            Vector v2 = new Vector(3.0f, 4.0f, 5.0f);
            Vector v3 = new Vector(1.0f, 2.0f, 3.0f);
            Console.WriteLine($"v1==v3:{v1 == v3}");
            v1 += v2;
            Console.WriteLine(v1);
            Console.WriteLine($"v1 dot v2:{Vector.Dot(v1, v2)}");
            Console.WriteLine($"v1 cross v2:{Vector.Cross(v1, v2)}");
            v3 *= 4.0f;
            Console.WriteLine(v3);
            Console.WriteLine($"v3.magnitude:{v3.Magnitude()} v3.normalize:{v3.normalized()}");

            while (true)
            {

            }
        }
    }
}
