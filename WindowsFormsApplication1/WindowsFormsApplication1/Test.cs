using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Redify;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Azure.Service1Client client = new Azure.Service1Client();

            Redify.RedPillClient reClient = new RedPillClient();

            var value = client.GetDataAsync(3);

           
           
            MessageBox.Show( value.Result);

          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                long limit = 9223372036854775807;
                    //92 is the maximum;
                var watch = Stopwatch.StartNew();
                long value = Convert.ToInt64(textBox1.Text);
                var reuslt = FasterFibonacci(value);
                bool tooLong = reuslt > 9223372036854775807;
                watch.Stop();
                var elapsed = watch.ElapsedMilliseconds / 1000;

                string message = string.Empty;
                if(tooLong)
                { 
                      message = string.Format("Too Long Result is {0}. Time is {1} second.", reuslt, elapsed.ToString());

                }
                else
                 message = string.Format("Result is {0}. Time is {1} second.", reuslt, elapsed.ToString());

                textBox2.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private  long CalculateFibonacci(long n)
        //{
        //    if (n == 0) return 0;
        //    if (n == 1) return 1;
        //    return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        //}
        private long FasterFibonacci(long n)
        {
            if (n <= 2)
                return 1;
            long k = n / 2;
            long a = FasterFibonacci(k + 1);
            long b = FasterFibonacci(k);

            if (n % 2 == 1)
                return a * a + b * b;
            else
                return b * (2 * a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Redify.RedPillClient reClient = new RedPillClient("BasicHttpsBinding_IRedPill");

            try
            {

                long limit = 9223372036854775807;
                //92 is the maximum;
                var watch = Stopwatch.StartNew();
                long value = Convert.ToInt64(textBox1.Text);
                var reuslt = reClient.FibonacciNumber(value);
                bool tooLong = reuslt > 9223372036854775807;
                watch.Stop();
                var elapsed = watch.ElapsedMilliseconds / 1000;

                string message = string.Empty;
                if (tooLong)
                {
                    message = string.Format("Too Long Result is {0}. Time is {1} second.", reuslt, elapsed.ToString());

                }
                else
                    message = string.Format("Result is {0}. Time is {1} second.", reuslt, elapsed.ToString());

                textBox2.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Redify.RedPillClient reClient = new RedPillClient("BasicHttpsBinding_IRedPill");

            try
            {

                long limit = 9223372036854775807;
                int[] values = textBox3.Text.Split(',').ToList().Select(p => Convert.ToInt32(p)).ToArray();


                //92 is the maximum;
                var watch = Stopwatch.StartNew();
              
                var reuslt = reClient.WhatShapeIsThis(values[0],values[1], values[2] );
               
                watch.Stop();
                var elapsed = watch.ElapsedMilliseconds / 1000;

                
                string    message = string.Format("Result is {0}. Time is {1} second.", reuslt.ToString(), elapsed.ToString());

                textBox4.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Redify.RedPillClient reClient = new RedPillClient("BasicHttpsBinding_IRedPill");

            try
            {

                long limit = 9223372036854775807;
                


                //92 is the maximum;
                var watch = Stopwatch.StartNew();

                var reuslt = reClient.ReverseWords(textBox6.Text);

                watch.Stop();
                var elapsed = watch.ElapsedMilliseconds / 1000;


            

                textBox5.Text = reuslt;
                this.label1.Text = string.Format("Time is {0} second.", elapsed.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            try
            {

                long limit = 9223372036854775807;



                //92 is the maximum;
                var watch = Stopwatch.StartNew();

                var textOriginal = textBox6.Text;
                string[] lines = Regex.Split(textOriginal, "\r\n|\r|\n");

                StringBuilder builder = new StringBuilder();
                foreach (var line in lines)
                {
                    var reversedWords = string.Join(" ",
        line.Split(' ')
           .Select(x => new String(x.Reverse().ToArray())));
                    builder.Append(string.Concat(reversedWords));
                    builder.Append("\r\n");
                }

                var bigResult = builder.ToString();

                watch.Stop();
                var elapsed = watch.ElapsedMilliseconds / 1000;


               

                textBox5.Text = bigResult;
                this.label1.Text = string.Format("Time is {0} second.",elapsed.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

//        #Fast Fibonnaci
//def fib(n):
//    if n <= 2:
//        return 1
//    k = n/2
//    a = fib(k + 1)
//    b = fib(k)
//    if n % 2 == 1:
//        return a*a + b*b
//    else:
//        return b*(2*a - b)
 
//if __name__ == "__main__":
//    n = int(raw_input("Enter n(0 to quit) : "))
//    while n:
//        print fib(n)
//        n = int(raw_input("Enter n(0 to quit) : "))

    }
}
