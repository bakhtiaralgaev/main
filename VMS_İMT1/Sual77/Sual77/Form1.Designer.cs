namespace Sual77
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
            this.Connectbutton = new System.Windows.Forms.Button();
            this.upbutton = new System.Windows.Forms.Button();
            this.leftbutton = new System.Windows.Forms.Button();
            this.rightbutton = new System.Windows.Forms.Button();
            this.downbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(164, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 213);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(472, 23);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(108, 31);
            this.Connectbutton.TabIndex = 1;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // upbutton
            // 
            this.upbutton.Location = new System.Drawing.Point(521, 123);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(75, 23);
            this.upbutton.TabIndex = 2;
            this.upbutton.Text = "up";
            this.upbutton.UseVisualStyleBackColor = true;
            // 
            // leftbutton
            // 
            this.leftbutton.Location = new System.Drawing.Point(442, 152);
            this.leftbutton.Name = "leftbutton";
            this.leftbutton.Size = new System.Drawing.Size(75, 23);
            this.leftbutton.TabIndex = 3;
            this.leftbutton.Text = "left";
            this.leftbutton.UseVisualStyleBackColor = true;
            // 
            // rightbutton
            // 
            this.rightbutton.Location = new System.Drawing.Point(599, 152);
            this.rightbutton.Name = "rightbutton";
            this.rightbutton.Size = new System.Drawing.Size(75, 23);
            this.rightbutton.TabIndex = 4;
            this.rightbutton.Text = "right";
            this.rightbutton.UseVisualStyleBackColor = true;
            // 
            // downbutton
            // 
            this.downbutton.Location = new System.Drawing.Point(521, 181);
            this.downbutton.Name = "downbutton";
            this.downbutton.Size = new System.Drawing.Size(75, 23);
            this.downbutton.TabIndex = 5;
            this.downbutton.Text = "down";
            this.downbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 544);
            this.Controls.Add(this.downbutton);
            this.Controls.Add(this.rightbutton);
            this.Controls.Add(this.leftbutton);
            this.Controls.Add(this.upbutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button upbutton;
        private System.Windows.Forms.Button leftbutton;
        private System.Windows.Forms.Button rightbutton;
        private System.Windows.Forms.Button downbutton;
    }
}

