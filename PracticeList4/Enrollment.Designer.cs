namespace PracticeList4
{
    partial class Enrollment
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
            this.ComboNoOfDay = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDuration = new System.Windows.Forms.Label();
            this.LblAmt = new System.Windows.Forms.Label();
            this.LblEnN = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtFN = new System.Windows.Forms.TextBox();
            this.LblCourse = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MaskTxtAmt = new System.Windows.Forms.MaskedTextBox();
            this.MAskTxtENroll = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ComboNoOfDay
            // 
            this.ComboNoOfDay.FormattingEnabled = true;
            this.ComboNoOfDay.Items.AddRange(new object[] {
            "1 Year",
            "2 Year",
            "3 Year",
            "4 Year",
            "5 Year",
            "6 Year",
            "7 Year",
            "8 Year",
            "9 Year",
            "10 Year"});
            this.ComboNoOfDay.Location = new System.Drawing.Point(193, 154);
            this.ComboNoOfDay.Name = "ComboNoOfDay";
            this.ComboNoOfDay.Size = new System.Drawing.Size(186, 24);
            this.ComboNoOfDay.TabIndex = 3;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.AllowDrop = true;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(193, 232);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(46, 232);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(47, 17);
            this.LblDate.TabIndex = 141;
            this.LblDate.Text = "Date:";
            // 
            // LblDuration
            // 
            this.LblDuration.AutoSize = true;
            this.LblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuration.Location = new System.Drawing.Point(46, 159);
            this.LblDuration.Name = "LblDuration";
            this.LblDuration.Size = new System.Drawing.Size(75, 17);
            this.LblDuration.TabIndex = 140;
            this.LblDuration.Text = "Duration:";
            // 
            // LblAmt
            // 
            this.LblAmt.AutoSize = true;
            this.LblAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmt.Location = new System.Drawing.Point(46, 197);
            this.LblAmt.Name = "LblAmt";
            this.LblAmt.Size = new System.Drawing.Size(143, 17);
            this.LblAmt.TabIndex = 139;
            this.LblAmt.Text = "Fees Amount paid:";
            // 
            // LblEnN
            // 
            this.LblEnN.AutoSize = true;
            this.LblEnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnN.Location = new System.Drawing.Point(46, 53);
            this.LblEnN.Name = "LblEnN";
            this.LblEnN.Size = new System.Drawing.Size(93, 17);
            this.LblEnN.TabIndex = 137;
            this.LblEnN.Text = "En Number:";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(117, 278);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(72, 34);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtFN
            // 
            this.TxtFN.Location = new System.Drawing.Point(193, 82);
            this.TxtFN.Name = "TxtFN";
            this.TxtFN.Size = new System.Drawing.Size(186, 22);
            this.TxtFN.TabIndex = 1;
            // 
            // LblCourse
            // 
            this.LblCourse.AutoSize = true;
            this.LblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCourse.Location = new System.Drawing.Point(46, 124);
            this.LblCourse.Name = "LblCourse";
            this.LblCourse.Size = new System.Drawing.Size(64, 17);
            this.LblCourse.TabIndex = 136;
            this.LblCourse.Text = "Course:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(46, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 17);
            this.LblName.TabIndex = 133;
            this.LblName.Text = "Name: ";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(409, 107);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 34);
            this.BtnUpdate.TabIndex = 132;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(409, 162);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(72, 34);
            this.BtnDelete.TabIndex = 132;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(233, 278);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(72, 34);
            this.BtnReset.TabIndex = 7;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(409, 48);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(72, 34);
            this.BtnSearch.TabIndex = 132;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BscIT",
            "MscIt",
            "Architacture",
            "Physiyo",
            "Physics",
            "Bsc Chemistry",
            "Bio-Thech"});
            this.comboBox1.Location = new System.Drawing.Point(193, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // MaskTxtAmt
            // 
            this.MaskTxtAmt.Location = new System.Drawing.Point(193, 194);
            this.MaskTxtAmt.Mask = "000000.00";
            this.MaskTxtAmt.Name = "MaskTxtAmt";
            this.MaskTxtAmt.Size = new System.Drawing.Size(187, 22);
            this.MaskTxtAmt.TabIndex = 4;
            // 
            // MAskTxtENroll
            // 
            this.MAskTxtENroll.Location = new System.Drawing.Point(192, 48);
            this.MAskTxtENroll.Mask = "000000000000000";
            this.MAskTxtENroll.Name = "MAskTxtENroll";
            this.MAskTxtENroll.Size = new System.Drawing.Size(187, 22);
            this.MAskTxtENroll.TabIndex = 0;
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 359);
            this.Controls.Add(this.MAskTxtENroll);
            this.Controls.Add(this.MaskTxtAmt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ComboNoOfDay);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblDuration);
            this.Controls.Add(this.LblAmt);
            this.Controls.Add(this.LblEnN);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.TxtFN);
            this.Controls.Add(this.LblCourse);
            this.Controls.Add(this.LblName);
            this.Name = "Enrollment";
            this.Text = "Enrollment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboNoOfDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDuration;
        private System.Windows.Forms.Label LblAmt;
        private System.Windows.Forms.Label LblEnN;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtFN;
        private System.Windows.Forms.Label LblCourse;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox MaskTxtAmt;
        private System.Windows.Forms.MaskedTextBox MAskTxtENroll;
    }
}