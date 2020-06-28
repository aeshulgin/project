using System;
using System.Drawing;
using System.Threading;

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

            Thread.Sleep(5000);

            s.Hide();
            s.Move(Direction.LEFT);
            s.Draw();

            //Stick st = new Stick(6, 1, '*');
            //st.Draw();

            //Point p1 = new Point(2, 3, '*');
            //p1.Draw();


            Console.ReadLine();
        }

    }
}
