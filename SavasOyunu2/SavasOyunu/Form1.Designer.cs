namespace SavasOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pcanlabel = new System.Windows.Forms.Label();
            this.scanlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sdmgbox = new System.Windows.Forms.PictureBox();
            this.pdmgbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdmgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdmgbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(207, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "C/F";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(358, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 212);
            this.listBox1.TabIndex = 4;
            // 
            // pcanlabel
            // 
            this.pcanlabel.AutoSize = true;
            this.pcanlabel.Location = new System.Drawing.Point(68, 36);
            this.pcanlabel.Name = "pcanlabel";
            this.pcanlabel.Size = new System.Drawing.Size(25, 13);
            this.pcanlabel.TabIndex = 5;
            this.pcanlabel.Text = "100";
            // 
            // scanlabel
            // 
            this.scanlabel.AutoSize = true;
            this.scanlabel.Location = new System.Drawing.Point(271, 36);
            this.scanlabel.Name = "scanlabel";
            this.scanlabel.Size = new System.Drawing.Size(25, 13);
            this.scanlabel.TabIndex = 6;
            this.scanlabel.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "ATT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(575, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(203, 212);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // sdmgbox
            // 
            this.sdmgbox.Image = ((System.Drawing.Image)(resources.GetObject("sdmgbox.Image")));
            this.sdmgbox.Location = new System.Drawing.Point(207, 52);
            this.sdmgbox.Name = "sdmgbox";
            this.sdmgbox.Size = new System.Drawing.Size(145, 151);
            this.sdmgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sdmgbox.TabIndex = 9;
            this.sdmgbox.TabStop = false;
            this.sdmgbox.Visible = false;
            this.sdmgbox.WaitOnLoad = true;
            // 
            // pdmgbox
            // 
            this.pdmgbox.Image = ((System.Drawing.Image)(resources.GetObject("pdmgbox.Image")));
            this.pdmgbox.Location = new System.Drawing.Point(12, 52);
            this.pdmgbox.Name = "pdmgbox";
            this.pdmgbox.Size = new System.Drawing.Size(142, 151);
            this.pdmgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdmgbox.TabIndex = 10;
            this.pdmgbox.TabStop = false;
            this.pdmgbox.Visible = false;
            this.pdmgbox.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.pdmgbox);
            this.Controls.Add(this.sdmgbox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.scanlabel);
            this.Controls.Add(this.pcanlabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdmgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdmgbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label pcanlabel;
        private System.Windows.Forms.Label scanlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox sdmgbox;
        private System.Windows.Forms.PictureBox pdmgbox;
    }
}

