using System;
using System.Drawing;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(2, 5, '*');
            s.Draw();

            Stick st = new Stick(6, 1, '*');
            st.Draw();

            Point p1 = new Point(2, 3, '*');
            p1.Draw();

       
            Console.ReadLine();
        }

    }
}
