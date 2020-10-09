namespace PracticeList4
{
    partial class Leave
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
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblNoOfDay = new System.Windows.Forms.Label();
            this.TxtParentsName = new System.Windows.Forms.TextBox();
            this.TxtCoName = new System.Windows.Forms.TextBox();
            this.LblPerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tXTeNnO = new System.Windows.Forms.TextBox();
            this.LblEnN = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TxtLN = new System.Windows.Forms.TextBox();
            this.TxtFN = new System.Windows.Forms.TextBox();
            this.LblLN = new System.Windows.Forms.Label();
            this.LblReason = new System.Windows.Forms.Label();
            this.LblToDAte = new System.Windows.Forms.Label();
            this.LblFN = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.RichTextBox();
            this.ComboNoOfDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.AllowDrop = true;
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(525, 63);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerStartDate.TabIndex = 6;
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.Location = new System.Drawing.Point(394, 63);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(88, 17);
            this.LblStartDate.TabIndex = 122;
            this.LblStartDate.Text = "From Date:";
            // 
            // LblNoOfDay
            // 
            this.LblNoOfDay.AutoSize = true;
            this.LblNoOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoOfDay.Location = new System.Drawing.Point(393, 29);
            this.LblNoOfDay.Name = "LblNoOfDay";
            this.LblNoOfDay.Size = new System.Drawing.Size(93, 17);
            this.LblNoOfDay.TabIndex = 118;
            this.LblNoOfDay.Text = "No of Days:";
            // 
            // TxtParentsName
            // 
            this.TxtParentsName.Location = new System.Drawing.Point(155, 182);
            this.TxtParentsName.Name = "TxtParentsName";
            this.TxtParentsName.Size = new System.Drawing.Size(186, 22);
            this.TxtParentsName.TabIndex = 4;
            // 
            // TxtCoName
            // 
            this.TxtCoName.Location = new System.Drawing.Point(156, 145);
            this.TxtCoName.Name = "TxtCoName";
            this.TxtCoName.Size = new System.Drawing.Size(186, 22);
            this.TxtCoName.TabIndex = 3;
            // 
            // LblPerName
            // 
            this.LblPerName.AutoSize = true;
            this.LblPerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPerName.Location = new System.Drawing.Point(23, 187);
            this.LblPerName.Name = "LblPerName";
            this.LblPerName.Size = new System.Drawing.Size(115, 17);
            this.LblPerName.TabIndex = 110;
            this.LblPerName.Text = "Parents Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Counselor Name:";
            // 
            // tXTeNnO
            // 
            this.tXTeNnO.Location = new System.Drawing.Point(156, 106);
            this.tXTeNnO.Name = "tXTeNnO";
            this.tXTeNnO.Size = new System.Drawing.Size(186, 22);
            this.tXTeNnO.TabIndex = 2;
            // 
            // LblEnN
            // 
            this.LblEnN.AutoSize = true;
            this.LblEnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnN.Location = new System.Drawing.Point(24, 111);
            this.LblEnN.Name = "LblEnN";
            this.LblEnN.Size = new System.Drawing.Size(93, 17);
            this.LblEnN.TabIndex = 106;
            this.LblEnN.Text = "En Number:";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(318, 246);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(104, 34);
            this.BtnSubmit.TabIndex = 9;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDatePicker.Location = new System.Drawing.Point(525, 101);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(187, 22);
            this.ToDatePicker.TabIndex = 7;
            // 
            // TxtLN
            // 
            this.TxtLN.Location = new System.Drawing.Point(156, 66);
            this.TxtLN.Name = "TxtLN";
            this.TxtLN.Size = new System.Drawing.Size(186, 22);
            this.TxtLN.TabIndex = 1;
            // 
            // TxtFN
            // 
            this.TxtFN.Location = new System.Drawing.Point(155, 29);
            this.TxtFN.Name = "TxtFN";
            this.TxtFN.Size = new System.Drawing.Size(186, 22);
            this.TxtFN.TabIndex = 0;
            // 
            // LblLN
            // 
            this.LblLN.AutoSize = true;
            this.LblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLN.Location = new System.Drawing.Point(24, 71);
            this.LblLN.Name = "LblLN";
            this.LblLN.Size = new System.Drawing.Size(95, 17);
            this.LblLN.TabIndex = 98;
            this.LblLN.Text = "Last Name: ";
            // 
            // LblReason
            // 
            this.LblReason.AutoSize = true;
            this.LblReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReason.Location = new System.Drawing.Point(394, 145);
            this.LblReason.Name = "LblReason";
            this.LblReason.Size = new System.Drawing.Size(68, 17);
            this.LblReason.TabIndex = 93;
            this.LblReason.Text = "Reason:";
            // 
            // LblToDAte
            // 
            this.LblToDAte.AutoSize = true;
            this.LblToDAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToDAte.Location = new System.Drawing.Point(394, 101);
            this.LblToDAte.Name = "LblToDAte";
            this.LblToDAte.Size = new System.Drawing.Size(71, 17);
            this.LblToDAte.TabIndex = 94;
            this.LblToDAte.Text = "To Date:";
            // 
            // LblFN
            // 
            this.LblFN.AutoSize = true;
            this.LblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFN.Location = new System.Drawing.Point(23, 29);
            this.LblFN.Name = "LblFN";
            this.LblFN.Size = new System.Drawing.Size(96, 17);
            this.LblFN.TabIndex = 91;
            this.LblFN.Text = "FIrst Name: ";
            // 
            // TxtReason
            // 
            this.TxtReason.Location = new System.Drawing.Point(521, 145);
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.Size = new System.Drawing.Size(191, 57);
            this.TxtReason.TabIndex = 8;
            this.TxtReason.Text = "";
            // 
            // ComboNoOfDay
            // 
            this.ComboNoOfDay.FormattingEnabled = true;
            this.ComboNoOfDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ComboNoOfDay.Location = new System.Drawing.Point(525, 22);
            this.ComboNoOfDay.Name = "ComboNoOfDay";
            this.ComboNoOfDay.Size = new System.Drawing.Size(186, 24);
            this.ComboNoOfDay.TabIndex = 5;
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 319);
            this.Controls.Add(this.ComboNoOfDay);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.LblNoOfDay);
            this.Controls.Add(this.TxtParentsName);
            this.Controls.Add(this.TxtCoName);
            this.Controls.Add(this.LblPerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tXTeNnO);
            this.Controls.Add(this.LblEnN);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.TxtLN);
            this.Controls.Add(this.TxtFN);
            this.Controls.Add(this.LblLN);
            this.Controls.Add(this.LblReason);
            this.Controls.Add(this.LblToDAte);
            this.Controls.Add(this.LblFN);
            this.Name = "Leave";
            this.Text = "Leave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblNoOfDay;
        private System.Windows.Forms.TextBox TxtParentsName;
        private System.Windows.Forms.TextBox TxtCoName;
        private System.Windows.Forms.Label LblPerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tXTeNnO;
        private System.Windows.Forms.Label LblEnN;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.DateTimePicker ToDatePicker;
        private System.Windows.Forms.TextBox TxtLN;
        private System.Windows.Forms.TextBox TxtFN;
        private System.Windows.Forms.Label LblLN;
        private System.Windows.Forms.Label LblReason;
        private System.Windows.Forms.Label LblToDAte;
        private System.Windows.Forms.Label LblFN;
        private System.Windows.Forms.RichTextBox TxtReason;
        private System.Windows.Forms.ComboBox ComboNoOfDay;
    }
}