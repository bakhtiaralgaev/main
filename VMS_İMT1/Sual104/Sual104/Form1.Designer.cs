namespace Sual104
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
            this.Gunduzbutton = new System.Windows.Forms.Button();
            this.Gecebutton = new System.Windows.Forms.Button();
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Gunduzbutton
            // 
            this.Gunduzbutton.Location = new System.Drawing.Point(286, 185);
            this.Gunduzbutton.Name = "Gunduzbutton";
            this.Gunduzbutton.Size = new System.Drawing.Size(118, 37);
            this.Gunduzbutton.TabIndex = 9;
            this.Gunduzbutton.Text = "Gunduz";
            this.Gunduzbutton.UseVisualStyleBackColor = true;
            // 
            // Gecebutton
            // 
            this.Gecebutton.Location = new System.Drawing.Point(286, 142);
            this.Gecebutton.Name = "Gecebutton";
            this.Gecebutton.Size = new System.Drawing.Size(118, 37);
            this.Gecebutton.TabIndex = 8;
            this.Gecebutton.Text = "Gece";
            this.Gecebutton.UseVisualStyleBackColor = true;
            // 
            // Disconnectbutton
            // 
            this.Disconnectbutton.Location = new System.Drawing.Point(286, 99);
            this.Disconnectbutton.Name = "Disconnectbutton";
            this.Disconnectbutton.Size = new System.Drawing.Size(118, 37);
            this.Disconnectbutton.TabIndex = 7;
            this.Disconnectbutton.Text = "Disconnect";
            this.Disconnectbutton.UseVisualStyleBackColor = true;
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(286, 56);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(118, 37);
            this.Connectbutton.TabIndex = 6;
            this.Connectbutton.Text = "Connect";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 177);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 562);
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

        private System.Windows.Forms.Button Gunduzbutton;
        private System.Windows.Forms.Button Gecebutton;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

