using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab5
{
    class Vector2D 
    {
        private int x;
        private int y;
        public Vector2D() 
        {
            x = 0; y = 0;
        }
        public Vector2D(int X, int Y) 
        {
            this.x = X; this.y = Y;
        }
        public Vector2D(Vector2D a) 
        {
            this.x = a.x; this.y = a.y;
        }
        public void setX(int a) { x = a; }
        public void setY(int a) { y = a; }
        public int getX() { return x; }
        public int getY() { return y; }
        public static Vector2D operator + (Vector2D a, Vector2D b) 
        {
            return new Vector2D(a.x + b.x, a.y + b.y);
        }
        public static Vector2D operator - (Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x - b.x, a.y - b.y);
        }
        public static Vector2D operator * (Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x * b.x, a.y * b.y);
        }
        public static Vector2D operator / (Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x / b.x, a.y / b.y);
        }
        public static Vector2D operator > (Vector2D a, Vector2D b)
        {
            return new Vector2D(a.x - b.x, a.y - b.y);
        }
        public static Vector2D operator < (Vector2D a, Vector2D b)
        {
            return new Vector2D(b.x - a.x, b.y - a.y);
        }

        public static Vector2D operator == (Vector2D a, Vector2D b)
        {
            if (a.x == b.x && a.y == b.y) return new Vector2D(1, 1);
            else { return new Vector2D(0, 0); }
        }
        public static Vector2D operator != (Vector2D a, Vector2D b)
        {
            if (a.x == b.x && a.y == b.y) return new Vector2D(0, 0);
            else { return new Vector2D(1, 1); }
        }
        public static Vector2D operator ++ (Vector2D a)
        {
            return new Vector2D(a.x++ , a.y++);
        }
        public static Vector2D operator -- (Vector2D a)
        {
            return new Vector2D(a.x--, a.y--);
        }
        public string ToString()
        {
            return "x = " + this.x + "\ty = " + this.y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D a = new Vector2D();
            Vector2D b = new Vector2D(4, 7);
            Vector2D c = new Vector2D(5, 2);
            Vector2D d = new Vector2D(b);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine((b - c).ToString());
            Console.WriteLine((c + b).ToString());
            Console.WriteLine((c * b).ToString());
            Console.WriteLine((c < b).ToString());
            Console.WriteLine((c > b).ToString());
            Console.WriteLine((c == b).ToString());
            Console.WriteLine((d == b).ToString());


            Console.ReadKey();
        }
    }
}
