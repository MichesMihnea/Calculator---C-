using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcModel
    {

        private int x;
        private int y;
        private char operation;
        public String X;
        public String Y;
        
        public char Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public void parseX()
        {
            x = int.Parse(X);
        }

        public void parseY()
        {
            y = int.Parse(Y);
        }

        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int divide(int x, int y)
        {
            return x / y;
        }

        public int performOperation()
        {
            int result = 0;

            switch(operation)
            {
                case '+':
                    result = add(x, y);
                    break;

                case '-':
                    result = subtract(x, y);
                    break;

                case '*':
                    result = multiply(x, y);
                    break;

                case '/':
                    result = divide(x, y);
                    break;

            }

            return result;

        }

        public void reset()
        {
            x = 0;
            y = 0;
            X = "";
            Y = "";
            operation = '0';
        }

    }
}
