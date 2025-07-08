using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class Calculator
    {
        public decimal Add(int a, int b)
        {
            return a + b;
        }
        public decimal Mul(int a, int b)
        {
            return a * b;
        }
        public decimal Sub(int a, int b)
        {
            return a - b;
        }
        public decimal Div(int a, int b)
        {
            return a / b;
        }
    }
}
