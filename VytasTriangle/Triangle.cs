﻿using System;
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

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputB()
        {
            return Convert.ToString(c);
        }
        public double Permimeter()
        {
            return a + b + c;
        }
        public double Surface()
        {
            double p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
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
