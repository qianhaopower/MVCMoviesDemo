using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private RedifyService.RedPillClient _client;
        private RedifyService.RedPillClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new RedifyService.RedPillClient("BasicHttpsBinding_IRedPill");
                   
                }
                return _client;
            }
        }

        private MyRedPill.RedPillClient _myClient;
        private MyRedPill.RedPillClient MyClient
        {
            get
            {
                if (_myClient == null)
                {
                    _myClient = new MyRedPill.RedPillClient();
                   
                }
                return _myClient;
            }
        }


        private void NotUser()
        {
            _myClient.FibonacciNumber(5);
            _client.FibonacciNumber(5);

        }

        #region WhatIsYourToken
        private void btn_DisplayToken_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Client.WhatIsYourToken().ToString());
        }
        private void btnDisplayMyToken_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.MyClient.WhatIsYourToken().ToString());
        }
        #endregion 

        private void btnGetShape_Click(object sender, EventArgs e)
        {
              int a = (int)numA.Value;
              int b = (int)numB.Value;
              int c = (int)num3.Value;

            //Random rnd = new Random();

            //   a = rnd.Next(1, 10);
            //   b = rnd.Next(1,10);
            //   c = rnd.Next(1,10);
              var result = Client.WhatShapeIsThis(a, b, c);
              var myResult = MyClient.WhatShapeIsThis(a, b, c);
            
              this.txtShapeResult.Text = result.ToString();
              this.txtShapeResultMine.Text = myResult.ToString();

              if (result.ToString().Equals( myResult.ToString()))
              {
                  this.lblResult.BackColor = Color.Green;
              }
              else
              {
                  this.lblResult.BackColor = Color.Red;
              }
        }


        #region FibonacciNumber
        private void btnFibb_Click(object sender, EventArgs e)
        {
            long n = (long)this.numericUpDown1.Value;
            try
            {
                var result = Client.FibonacciNumber(n);
                var myResult = MyClient.FibonacciNumber(n);
                this.textBox1.Text = result.ToString();
                this.textBox2.Text = myResult.ToString();

                if (result == myResult)
                {
                    this.lblResult.BackColor = Color.Green;
                }
                else
                {
                    this.lblResult.BackColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                this.textBox1.Text = ex.Message;
            }
        }

        #endregion

      

        #region ReverseWords



        private void btnReverseText_Click(object sender, EventArgs e)
        {
            try
            {
                string original = this.txtOriginal.Text;
                Reverse(original);
            }
            catch (Exception ex)
            {
                this.txtReversed.Text = ex.Message;
            }
        }

        #endregion

        private void btnReversefile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string readText = File.ReadAllText(openFileDialog1.FileName);
                    Reverse(readText);
                }
               
               
            }
            catch (Exception ex)
            {
                this.txtReversed.Text = ex.Message;
            }
        }

       void Reverse(string original)
       {
        
            var watch = Stopwatch.StartNew();

            var result = Client.ReverseWords(original);
            watch.Stop();
            var elapsed = watch.ElapsedMilliseconds / 1000;
            this.lblTime1.Text = elapsed.ToString();


            var watch2 = Stopwatch.StartNew();
            var myResult = MyClient.ReverseWords(original);
            var elapsed2 = watch2.ElapsedMilliseconds / 1000;
            this.lbltime2.Text = elapsed2.ToString();

            this.txtReversed.Text = result.ToString();
            this.textRevesedMine.Text = myResult.ToString();

            if (result == myResult)
            {
                this.lblResult.BackColor = Color.Green;
            }
            else
            {
                this.lblResult.BackColor = Color.Red;
            }
        }

    



    }
}
