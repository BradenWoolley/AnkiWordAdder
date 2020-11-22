
namespace AddWords
{
    partial class FrmMain
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPurge = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.btnTj = new System.Windows.Forms.Button();
            this.btnDz = new System.Windows.Forms.Button();
            this.btnDj = new System.Windows.Forms.Button();
            this.btnSh = new System.Windows.Forms.Button();
            this.btnZh = new System.Windows.Forms.Button();
            this.btnLZh = new System.Windows.Forms.Button();
            this.btnLSh = new System.Windows.Forms.Button();
            this.btnLDj = new System.Windows.Forms.Button();
            this.btnLDz = new System.Windows.Forms.Button();
            this.btnLTj = new System.Windows.Forms.Button();
            this.btnLCh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(81, 23);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(87, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word/Sentence:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(84, 50);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(210, 20);
            this.txtWord.TabIndex = 1;
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(84, 111);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(210, 20);
            this.txtTranslation.TabIndex = 3;
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Location = new System.Drawing.Point(81, 84);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(62, 13);
            this.lblTranslation.TabIndex = 2;
            this.lblTranslation.Text = "Translation:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(84, 153);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(210, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(84, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPurge
            // 
            this.btnPurge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurge.Location = new System.Drawing.Point(84, 242);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(210, 23);
            this.btnPurge.TabIndex = 6;
            this.btnPurge.Text = "Purge File";
            this.btnPurge.UseVisualStyleBackColor = true;
            this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(320, 47);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(41, 23);
            this.btnCh.TabIndex = 7;
            this.btnCh.Text = "Č";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click);
            // 
            // btnTj
            // 
            this.btnTj.Location = new System.Drawing.Point(367, 47);
            this.btnTj.Name = "btnTj";
            this.btnTj.Size = new System.Drawing.Size(41, 23);
            this.btnTj.TabIndex = 8;
            this.btnTj.Text = "Ć";
            this.btnTj.UseVisualStyleBackColor = true;
            this.btnTj.Click += new System.EventHandler(this.btnTj_Click);
            // 
            // btnDz
            // 
            this.btnDz.Location = new System.Drawing.Point(414, 47);
            this.btnDz.Name = "btnDz";
            this.btnDz.Size = new System.Drawing.Size(41, 23);
            this.btnDz.TabIndex = 9;
            this.btnDz.Text = "Dž";
            this.btnDz.UseVisualStyleBackColor = true;
            this.btnDz.Click += new System.EventHandler(this.btnDz_Click);
            // 
            // btnDj
            // 
            this.btnDj.Location = new System.Drawing.Point(461, 48);
            this.btnDj.Name = "btnDj";
            this.btnDj.Size = new System.Drawing.Size(41, 23);
            this.btnDj.TabIndex = 10;
            this.btnDj.Text = "Đ";
            this.btnDj.UseVisualStyleBackColor = true;
            this.btnDj.Click += new System.EventHandler(this.btnDj_Click);
            // 
            // btnSh
            // 
            this.btnSh.Location = new System.Drawing.Point(508, 48);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(41, 23);
            this.btnSh.TabIndex = 11;
            this.btnSh.Text = "Š";
            this.btnSh.UseVisualStyleBackColor = true;
            this.btnSh.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // btnZh
            // 
            this.btnZh.Location = new System.Drawing.Point(555, 48);
            this.btnZh.Name = "btnZh";
            this.btnZh.Size = new System.Drawing.Size(41, 23);
            this.btnZh.TabIndex = 12;
            this.btnZh.Text = "Ž";
            this.btnZh.UseVisualStyleBackColor = true;
            this.btnZh.Click += new System.EventHandler(this.btnZh_Click);
            // 
            // btnLZh
            // 
            this.btnLZh.Location = new System.Drawing.Point(555, 80);
            this.btnLZh.Name = "btnLZh";
            this.btnLZh.Size = new System.Drawing.Size(41, 23);
            this.btnLZh.TabIndex = 18;
            this.btnLZh.Text = "ž";
            this.btnLZh.UseVisualStyleBackColor = true;
            this.btnLZh.Click += new System.EventHandler(this.btnLZh_Click);
            // 
            // btnLSh
            // 
            this.btnLSh.Location = new System.Drawing.Point(508, 80);
            this.btnLSh.Name = "btnLSh";
            this.btnLSh.Size = new System.Drawing.Size(41, 23);
            this.btnLSh.TabIndex = 17;
            this.btnLSh.Text = "š";
            this.btnLSh.UseVisualStyleBackColor = true;
            this.btnLSh.Click += new System.EventHandler(this.btnLSh_Click);
            // 
            // btnLDj
            // 
            this.btnLDj.Location = new System.Drawing.Point(461, 80);
            this.btnLDj.Name = "btnLDj";
            this.btnLDj.Size = new System.Drawing.Size(41, 23);
            this.btnLDj.TabIndex = 16;
            this.btnLDj.Text = "đ";
            this.btnLDj.UseVisualStyleBackColor = true;
            this.btnLDj.Click += new System.EventHandler(this.btnLDj_Click);
            // 
            // btnLDz
            // 
            this.btnLDz.Location = new System.Drawing.Point(414, 79);
            this.btnLDz.Name = "btnLDz";
            this.btnLDz.Size = new System.Drawing.Size(41, 23);
            this.btnLDz.TabIndex = 15;
            this.btnLDz.Text = "dž";
            this.btnLDz.UseVisualStyleBackColor = true;
            this.btnLDz.Click += new System.EventHandler(this.btnLDz_Click);
            // 
            // btnLTj
            // 
            this.btnLTj.Location = new System.Drawing.Point(367, 79);
            this.btnLTj.Name = "btnLTj";
            this.btnLTj.Size = new System.Drawing.Size(41, 23);
            this.btnLTj.TabIndex = 14;
            this.btnLTj.Text = "ć";
            this.btnLTj.UseVisualStyleBackColor = true;
            this.btnLTj.Click += new System.EventHandler(this.btnLTj_Click);
            // 
            // btnLCh
            // 
            this.btnLCh.Location = new System.Drawing.Point(320, 79);
            this.btnLCh.Name = "btnLCh";
            this.btnLCh.Size = new System.Drawing.Size(41, 23);
            this.btnLCh.TabIndex = 13;
            this.btnLCh.Text = "č";
            this.btnLCh.UseVisualStyleBackColor = true;
            this.btnLCh.Click += new System.EventHandler(this.btnLCh_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 277);
            this.Controls.Add(this.btnLZh);
            this.Controls.Add(this.btnLSh);
            this.Controls.Add(this.btnLDj);
            this.Controls.Add(this.btnLDz);
            this.Controls.Add(this.btnLTj);
            this.Controls.Add(this.btnLCh);
            this.Controls.Add(this.btnZh);
            this.Controls.Add(this.btnSh);
            this.Controls.Add(this.btnDj);
            this.Controls.Add(this.btnDz);
            this.Controls.Add(this.btnTj);
            this.Controls.Add(this.btnCh);
            this.Controls.Add(this.btnPurge);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Adder";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.Button btnTj;
        private System.Windows.Forms.Button btnDz;
        private System.Windows.Forms.Button btnDj;
        private System.Windows.Forms.Button btnSh;
        private System.Windows.Forms.Button btnZh;
        private System.Windows.Forms.Button btnLZh;
        private System.Windows.Forms.Button btnLSh;
        private System.Windows.Forms.Button btnLDj;
        private System.Windows.Forms.Button btnLDz;
        private System.Windows.Forms.Button btnLTj;
        private System.Windows.Forms.Button btnLCh;
    }
}

