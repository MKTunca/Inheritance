using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.Result();
            Square square = new Square();
            square.Result();
            Circle circle = new Circle();
            circle.Result();
            Console.ReadLine();
        }
        class Environment
        {
            public virtual void Result()
            {
                Console.WriteLine("Şeklin kenarlarını topla");
            }
        }
        class Triangle:Environment
        {

        }
        class Square : Environment
        {

        }
        class Circle:Environment
        {
            public override void Result()
            {
                Console.WriteLine("Yarıçapını 2 pi le çarp");
            }
        }
    }
}
