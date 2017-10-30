using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addOne = n => n + 1;

            Func<int, int, int> addNums = (x, y) => x + y;
            Func<int, bool> isZero = n => n == 0;
            Console.WriteLine(addOne(5)); // 6
            Console.WriteLine(isZero(addNums(-5, 5))); // True
            int[] a = { 0, 1, 2, 0, 4, 0, 1 };
            Console.WriteLine(a.Count(isZero)); // 3

        }
    }

    public class Rectangle
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public void Grow(int length, int height)
        {
            Length += length;
            Height += height;
        }
    }

    public class ImmutableRectangle
    {
        int Length { get; }
        int Height { get; }
        public ImmutableRectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }
        public ImmutableRectangle Grow(int length, int height) =>    new ImmutableRectangle(Length + length, Height + height);
    }


}
