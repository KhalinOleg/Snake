﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point()
        {

        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            
        }

        public void draw() // Функция рисования
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
