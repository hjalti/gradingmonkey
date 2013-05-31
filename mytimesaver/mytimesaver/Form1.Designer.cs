namespace Mytimesaver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbHeader = new System.Windows.Forms.CheckBox();
            this.txtGradeCol = new System.Windows.Forms.TextBox();
            this.txtCommentCol = new System.Windows.Forms.TextBox();
            this.txtKennitala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmbGradeType = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 213);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.cbHeader);
            this.groupBox1.Controls.Add(this.txtGradeCol);
            this.groupBox1.Controls.Add(this.txtCommentCol);
            this.groupBox1.Controls.Add(this.txtKennitala);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSkip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.cmbGradeType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.Location = new System.Drawing.Point(509, 181);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 14;
            this.btnParse.Text = "Magic!";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(511, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(26, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbHeader
            // 
            this.cbHeader.AutoSize = true;
            this.cbHeader.Checked = true;
            this.cbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeader.Location = new System.Drawing.Point(15, 185);
            this.cbHeader.Name = "cbHeader";
            this.cbHeader.Size = new System.Drawing.Size(61, 17);
            this.cbHeader.TabIndex = 12;
            this.cbHeader.Text = "Header";
            this.cbHeader.UseVisualStyleBackColor = true;
            // 
            // txtGradeCol
            // 
            this.txtGradeCol.Location = new System.Drawing.Point(106, 107);
            this.txtGradeCol.Name = "txtGradeCol";
            this.txtGradeCol.Size = new System.Drawing.Size(39, 20);
            this.txtGradeCol.TabIndex = 7;
            this.txtGradeCol.Text = "1";
            // 
            // txtCommentCol
            // 
            this.txtCommentCol.Location = new System.Drawing.Point(106, 133);
            this.txtCommentCol.Name = "txtCommentCol";
            this.txtCommentCol.Size = new System.Drawing.Size(39, 20);
            this.txtCommentCol.TabIndex = 11;
            // 
            // txtKennitala
            // 
            this.txtKennitala.Location = new System.Drawing.Point(106, 81);
            this.txtKennitala.Name = "txtKennitala";
            this.txtKennitala.Size = new System.Drawing.Size(39, 20);
            this.txtKennitala.TabIndex = 6;
            this.txtKennitala.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comment column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grade column";
            // 
            // txtSkip
            // 
            this.txtSkip.Location = new System.Drawing.Point(106, 159);
            this.txtSkip.Name = "txtSkip";
            this.txtSkip.Size = new System.Drawing.Size(39, 20);
            this.txtSkip.TabIndex = 8;
            this.txtSkip.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kennitala column";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Skip lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type of grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name (csv)";
            // 
            // txtFileName
            // 
            this.txtFileName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFileName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFileName.Location = new System.Drawing.Point(106, 28);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(399, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // cmbGradeType
            // 
            this.cmbGradeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradeType.FormattingEnabled = true;
            this.cmbGradeType.Location = new System.Drawing.Point(106, 54);
            this.cmbGradeType.Name = "cmbGradeType";
            this.cmbGradeType.Size = new System.Drawing.Size(121, 21);
            this.cmbGradeType.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(3, 216);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(590, 348);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 567);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "GradingMonkey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox cbHeader;
        private System.Windows.Forms.TextBox txtGradeCol;
        private System.Windows.Forms.TextBox txtCommentCol;
        private System.Windows.Forms.TextBox txtKennitala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cmbGradeType;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

