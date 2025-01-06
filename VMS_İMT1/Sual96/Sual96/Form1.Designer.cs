namespace Sual96
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
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Gecebutton = new System.Windows.Forms.Button();
            this.Gunduzbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 177);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(255, 55);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(118, 37);
            this.Connectbutton.TabIndex = 1;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Disconnectbutton
            // 
            this.Disconnectbutton.Location = new System.Drawing.Point(255, 98);
            this.Disconnectbutton.Name = "Disconnectbutton";
            this.Disconnectbutton.Size = new System.Drawing.Size(118, 37);
            this.Disconnectbutton.TabIndex = 2;
            this.Disconnectbutton.Text = "Disconnect";
            this.Disconnectbutton.UseVisualStyleBackColor = true;
            this.Disconnectbutton.Click += new System.EventHandler(this.Disconnectbutton_Click);
            // 
            // Gecebutton
            // 
            this.Gecebutton.Location = new System.Drawing.Point(255, 141);
            this.Gecebutton.Name = "Gecebutton";
            this.Gecebutton.Size = new System.Drawing.Size(118, 37);
            this.Gecebutton.TabIndex = 3;
            this.Gecebutton.Text = "Gece";
            this.Gecebutton.UseVisualStyleBackColor = true;
            this.Gecebutton.Click += new System.EventHandler(this.Gecebutton_Click);
            // 
            // Gunduzbutton
            // 
            this.Gunduzbutton.Location = new System.Drawing.Point(255, 184);
            this.Gunduzbutton.Name = "Gunduzbutton";
            this.Gunduzbutton.Size = new System.Drawing.Size(118, 37);
            this.Gunduzbutton.TabIndex = 4;
            this.Gunduzbutton.Text = "Gunduz";
            this.Gunduzbutton.UseVisualStyleBackColor = true;
            this.Gunduzbutton.Click += new System.EventHandler(this.Gunduzbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 502);
            this.Controls.Add(this.Gunduzbutton);
            this.Controls.Add(this.Gecebutton);
            this.Controls.Add(this.Disconnectbutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Gecebutton;
        private System.Windows.Forms.Button Gunduzbutton;
    }
}

