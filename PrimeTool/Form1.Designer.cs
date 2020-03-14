namespace PrimeTool
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxPrimeToCheck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCheckPrime = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIsPrime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrimeToForce = new System.Windows.Forms.TextBox();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFactor1 = new System.Windows.Forms.TextBox();
            this.textBoxFactor2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFactorCeiling = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 253);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxIsPrime);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonCheckPrime);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxPrimeToCheck);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prime Checker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MicroSquare", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to PrimeTool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bust Those Primes!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MicroSquare", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 100);
            this.label3.TabIndex = 2;
            this.label3.Text = "PrimeTool is an application that allows you to:\r\nCheck if an integer is prime,\r\na" +
    "nd Brute-Force the product of two primes\r\n\r\n(more coming soon)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxFactorCeiling);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxFactor2);
            this.tabPage3.Controls.Add(this.textBoxFactor1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.buttonBruteForce);
            this.tabPage3.Controls.Add(this.textBoxPrimeToForce);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(604, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Brute-Force Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxPrimeToCheck
            // 
            this.textBoxPrimeToCheck.Location = new System.Drawing.Point(6, 19);
            this.textBoxPrimeToCheck.Name = "textBoxPrimeToCheck";
            this.textBoxPrimeToCheck.Size = new System.Drawing.Size(591, 20);
            this.textBoxPrimeToCheck.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Integer To Check";
            // 
            // buttonCheckPrime
            // 
            this.buttonCheckPrime.Font = new System.Drawing.Font("Pristina", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckPrime.Location = new System.Drawing.Point(9, 46);
            this.buttonCheckPrime.Name = "buttonCheckPrime";
            this.buttonCheckPrime.Size = new System.Drawing.Size(588, 50);
            this.buttonCheckPrime.TabIndex = 2;
            this.buttonCheckPrime.Text = "Bust That Prime!!!";
            this.buttonCheckPrime.UseVisualStyleBackColor = true;
            this.buttonCheckPrime.Click += new System.EventHandler(this.ButtonCheckPrime_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MicroSquare", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Your Number is:";
            // 
            // textBoxIsPrime
            // 
            this.textBoxIsPrime.Font = new System.Drawing.Font("MicroSquare", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsPrime.Location = new System.Drawing.Point(185, 102);
            this.textBoxIsPrime.Name = "textBoxIsPrime";
            this.textBoxIsPrime.ReadOnly = true;
            this.textBoxIsPrime.Size = new System.Drawing.Size(124, 32);
            this.textBoxIsPrime.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Product To Solve";
            // 
            // textBoxPrimeToForce
            // 
            this.textBoxPrimeToForce.Location = new System.Drawing.Point(3, 21);
            this.textBoxPrimeToForce.Name = "textBoxPrimeToForce";
            this.textBoxPrimeToForce.Size = new System.Drawing.Size(598, 20);
            this.textBoxPrimeToForce.TabIndex = 3;
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Font = new System.Drawing.Font("Pristina", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBruteForce.Location = new System.Drawing.Point(9, 71);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(588, 50);
            this.buttonBruteForce.TabIndex = 4;
            this.buttonBruteForce.Text = "Bust That Prime!!!";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.ButtonBruteForce_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MicroSquare", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "The prime factors are:";
            // 
            // textBoxFactor1
            // 
            this.textBoxFactor1.Font = new System.Drawing.Font("MicroSquare", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFactor1.Location = new System.Drawing.Point(287, 130);
            this.textBoxFactor1.Name = "textBoxFactor1";
            this.textBoxFactor1.ReadOnly = true;
            this.textBoxFactor1.Size = new System.Drawing.Size(129, 36);
            this.textBoxFactor1.TabIndex = 6;
            // 
            // textBoxFactor2
            // 
            this.textBoxFactor2.Font = new System.Drawing.Font("MicroSquare", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFactor2.Location = new System.Drawing.Point(422, 130);
            this.textBoxFactor2.Name = "textBoxFactor2";
            this.textBoxFactor2.ReadOnly = true;
            this.textBoxFactor2.Size = new System.Drawing.Size(129, 36);
            this.textBoxFactor2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stop if factor reaches:";
            // 
            // textBoxFactorCeiling
            // 
            this.textBoxFactorCeiling.Location = new System.Drawing.Point(123, 45);
            this.textBoxFactorCeiling.Name = "textBoxFactorCeiling";
            this.textBoxFactorCeiling.Size = new System.Drawing.Size(471, 20);
            this.textBoxFactorCeiling.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 277);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "PrimeTool";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIsPrime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckPrime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrimeToCheck;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxPrimeToForce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.TextBox textBoxFactor2;
        private System.Windows.Forms.TextBox textBoxFactor1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFactorCeiling;
        private System.Windows.Forms.Label label8;
    }
}

