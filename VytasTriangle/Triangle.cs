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

        public Triangle(double A, double H) // пустой конструктор
        {
            a = A;
            h = H;
        }

        public Triangle(double A, double B, double C) // конструктор
        {
            a = A; // значения
            b = B;
            c = C;
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
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
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
    }
}
