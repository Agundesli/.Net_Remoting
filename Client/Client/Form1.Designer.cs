namespace Client
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AnaMetin = new System.Windows.Forms.TextBox();
            this.IslemSonucu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "KucukHarf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "BuyukHarf";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(503, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "TersCevir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AnaMetin
            // 
            this.AnaMetin.Location = new System.Drawing.Point(76, 169);
            this.AnaMetin.Multiline = true;
            this.AnaMetin.Name = "AnaMetin";
            this.AnaMetin.Size = new System.Drawing.Size(258, 93);
            this.AnaMetin.TabIndex = 4;
            // 
            // IslemSonucu
            // 
            this.IslemSonucu.Location = new System.Drawing.Point(373, 169);
            this.IslemSonucu.Multiline = true;
            this.IslemSonucu.Name = "IslemSonucu";
            this.IslemSonucu.Size = new System.Drawing.Size(242, 93);
            this.IslemSonucu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IslemSonucu);
            this.Controls.Add(this.AnaMetin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox AnaMetin;
        private System.Windows.Forms.TextBox IslemSonucu;
        private System.Windows.Forms.Button button1;
    }
}

