namespace Calculator
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
            this.lblPrinter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblReset = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrinter
            // 
            this.lblPrinter.AutoSize = true;
            this.lblPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinter.Location = new System.Drawing.Point(13, 19);
            this.lblPrinter.Name = "lblPrinter";
            this.lblPrinter.Size = new System.Drawing.Size(24, 25);
            this.lblPrinter.TabIndex = 0;
            this.lblPrinter.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.lblPrinter);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(320, 65);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.lblReset);
            this.panel2.Controls.Add(this.btnEquals);
            this.panel2.Controls.Add(this.btnMinus);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Location = new System.Drawing.Point(12, 95);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(320, 332);
            this.panel2.TabIndex = 2;
            // 
            // lblReset
            // 
            this.lblReset.Location = new System.Drawing.Point(241, 241);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(70, 70);
            this.lblReset.TabIndex = 13;
            this.lblReset.Text = "C";
            this.lblReset.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(241, 165);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(70, 70);
            this.btnEquals.TabIndex = 12;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(241, 89);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 70);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(89, 241);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 70);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(165, 165);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 70);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(89, 165);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 70);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 165);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 70);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(165, 89);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 70);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(89, 89);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 70);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 89);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 70);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(241, 13);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 70);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnOperationClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(165, 13);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 70);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(89, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 70);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 70);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnNumberClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrinter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button lblReset;
    }
}

