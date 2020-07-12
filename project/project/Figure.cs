﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace project
{
    abstract class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Move(Direction dir)
        {
            Hide();
            foreach(Point p in points)
            {
                p.Move(dir);
            }
            Draw();
        }

        public abstract void Rotate();
        
        public void Hide()
        {
            foreach(Point p in points)
            {
                p.Hide();
            }
        }
    }
}
