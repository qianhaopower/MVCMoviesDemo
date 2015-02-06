namespace WindowsFormsApplication2
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DisplayToken = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtShapeResultMine = new System.Windows.Forms.TextBox();
            this.txtShapeResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.btnShape = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFibo = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numFibo = new System.Windows.Forms.NumericUpDown();
            this.btnFibb = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textRevesedMine = new System.Windows.Forms.TextBox();
            this.txtReversed = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnReverseText = new System.Windows.Forms.Button();
            this.btnDisplayMyToken = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lbltime2 = new System.Windows.Forms.Label();
            this.btnReversefile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFibo)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DisplayToken
            // 
            this.btn_DisplayToken.Location = new System.Drawing.Point(4, 12);
            this.btn_DisplayToken.Name = "btn_DisplayToken";
            this.btn_DisplayToken.Size = new System.Drawing.Size(75, 23);
            this.btn_DisplayToken.TabIndex = 0;
            this.btn_DisplayToken.Text = "Display Token";
            this.btn_DisplayToken.UseVisualStyleBackColor = true;
            this.btn_DisplayToken.Click += new System.EventHandler(this.btn_DisplayToken_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(0, 41);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(913, 662);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.txtShapeResultMine);
            this.tabPage4.Controls.Add(this.txtShapeResult);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.numB);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.num3);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.numA);
            this.tabPage4.Controls.Add(this.btnShape);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(905, 636);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Shape";
            // 
            // txtShapeResultMine
            // 
            this.txtShapeResultMine.Location = new System.Drawing.Point(202, 89);
            this.txtShapeResultMine.Multiline = true;
            this.txtShapeResultMine.Name = "txtShapeResultMine";
            this.txtShapeResultMine.ReadOnly = true;
            this.txtShapeResultMine.Size = new System.Drawing.Size(212, 43);
            this.txtShapeResultMine.TabIndex = 17;
            // 
            // txtShapeResult
            // 
            this.txtShapeResult.Location = new System.Drawing.Point(202, 40);
            this.txtShapeResult.Multiline = true;
            this.txtShapeResult.Name = "txtShapeResult";
            this.txtShapeResult.ReadOnly = true;
            this.txtShapeResult.Size = new System.Drawing.Size(212, 43);
            this.txtShapeResult.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "b :";
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(61, 37);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 20);
            this.numB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "c :";
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(61, 63);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(120, 20);
            this.num3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "a :";
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(61, 11);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(120, 20);
            this.numA.TabIndex = 10;
            // 
            // btnShape
            // 
            this.btnShape.Location = new System.Drawing.Point(202, 11);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(115, 23);
            this.btnShape.TabIndex = 9;
            this.btnShape.Text = "What Shape is this ?";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnGetShape_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.textBox2);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.txtFibo);
            this.tabPage5.Controls.Add(this.numericUpDown1);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.numFibo);
            this.tabPage5.Controls.Add(this.btnFibb);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(905, 636);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Fibo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 86);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(212, 43);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(212, 43);
            this.textBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fibo of :";
            // 
            // txtFibo
            // 
            this.txtFibo.Location = new System.Drawing.Point(202, 37);
            this.txtFibo.Multiline = true;
            this.txtFibo.Name = "txtFibo";
            this.txtFibo.ReadOnly = true;
            this.txtFibo.Size = new System.Drawing.Size(212, 43);
            this.txtFibo.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(61, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fibo of :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get Fibbo Number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFibb_Click);
            // 
            // numFibo
            // 
            this.numFibo.Location = new System.Drawing.Point(61, 11);
            this.numFibo.Name = "numFibo";
            this.numFibo.Size = new System.Drawing.Size(120, 20);
            this.numFibo.TabIndex = 16;
            // 
            // btnFibb
            // 
            this.btnFibb.Location = new System.Drawing.Point(202, 8);
            this.btnFibb.Name = "btnFibb";
            this.btnFibb.Size = new System.Drawing.Size(115, 23);
            this.btnFibb.TabIndex = 14;
            this.btnFibb.Text = "Get Fibbo Number";
            this.btnFibb.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.btnReversefile);
            this.tabPage6.Controls.Add(this.lbltime2);
            this.tabPage6.Controls.Add(this.lblTime1);
            this.tabPage6.Controls.Add(this.textRevesedMine);
            this.tabPage6.Controls.Add(this.txtReversed);
            this.tabPage6.Controls.Add(this.txtOriginal);
            this.tabPage6.Controls.Add(this.btnReverseText);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(905, 636);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Reverse";
            // 
            // textRevesedMine
            // 
            this.textRevesedMine.Location = new System.Drawing.Point(449, 303);
            this.textRevesedMine.Multiline = true;
            this.textRevesedMine.Name = "textRevesedMine";
            this.textRevesedMine.ReadOnly = true;
            this.textRevesedMine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textRevesedMine.Size = new System.Drawing.Size(448, 249);
            this.textRevesedMine.TabIndex = 19;
            // 
            // txtReversed
            // 
            this.txtReversed.Location = new System.Drawing.Point(451, 35);
            this.txtReversed.Multiline = true;
            this.txtReversed.Name = "txtReversed";
            this.txtReversed.ReadOnly = true;
            this.txtReversed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReversed.Size = new System.Drawing.Size(448, 249);
            this.txtReversed.TabIndex = 18;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(6, 35);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(439, 595);
            this.txtOriginal.TabIndex = 17;
            // 
            // btnReverseText
            // 
            this.btnReverseText.Location = new System.Drawing.Point(6, 6);
            this.btnReverseText.Name = "btnReverseText";
            this.btnReverseText.Size = new System.Drawing.Size(137, 23);
            this.btnReverseText.TabIndex = 16;
            this.btnReverseText.Text = "Reverse Text";
            this.btnReverseText.UseVisualStyleBackColor = true;
            this.btnReverseText.Click += new System.EventHandler(this.btnReverseText_Click);
            // 
            // btnDisplayMyToken
            // 
            this.btnDisplayMyToken.Location = new System.Drawing.Point(85, 12);
            this.btnDisplayMyToken.Name = "btnDisplayMyToken";
            this.btnDisplayMyToken.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayMyToken.TabIndex = 17;
            this.btnDisplayMyToken.Text = "Display My Token";
            this.btnDisplayMyToken.UseVisualStyleBackColor = true;
            this.btnDisplayMyToken.Click += new System.EventHandler(this.btnDisplayMyToken_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(191, 17);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 20;
            this.lblResult.Text = "Result";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(457, 16);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(30, 13);
            this.lblTime1.TabIndex = 20;
            this.lblTime1.Text = "Time";
            // 
            // lbltime2
            // 
            this.lbltime2.AutoSize = true;
            this.lbltime2.Location = new System.Drawing.Point(457, 287);
            this.lbltime2.Name = "lbltime2";
            this.lbltime2.Size = new System.Drawing.Size(34, 13);
            this.lbltime2.TabIndex = 21;
            this.lbltime2.Text = "TIme:";
            // 
            // btnReversefile
            // 
            this.btnReversefile.Location = new System.Drawing.Point(149, 6);
            this.btnReversefile.Name = "btnReversefile";
            this.btnReversefile.Size = new System.Drawing.Size(88, 23);
            this.btnReversefile.TabIndex = 22;
            this.btnReversefile.Text = "Reverse File";
            this.btnReversefile.UseVisualStyleBackColor = true;
            this.btnReversefile.Click += new System.EventHandler(this.btnReversefile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 703);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDisplayMyToken);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btn_DisplayToken);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFibo)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DisplayToken;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtShapeResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFibo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numFibo;
        private System.Windows.Forms.Button btnFibb;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtReversed;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnReverseText;
        private System.Windows.Forms.Button btnDisplayMyToken;
        private System.Windows.Forms.TextBox textRevesedMine;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtShapeResultMine;
        private System.Windows.Forms.Label lbltime2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Button btnReversefile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

