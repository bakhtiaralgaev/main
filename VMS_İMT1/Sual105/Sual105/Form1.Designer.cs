namespace Sual105
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
            this.Disconnectbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wspeed = new System.Windows.Forms.TextBox();
            this.wdirection = new System.Windows.Forms.TextBox();
            this.SetWindbutton = new System.Windows.Forms.Button();
            this.Cavokbutton = new System.Windows.Forms.Button();
            this.visibilty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnectbutton);
            this.groupBox1.Controls.Add(this.Connectbutton);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 123);
            this.groupBox1.TabIndex = 2;
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
            this.Disconnectbutton.Click += new System.EventHandler(this.Disconnectbutton_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(240, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 234);
            this.groupBox3.TabIndex = 19;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "DIRECTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "SPEED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "WIND";
            // 
            // wspeed
            // 
            this.wspeed.Location = new System.Drawing.Point(270, 65);
            this.wspeed.Name = "wspeed";
            this.wspeed.Size = new System.Drawing.Size(108, 22);
            this.wspeed.TabIndex = 21;
            // 
            // wdirection
            // 
            this.wdirection.Location = new System.Drawing.Point(412, 65);
            this.wdirection.Name = "wdirection";
            this.wdirection.Size = new System.Drawing.Size(108, 22);
            this.wdirection.TabIndex = 20;
            // 
            // SetWindbutton
            // 
            this.SetWindbutton.Location = new System.Drawing.Point(270, 103);
            this.SetWindbutton.Name = "SetWindbutton";
            this.SetWindbutton.Size = new System.Drawing.Size(108, 51);
            this.SetWindbutton.TabIndex = 25;
            this.SetWindbutton.Text = "Set Wind";
            this.SetWindbutton.UseVisualStyleBackColor = true;
            this.SetWindbutton.Click += new System.EventHandler(this.SetWindbutton_Click);
            // 
            // Cavokbutton
            // 
            this.Cavokbutton.Location = new System.Drawing.Point(412, 103);
            this.Cavokbutton.Name = "Cavokbutton";
            this.Cavokbutton.Size = new System.Drawing.Size(108, 51);
            this.Cavokbutton.TabIndex = 26;
            this.Cavokbutton.Text = "CAVOK";
            this.Cavokbutton.UseVisualStyleBackColor = true;
            this.Cavokbutton.Click += new System.EventHandler(this.Cavokbutton_Click);
            // 
            // visibilty
            // 
            this.visibilty.Location = new System.Drawing.Point(120, 188);
            this.visibilty.Name = "visibilty";
            this.visibilty.ReadOnly = true;
            this.visibilty.Size = new System.Drawing.Size(108, 22);
            this.visibilty.TabIndex = 27;
            this.visibilty.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "VISIBILITY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visibilty);
            this.Controls.Add(this.Cavokbutton);
            this.Controls.Add(this.SetWindbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wspeed);
            this.Controls.Add(this.wdirection);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Disconnectbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wspeed;
        private System.Windows.Forms.TextBox wdirection;
        private System.Windows.Forms.Button SetWindbutton;
        private System.Windows.Forms.Button Cavokbutton;
        private System.Windows.Forms.TextBox visibilty;
        private System.Windows.Forms.Label label2;
    }
}

