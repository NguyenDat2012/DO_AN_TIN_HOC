namespace MALLMAP
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
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbTANG2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTANG2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Location = new System.Drawing.Point(318, 497);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(213, 24);
            this.cboStart.TabIndex = 1;
            // 
            // cboEnd
            // 
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Location = new System.Drawing.Point(710, 497);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(210, 24);
            this.cboEnd.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(1013, 487);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(118, 41);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "START";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "END";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(541, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 53);
            this.label3.TabIndex = 6;
            this.label3.Text = "SƠ ĐỒ TẦNG 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ptbTANG2
            // 
            this.ptbTANG2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbTANG2.ErrorImage")));
            this.ptbTANG2.Image = ((System.Drawing.Image)(resources.GetObject("ptbTANG2.Image")));
            this.ptbTANG2.Location = new System.Drawing.Point(-249, 0);
            this.ptbTANG2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 4);
            this.ptbTANG2.Name = "ptbTANG2";
            this.ptbTANG2.Size = new System.Drawing.Size(1910, 605);
            this.ptbTANG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTANG2.TabIndex = 0;
            this.ptbTANG2.TabStop = false;
            this.ptbTANG2.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbTANG2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboEnd);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.ptbTANG2);
            this.Name = "Form1";
            this.Text = "Sơ đồ tầng 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTANG2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTANG2;
        private System.Windows.Forms.ComboBox cboStart;
        private System.Windows.Forms.ComboBox cboEnd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

