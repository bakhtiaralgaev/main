namespace Sual83
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
            this.Cavokbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SetWeatherbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_wshear = new System.Windows.Forms.ComboBox();
            this.comboBox_turb = new System.Windows.Forms.ComboBox();
            this.comboBoxGust = new System.Windows.Forms.ComboBox();
            this.comboBox_prec = new System.Windows.Forms.ComboBox();
            this.wspeed = new System.Windows.Forms.TextBox();
            this.wdirection = new System.Windows.Forms.TextBox();
            this.visibilty = new System.Windows.Forms.TextBox();
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cavokbutton
            // 
            this.Cavokbutton.Location = new System.Drawing.Point(605, 233);
            this.Cavokbutton.Name = "Cavokbutton";
            this.Cavokbutton.Size = new System.Drawing.Size(273, 76);
            this.Cavokbutton.TabIndex = 25;
            this.Cavokbutton.Text = "CAVOK";
            this.Cavokbutton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(271, 210);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SetWeatherbutton
            // 
            this.SetWeatherbutton.Location = new System.Drawing.Point(336, 233);
            this.SetWeatherbutton.Name = "SetWeatherbutton";
            this.SetWeatherbutton.Size = new System.Drawing.Size(263, 76);
            this.SetWeatherbutton.TabIndex = 24;
            this.SetWeatherbutton.Text = "SET WEATHER";
            this.SetWeatherbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(29, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 234);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STATUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(590, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "WINDSHEAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "GUST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "TURBULENCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRECIPATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIRECTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SPEED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "VISIBILITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "WIND";
            // 
            // comboBox_wshear
            // 
            this.comboBox_wshear.FormattingEnabled = true;
            this.comboBox_wshear.Items.AddRange(new object[] {
            "NONE",
            "MODERATE",
            "STEEP",
            "INSTANTANEOUS"});
            this.comboBox_wshear.Location = new System.Drawing.Point(563, 131);
            this.comboBox_wshear.Name = "comboBox_wshear";
            this.comboBox_wshear.Size = new System.Drawing.Size(142, 24);
            this.comboBox_wshear.TabIndex = 6;
            this.comboBox_wshear.Text = "SELECT";
            // 
            // comboBox_turb
            // 
            this.comboBox_turb.FormattingEnabled = true;
            this.comboBox_turb.Items.AddRange(new object[] {
            "NONE",
            "LIGHT",
            "MODERATE",
            "HEAVY",
            "SEVERE"});
            this.comboBox_turb.Location = new System.Drawing.Point(193, 131);
            this.comboBox_turb.Name = "comboBox_turb";
            this.comboBox_turb.Size = new System.Drawing.Size(142, 24);
            this.comboBox_turb.TabIndex = 5;
            this.comboBox_turb.Text = "SELECT";
            // 
            // comboBoxGust
            // 
            this.comboBoxGust.FormattingEnabled = true;
            this.comboBoxGust.Items.AddRange(new object[] {
            "NONE",
            "RAIN",
            "SNOW"});
            this.comboBoxGust.Location = new System.Drawing.Point(386, 131);
            this.comboBoxGust.Name = "comboBoxGust";
            this.comboBoxGust.Size = new System.Drawing.Size(142, 24);
            this.comboBoxGust.TabIndex = 4;
            this.comboBoxGust.Text = "SELECT";
            // 
            // comboBox_prec
            // 
            this.comboBox_prec.DisplayMember = "SELECT";
            this.comboBox_prec.FormattingEnabled = true;
            this.comboBox_prec.Items.AddRange(new object[] {
            "NONE",
            "RAIN",
            "SNOW"});
            this.comboBox_prec.Location = new System.Drawing.Point(13, 131);
            this.comboBox_prec.Name = "comboBox_prec";
            this.comboBox_prec.Size = new System.Drawing.Size(142, 24);
            this.comboBox_prec.TabIndex = 3;
            this.comboBox_prec.Text = "SELECT";
            // 
            // wspeed
            // 
            this.wspeed.Location = new System.Drawing.Point(279, 70);
            this.wspeed.Name = "wspeed";
            this.wspeed.Size = new System.Drawing.Size(108, 22);
            this.wspeed.TabIndex = 2;
            // 
            // wdirection
            // 
            this.wdirection.Location = new System.Drawing.Point(421, 70);
            this.wdirection.Name = "wdirection";
            this.wdirection.Size = new System.Drawing.Size(108, 22);
            this.wdirection.TabIndex = 1;
            // 
            // visibilty
            // 
            this.visibilty.Location = new System.Drawing.Point(139, 70);
            this.visibilty.Name = "visibilty";
            this.visibilty.Size = new System.Drawing.Size(108, 22);
            this.visibilty.TabIndex = 0;
            this.visibilty.Text = "1";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox_wshear);
            this.groupBox2.Controls.Add(this.comboBox_turb);
            this.groupBox2.Controls.Add(this.comboBoxGust);
            this.groupBox2.Controls.Add(this.comboBox_prec);
            this.groupBox2.Controls.Add(this.wspeed);
            this.groupBox2.Controls.Add(this.wdirection);
            this.groupBox2.Controls.Add(this.visibilty);
            this.groupBox2.Location = new System.Drawing.Point(243, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 183);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weather settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnectbutton);
            this.groupBox1.Controls.Add(this.Connectbutton);
            this.groupBox1.Location = new System.Drawing.Point(29, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 123);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 575);
            this.Controls.Add(this.Cavokbutton);
            this.Controls.Add(this.SetWeatherbutton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cavokbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SetWeatherbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_wshear;
        private System.Windows.Forms.ComboBox comboBox_turb;
        private System.Windows.Forms.ComboBox comboBoxGust;
        private System.Windows.Forms.ComboBox comboBox_prec;
        private System.Windows.Forms.TextBox wspeed;
        private System.Windows.Forms.TextBox wdirection;
        private System.Windows.Forms.TextBox visibilty;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

