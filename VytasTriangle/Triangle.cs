using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VytasTriangle
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double h;
        public bool ifh = false;
        public int type = 0;
        public Triangle() { } // конструктор

        public Triangle(double A, double H) // пустой конструктор
        {
            a = A;
            h = H;
            ifh = true;
        }

        public Triangle(double A, double B, double C) // конструктор
        {
            a = A; // значения
            b = B;
            c = C;
            if (a == b || b == c || c == a)
                type = 1; // равнобедренным
        }
        // выводы значений
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        // периметр
        public double Permimeter()
        {
            return a + b + c;
        }
        // площадь
        public double Surface()
        {
            double s, p = 0;
            if (ifh)
            {
                s = a / 2 * h;
            }
            else
            {
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }
        // получить или изменить значение
        public double GetSetA
        {
            get { return a; }
            set { a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }
        public double GetSetH
        {
            get { return h; }
            set { h = value; }
        }
        // проверка подлинности объекта
        public bool ExistTriangle
        {
            get
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                    return false;
                else
                    return true;
            }
        }
        // высота 
        public double hA()
        {
            return Surface() / 2 / a;
        }
        public double hB()
        {
            return Surface() / 2 / b;
        }
        public double hC()
        {
            return Surface() / 2 / c;
        }
    }
}
