
namespace URLShortener
{
    partial class MainWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLong = new System.Windows.Forms.TextBox();
            this.linkShort = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLong = new System.Windows.Forms.LinkLabel();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Long URL";
            // 
            // tbLong
            // 
            this.tbLong.Location = new System.Drawing.Point(12, 25);
            this.tbLong.Name = "tbLong";
            this.tbLong.Size = new System.Drawing.Size(737, 20);
            this.tbLong.TabIndex = 1;
            // 
            // linkShort
            // 
            this.linkShort.AutoSize = true;
            this.linkShort.Location = new System.Drawing.Point(12, 89);
            this.linkShort.Name = "linkShort";
            this.linkShort.Size = new System.Drawing.Size(19, 13);
            this.linkShort.TabIndex = 2;
            this.linkShort.TabStop = true;
            this.linkShort.Text = "<>";
            this.linkShort.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShort_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shortened URL";
            // 
            // linkLong
            // 
            this.linkLong.AutoSize = true;
            this.linkLong.Location = new System.Drawing.Point(13, 48);
            this.linkLong.Name = "linkLong";
            this.linkLong.Size = new System.Drawing.Size(19, 13);
            this.linkLong.TabIndex = 4;
            this.linkLong.TabStop = true;
            this.linkLong.Text = "<>";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(15, 126);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "&Shorten";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(110, 126);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 168);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.linkLong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkShort);
            this.Controls.Add(this.tbLong);
            this.Controls.Add(this.label1);
            this.Name = "MainWin";
            this.Text = "Shorten URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLong;
        private System.Windows.Forms.LinkLabel linkShort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLong;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnQuit;
    }
}

