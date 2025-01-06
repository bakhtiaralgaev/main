namespace Sual106
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visibilty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_prec = new System.Windows.Forms.ComboBox();
            this.Cavokbutton = new System.Windows.Forms.Button();
            this.SetWeatherbutton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(235, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 234);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STATUS";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnectbutton);
            this.groupBox1.Controls.Add(this.Connectbutton);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 123);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // Disconnectbutton
            // 
            this.Disconnectbutton.Location = new System.Drawing.Point(6, 72);
            this.Disconnectbutton.Name = "Disconnectbutton";
            this.Disconnectbutton.Size = new System.Drawing.Size(196, 30);
            this.Disconnectbutton.TabIndex = 16;
            this.Disconnectbutton.Text = "DISCONNECT";
            this.Disconnectbutton.UseVisualStyleBackColor = true;
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(6, 36);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(196, 30);
            this.Connectbutton.TabIndex = 15;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "VISIBILITY";
            // 
            // visibilty
            // 
            this.visibilty.Location = new System.Drawing.Point(115, 171);
            this.visibilty.Name = "visibilty";
            this.visibilty.ReadOnly = true;
            this.visibilty.Size = new System.Drawing.Size(108, 22);
            this.visibilty.TabIndex = 29;
            this.visibilty.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "PRECIPATION";
            // 
            // comboBox_prec
            // 
            this.comboBox_prec.DisplayMember = "SELECT";
            this.comboBox_prec.FormattingEnabled = true;
            this.comboBox_prec.Items.AddRange(new object[] {
            "NONE",
            "RAIN",
            "SNOW"});
            this.comboBox_prec.Location = new System.Drawing.Point(288, 43);
            this.comboBox_prec.Name = "comboBox_prec";
            this.comboBox_prec.Size = new System.Drawing.Size(142, 24);
            this.comboBox_prec.TabIndex = 31;
            this.comboBox_prec.Text = "SELECT";
            // 
            // Cavokbutton
            // 
            this.Cavokbutton.Location = new System.Drawing.Point(381, 82);
            this.Cavokbutton.Name = "Cavokbutton";
            this.Cavokbutton.Size = new System.Drawing.Size(134, 44);
            this.Cavokbutton.TabIndex = 34;
            this.Cavokbutton.Text = "CAVOK";
            this.Cavokbutton.UseVisualStyleBackColor = true;
            this.Cavokbutton.Click += new System.EventHandler(this.Cavokbutton_Click_1);
            // 
            // SetWeatherbutton
            // 
            this.SetWeatherbutton.Location = new System.Drawing.Point(238, 82);
            this.SetWeatherbutton.Name = "SetWeatherbutton";
            this.SetWeatherbutton.Size = new System.Drawing.Size(124, 44);
            this.SetWeatherbutton.TabIndex = 33;
            this.SetWeatherbutton.Text = "SET WEATHER";
            this.SetWeatherbutton.UseVisualStyleBackColor = true;
            this.SetWeatherbutton.Click += new System.EventHandler(this.SetWeatherbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 555);
            this.Controls.Add(this.Cavokbutton);
            this.Controls.Add(this.SetWeatherbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_prec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visibilty);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visibilty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_prec;
        private System.Windows.Forms.Button Cavokbutton;
        private System.Windows.Forms.Button SetWeatherbutton;
    }
}

