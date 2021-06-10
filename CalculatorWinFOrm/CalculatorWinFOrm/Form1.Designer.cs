
namespace CalculatorWinFOrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Addb = new System.Windows.Forms.Button();
            this.Subb = new System.Windows.Forms.Button();
            this.Mulb = new System.Windows.Forms.Button();
            this.Divb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY CALCUATOR APPLICATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(86, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(86, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter First number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 26);
            this.textBox2.TabIndex = 4;
            // 
            // Addb
            // 
            this.Addb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Addb.Location = new System.Drawing.Point(123, 300);
            this.Addb.Name = "Addb";
            this.Addb.Size = new System.Drawing.Size(70, 39);
            this.Addb.TabIndex = 5;
            this.Addb.Text = "Add";
            this.Addb.UseVisualStyleBackColor = false;
            this.Addb.Click += new System.EventHandler(this.Addb_Click);
            // 
            // Subb
            // 
            this.Subb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Subb.Location = new System.Drawing.Point(272, 296);
            this.Subb.Name = "Subb";
            this.Subb.Size = new System.Drawing.Size(75, 43);
            this.Subb.TabIndex = 6;
            this.Subb.Text = "Sub";
            this.Subb.UseVisualStyleBackColor = false;
            this.Subb.Click += new System.EventHandler(this.Subb_Click);
            // 
            // Mulb
            // 
            this.Mulb.Location = new System.Drawing.Point(416, 296);
            this.Mulb.Name = "Mulb";
            this.Mulb.Size = new System.Drawing.Size(75, 43);
            this.Mulb.TabIndex = 7;
            this.Mulb.Text = "Mul";
            this.Mulb.UseVisualStyleBackColor = true;
            this.Mulb.Click += new System.EventHandler(this.Mulb_Click);
            // 
            // Divb
            // 
            this.Divb.Location = new System.Drawing.Point(562, 296);
            this.Divb.Name = "Divb";
            this.Divb.Size = new System.Drawing.Size(75, 43);
            this.Divb.TabIndex = 8;
            this.Divb.Text = "Div";
            this.Divb.UseVisualStyleBackColor = true;
            this.Divb.Click += new System.EventHandler(this.Divb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(691, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Divb);
            this.Controls.Add(this.Mulb);
            this.Controls.Add(this.Subb);
            this.Controls.Add(this.Addb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Addb;
        private System.Windows.Forms.Button Subb;
        private System.Windows.Forms.Button Mulb;
        private System.Windows.Forms.Button Divb;
        private System.Windows.Forms.Label label4;
    }
}

