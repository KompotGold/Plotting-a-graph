using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace ParserFunctions
{
    class Parser
    {
        private List<string> strList;
        private double a_x;
        private double b_x;
        private int N;
        
        private double[] X;

        private double h;

        private Argument x;
        private Expression e;

        private static Expression check;

        public Parser(List<string> str,double a, double b, int N)
        {
            this.a_x = a;
            this.b_x = b;
            this.N = N;
            this.strList = str;

            this.h = (b - a) / (N - 1);
        }

        public void setA(double a)
        {
            this.a_x = a;
        }

        public void setN(int n)
        {
            N = n;
        }

        public void setB(double b)
        {
            this.b_x = b;
        }


        public double[] getArrayX()
        {
            X = new double[N];

            double xi = a_x;
            for(int i = 0; i < N; i++ , xi = Math.Round(xi + h,3))
                X[i] = xi;

            return X;
        }

        public double[,] getArraysY()
        {
            int strCount = strList.Count();

            double[,] local = new double[strCount, N];

            for(int i = 0; i < strCount; i++)
            {             
                for (int j = 0; j < N; j++)
                {                 
                    x = new Argument("x",X[j]);
                    e = new Expression(strList[i], x);

                    local[i, j] = e.calculate();
                }
            }

            return local;
        }

        public void Add(string str)
        {
            strList.Add(str);
        }

        public static bool checkSyntax(string str)
        {
            str = str.Replace('x', '0');
            str = str.Replace("e0p", "exp");
            Expression check = new Expression(str);
            return check.checkSyntax();         
        }
    }
}
