namespace Sual102
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Shutdownbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Restartbutton = new System.Windows.Forms.Button();
            this.Daybutton = new System.Windows.Forms.Button();
            this.Nightbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.Disconnectbutton);
            this.groupBox1.Controls.Add(this.Nightbutton);
            this.groupBox1.Controls.Add(this.Connectbutton);
            this.groupBox1.Controls.Add(this.Daybutton);
            this.groupBox1.Controls.Add(this.Restartbutton);
            this.groupBox1.Controls.Add(this.Startbutton);
            this.groupBox1.Controls.Add(this.Shutdownbutton);
            this.groupBox1.Location = new System.Drawing.Point(195, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Təlimatçı panel";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(66, 32);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(133, 36);
            this.Connectbutton.TabIndex = 0;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Disconnectbutton
            // 
            this.Disconnectbutton.Location = new System.Drawing.Point(205, 32);
            this.Disconnectbutton.Name = "Disconnectbutton";
            this.Disconnectbutton.Size = new System.Drawing.Size(133, 36);
            this.Disconnectbutton.TabIndex = 1;
            this.Disconnectbutton.Text = "Disconnect";
            this.Disconnectbutton.UseVisualStyleBackColor = true;
            this.Disconnectbutton.Click += new System.EventHandler(this.Disconnectbutton_Click);
            // 
            // Shutdownbutton
            // 
            this.Shutdownbutton.Location = new System.Drawing.Point(205, 245);
            this.Shutdownbutton.Name = "Shutdownbutton";
            this.Shutdownbutton.Size = new System.Drawing.Size(158, 53);
            this.Shutdownbutton.TabIndex = 1;
            this.Shutdownbutton.Text = "Engine shutdown";
            this.Shutdownbutton.UseVisualStyleBackColor = true;
            this.Shutdownbutton.Click += new System.EventHandler(this.Shutdownbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(41, 245);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(158, 53);
            this.Startbutton.TabIndex = 2;
            this.Startbutton.Text = "Engine start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Restartbutton
            // 
            this.Restartbutton.Location = new System.Drawing.Point(124, 205);
            this.Restartbutton.Name = "Restartbutton";
            this.Restartbutton.Size = new System.Drawing.Size(147, 34);
            this.Restartbutton.TabIndex = 3;
            this.Restartbutton.Text = "Restart scenario";
            this.Restartbutton.UseVisualStyleBackColor = true;
            this.Restartbutton.Click += new System.EventHandler(this.Restartbutton_Click);
            // 
            // Daybutton
            // 
            this.Daybutton.Location = new System.Drawing.Point(41, 304);
            this.Daybutton.Name = "Daybutton";
            this.Daybutton.Size = new System.Drawing.Size(158, 53);
            this.Daybutton.TabIndex = 4;
            this.Daybutton.Text = "Day";
            this.Daybutton.UseVisualStyleBackColor = true;
            this.Daybutton.Click += new System.EventHandler(this.Daybutton_Click);
            // 
            // Nightbutton
            // 
            this.Nightbutton.Location = new System.Drawing.Point(205, 304);
            this.Nightbutton.Name = "Nightbutton";
            this.Nightbutton.Size = new System.Drawing.Size(158, 53);
            this.Nightbutton.TabIndex = 5;
            this.Nightbutton.Text = "Night";
            this.Nightbutton.UseVisualStyleBackColor = true;
            this.Nightbutton.Click += new System.EventHandler(this.Nightbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 114);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Shutdownbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Nightbutton;
        private System.Windows.Forms.Button Daybutton;
        private System.Windows.Forms.Button Restartbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

