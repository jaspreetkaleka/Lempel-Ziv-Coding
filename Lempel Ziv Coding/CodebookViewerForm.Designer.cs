namespace LempelZivCoding
{
    partial class CodebookViewerForm
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
            this.codeBookTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.longestPhraseLabel = new System.Windows.Forms.Label();
            this.totalPhrasesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBookTextBox
            // 
            this.codeBookTextBox.BackColor = System.Drawing.Color.White;
            this.codeBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBookTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBookTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.codeBookTextBox.Location = new System.Drawing.Point(29, 64);
            this.codeBookTextBox.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.codeBookTextBox.Name = "codeBookTextBox";
            this.codeBookTextBox.ReadOnly = true;
            this.codeBookTextBox.Size = new System.Drawing.Size(604, 341);
            this.codeBookTextBox.TabIndex = 0;
            this.codeBookTextBox.Text = "";
            this.codeBookTextBox.WordWrap = false;
            this.codeBookTextBox.ZoomFactor = 1.5F;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 64);
            this.panel1.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 22F);
            this.titleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titleLabel.Location = new System.Drawing.Point(162, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(308, 42);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Codebook (Base - 16)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.longestPhraseLabel);
            this.panel2.Controls.Add(this.totalPhrasesLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 96);
            this.panel2.TabIndex = 6;
            // 
            // longestPhraseLabel
            // 
            this.longestPhraseLabel.AutoSize = true;
            this.longestPhraseLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longestPhraseLabel.ForeColor = System.Drawing.Color.Crimson;
            this.longestPhraseLabel.Location = new System.Drawing.Point(334, 50);
            this.longestPhraseLabel.Name = "longestPhraseLabel";
            this.longestPhraseLabel.Size = new System.Drawing.Size(30, 33);
            this.longestPhraseLabel.TabIndex = 9;
            this.longestPhraseLabel.Text = "0";
            // 
            // totalPhrasesLabel
            // 
            this.totalPhrasesLabel.AutoSize = true;
            this.totalPhrasesLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPhrasesLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalPhrasesLabel.Location = new System.Drawing.Point(366, 12);
            this.totalPhrasesLabel.Name = "totalPhrasesLabel";
            this.totalPhrasesLabel.Size = new System.Drawing.Size(30, 33);
            this.totalPhrasesLabel.TabIndex = 8;
            this.totalPhrasesLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Longest phrase is of length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total phrases in codebook are\r\n";
            // 
            // CodebookViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 501);
            this.Controls.Add(this.codeBookTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodebookViewerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Codebook Viewer";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox codeBookTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label longestPhraseLabel;
        private System.Windows.Forms.Label totalPhrasesLabel;
        private System.Windows.Forms.Label label1;
    }
}