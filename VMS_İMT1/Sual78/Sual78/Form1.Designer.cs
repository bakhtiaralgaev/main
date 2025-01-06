namespace Sual78
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Connectionbutton = new System.Windows.Forms.Button();
            this.Engineon = new System.Windows.Forms.Button();
            this.Engineoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 24);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 159);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Connectionbutton
            // 
            this.Connectionbutton.Location = new System.Drawing.Point(368, 24);
            this.Connectionbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connectionbutton.Name = "Connectionbutton";
            this.Connectionbutton.Size = new System.Drawing.Size(112, 42);
            this.Connectionbutton.TabIndex = 4;
            this.Connectionbutton.Text = "Connection";
            this.Connectionbutton.UseVisualStyleBackColor = true;
            this.Connectionbutton.Click += new System.EventHandler(this.Connectionbutton_Click);
            // 
            // Engineon
            // 
            this.Engineon.Location = new System.Drawing.Point(368, 117);
            this.Engineon.Margin = new System.Windows.Forms.Padding(4);
            this.Engineon.Name = "Engineon";
            this.Engineon.Size = new System.Drawing.Size(112, 39);
            this.Engineon.TabIndex = 7;
            this.Engineon.Text = "Engine on";
            this.Engineon.UseVisualStyleBackColor = true;
            this.Engineon.Click += new System.EventHandler(this.Engineon_Click);
            // 
            // Engineoff
            // 
            this.Engineoff.Location = new System.Drawing.Point(368, 72);
            this.Engineoff.Margin = new System.Windows.Forms.Padding(4);
            this.Engineoff.Name = "Engineoff";
            this.Engineoff.Size = new System.Drawing.Size(112, 37);
            this.Engineoff.TabIndex = 6;
            this.Engineoff.Text = "Engine off";
            this.Engineoff.UseVisualStyleBackColor = true;
            this.Engineoff.Click += new System.EventHandler(this.Engineoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 545);
            this.Controls.Add(this.Engineon);
            this.Controls.Add(this.Engineoff);
            this.Controls.Add(this.Connectionbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Connectionbutton;
        private System.Windows.Forms.Button Engineon;
        private System.Windows.Forms.Button Engineoff;
    }
}

