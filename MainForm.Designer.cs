namespace StudentApp
{
    partial class MainForm
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tbGrade = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.lstGrade = new System.Windows.Forms.ListBox();
            this.tbControl.SuspendLayout();
            this.tbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tbGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbInfo);
            this.tbControl.Controls.Add(this.tbGrade);
            this.tbControl.Location = new System.Drawing.Point(37, 14);
            this.tbControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(949, 616);
            this.tbControl.TabIndex = 0;
            this.tbControl.Click += new System.EventHandler(this.tbControl_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.grdData);
            this.tbInfo.Controls.Add(this.btnInsert);
            this.tbInfo.Controls.Add(this.btnDisplay);
            this.tbInfo.Controls.Add(this.lblScore);
            this.tbInfo.Controls.Add(this.lblName);
            this.tbInfo.Controls.Add(this.lblID);
            this.tbInfo.Controls.Add(this.txtScore);
            this.tbInfo.Controls.Add(this.txtName);
            this.tbInfo.Controls.Add(this.txtID);
            this.tbInfo.Location = new System.Drawing.Point(4, 24);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInfo.Size = new System.Drawing.Size(941, 588);
            this.tbInfo.TabIndex = 0;
            this.tbInfo.Text = "Student Info";
            this.tbInfo.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(388, 78);
            this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(470, 353);
            this.grdData.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(246, 208);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(73, 27);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(150, 208);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(74, 27);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(80, 162);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(36, 15);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 119);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(80, 78);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Student ID";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(150, 153);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(169, 30);
            this.txtScore.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(150, 71);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 32);
            this.txtID.TabIndex = 0;
            // 
            // tbGrade
            // 
            this.tbGrade.Controls.Add(this.btnExport);
            this.tbGrade.Controls.Add(this.lstGrade);
            this.tbGrade.Location = new System.Drawing.Point(4, 24);
            this.tbGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGrade.Size = new System.Drawing.Size(941, 588);
            this.tbGrade.TabIndex = 1;
            this.tbGrade.Text = "Student Grade";
            this.tbGrade.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(111, 44);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(183, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lstGrade
            // 
            this.lstGrade.FormattingEnabled = true;
            this.lstGrade.ItemHeight = 15;
            this.lstGrade.Location = new System.Drawing.Point(302, 44);
            this.lstGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstGrade.Name = "lstGrade";
            this.lstGrade.Size = new System.Drawing.Size(507, 349);
            this.lstGrade.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 644);
            this.Controls.Add(this.tbControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Student Grade";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tbControl.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            this.tbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tbGrade.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.TabPage tbGrade;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.ListBox lstGrade;
        private System.Windows.Forms.Button btnExport;
    }
}

