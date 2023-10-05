using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SMOLab1.Form1;

namespace SMOLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float epsilon;
        float delta;
        public float a;
        public float b;
        public float alpha;
        public float beta;            
        public float xStar;
        public float x;
        public float xPrev;
        static readonly float lambdaGR = (float)(Math.Sqrt(5) - 1) / 2;

        #region Function Description
        /// <summary>
        /// <paramref name="x"/>^3-<paramref name="x"/>
        /// </summary>
        /// <param name="x"></param>
        private float MainFunction(float x) => (x * x * x) - x;

        /// <summary>
        /// 1-ая Производная от <paramref name="x"/>^3-<paramref name="x"/>
        /// </summary>
        /// <param name="x"></param>
        private float MainFuncFirDerivative(float x) => 3 * (x * x) - 1;

        /// <summary>
        /// 2-ая Производная от <paramref name="x"/>^3-<paramref name="x"/>
        /// </summary>
        /// <param name="x"></param>
        private float MainFuncSecDerivative(float x) => 6 * x;

        private int Fibonacci(int n)
        {
            int prev = 0;
            int current = 1;
            int temp;

            Console.WriteLine(prev);
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(current);
                temp = current;
                current = current + prev;
                prev = temp;
            }
            return current; }
        #endregion

        #region Check
        private int CorrectCheck(bool notDelta)
        {
            if (!float.TryParse(epsilonTB.Text, out epsilon))
            {
                MessageBox.Show("Введите Epsilon!");
                return -1;
            }
            if (notDelta == true)
                return 1;
            if (!float.TryParse(deltaTB.Text, out delta))
            {
                MessageBox.Show("Введите Delta!");
                return -1;
            }
            return 1;
        }
        #endregion

        #region Solving Methods
        private Task HalfDivision()
        {
            a = 0;
            b = 1;
            int k = 0;

            while (/*!((b - a) < epsilon)*/k != 10)
            {
                k++;
                outputTB.Text += $"Iteration {k}:" + Environment.NewLine;
                float temp1 = (float)(a + b) / 2;

                alpha = temp1 - delta;
                beta = temp1 + delta;

                outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
                outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;

                float mfAlpha = MainFunction(alpha);
                float mfBeta = MainFunction(beta);

                if (mfAlpha > mfBeta)
                    a = alpha;
                else
                    b = beta;

                outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
                outputTB.Text += Environment.NewLine;
            }

            xStar = (a + b) / 2;
            outputTB.Text += $"~x* = {xStar}" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;
            return Task.CompletedTask;
        }

        private Task GoldenRatio()
        {
            a = 0;
            b = 1;
            int k = 1;

            outputTB.Text += $"Iteration 1:" + Environment.NewLine;

            alpha = a + (1 - lambdaGR) * (b - a);
            beta = a + lambdaGR * (b - a);

            outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
            outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;
            outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;

            if ((b - a) < epsilon)
            {
                xStar = (a + b) / 2;
                outputTB.Text += $"x* = {xStar}" + Environment.NewLine;
                outputTB.Text += Environment.NewLine;
                return Task.CompletedTask;
            }

            while (/*!(b - a) <= epsilon)*/k != 10)
            {
                k++;
                outputTB.Text += $"Iteration {k}:" + Environment.NewLine;

                if (MainFunction(alpha) > MainFunction(beta))
                {
                    a = alpha;
                    b = beta;
                    beta = alpha;
                    alpha = a + (1 - lambdaGR) * (b - a);
                    outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
                    outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;
                }
                else
                {
                    a = alpha;
                    b = beta;
                    alpha = beta;
                    beta = a + lambdaGR * (b - a);
                    outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
                    outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;
                }

                outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
                outputTB.Text += Environment.NewLine;
            }

            xStar = (a + b) / 2;
            outputTB.Text += $"~x* = {xStar}" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;
            return Task.CompletedTask;
        }

        private Task FibonacciMethod()
        {
            a = 0;
            b = 1;
            int n = 0;
            int k = 1;
            int FibNMinOne, FibN;

            do
            {
                n++;
                FibNMinOne = Fibonacci(n - 1);
                FibN = Fibonacci(n);
                float temp = (float)(b - a) / epsilon;
                if (FibNMinOne < temp && temp < FibN)
                    break;
            }
            while (true);

            outputTB.Text += $"{n} {Fibonacci(n)}" + Environment.NewLine;
            alpha = a + ((float)Fibonacci(n-2)/Fibonacci(n))*(b-a);
            beta = a + ((float)Fibonacci(n-1)/Fibonacci(n+1))*(b-a);

            outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
            outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;
            outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;

            while (k != (n - 2))
            {
                k++;
                outputTB.Text += $"Iteration {k}:" + Environment.NewLine;

                outputTB.Text += $"alpha{k} = {alpha}" + Environment.NewLine;
                outputTB.Text += $"beta{k} = {beta}" + Environment.NewLine;

                switch (MainFunction(alpha) >= MainFunction(beta))
                {
                    case true:
                        {
                            a = alpha;
                            alpha = beta;
                            beta = a + ((float)Fibonacci(n - 1 - k) / Fibonacci(n + 1 - k)) * (b - a);
                            break;
                        }
                    case false:
                        {
                            b = beta;
                            beta = alpha;
                            alpha = a + ((float)Fibonacci(n - 2 - k) / Fibonacci(n - k)) * (b - a);
                            break; 
                        }
                }
                outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
                outputTB.Text += Environment.NewLine;
            }

            alpha = a;
            beta = alpha + delta;

            switch (MainFunction(alpha) >= MainFunction(beta))
            {
                case true:
                    {
                        a = alpha;
                        break;
                    }
                case false:
                    {
                        b = beta;
                        break;
                    }
            }

            xStar = (a + b) / 2;
            outputTB.Text += $"~x* = {xStar}" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;
            return Task.CompletedTask;
        }

        private Task NewtonMethod()
        {
            a = 0;
            b = 1;
            x = xPrev = 0.5f;
            int k = 1;

            outputTB.Text += $"x0 = {xPrev}" + Environment.NewLine;
            outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;

            x = xPrev + (float)MainFuncFirDerivative(xPrev) / MainFuncSecDerivative(xPrev);

            outputTB.Text += $"x{k} = {x}" + Environment.NewLine;

            outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;

            while (Math.Abs(x - xPrev) < epsilon)
            {
                k++;
                outputTB.Text += $"Iteration {k}:" + Environment.NewLine;

                x  = xPrev + (float)MainFuncFirDerivative(xPrev)/MainFuncSecDerivative(xPrev);

                outputTB.Text += $"x{k} = {x}" + Environment.NewLine;

                outputTB.Text += $"[{a};{b}]" + Environment.NewLine;
                outputTB.Text += Environment.NewLine;
            }

            xStar = x;
            outputTB.Text += $"~x* = {xStar}" + Environment.NewLine;
            outputTB.Text += Environment.NewLine;
            return Task.CompletedTask;
        }
        #endregion

        #region Buttons
        private async void halfDivisionButton_Click(object sender, EventArgs e)
        {
            outputTB.Text = "Метод половинного деления" + Environment.NewLine;
            if (CorrectCheck(false) == -1) return;
            await HalfDivision();
        }

        private async void goldenRatioButton_Click(object sender, EventArgs e)
        {
            outputTB.Text = "Метод золотого сечения" + Environment.NewLine;
            if (CorrectCheck(true) == -1) return;
            await GoldenRatio();
        }

        private async void FibonacciButton_Click(object sender, EventArgs e)
        {
            outputTB.Text = "Метод Фибоначчи" + Environment.NewLine;
            if (CorrectCheck(false) == -1) return;
            await FibonacciMethod();
            
        }

        private async void NewtonButton_Click(object sender, EventArgs e)
        {
            outputTB.Text = "Метод Ньютона" + Environment.NewLine;
            if (CorrectCheck(true) == -1) return;
            await NewtonMethod();
        }
        #endregion
    }
}
