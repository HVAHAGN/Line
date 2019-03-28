using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Line drow = new Line();
            drow.Square();
            drow.Tirangle();
            drow.Arrow();
            drow.Rectangle();

            Console.ReadLine();
        }
    }

    class Line
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// n is the indicate how many * must have a square
        public void Square(int n=10)
        {
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Triangle size"></param>
        /// size the index of how many line must have a triangle
        public void Tirangle(int size=5)
        {
            {
                //   * 
                //  ***
                // *****
                //*******
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size - (i + 1); j++)
                        Console.Write(" ");
                    for (int j = 0; j < 2 * i + 1; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// arrow drow a line in the end of line >
        /// </summary>
        /// <param name="a"></param>
        public void Arrow(int a=30)
        {
            for (int i = 0; i < a; i++)
            {
                
               Console.Write("-");
             
            }
            Console.WriteLine(">");
        }

        
         public void Rectangle(int h=4, int w=20)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }
}
