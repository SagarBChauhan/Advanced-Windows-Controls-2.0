namespace PracticeList4
{
    partial class JobMaster
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
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.dataGridViewJobMAster = new System.Windows.Forms.DataGridView();
            this.COmboTypeOfJOb = new System.Windows.Forms.ComboBox();
            this.TxtVehicleNo = new System.Windows.Forms.TextBox();
            this.TxtJobDesc = new System.Windows.Forms.TextBox();
            this.LblDeliveryDate = new System.Windows.Forms.Label();
            this.LblEnteryDate = new System.Windows.Forms.Label();
            this.TxtJobno = new System.Windows.Forms.TextBox();
            this.LblTypeOfJob = new System.Windows.Forms.Label();
            this.LblJobDesc = new System.Windows.Forms.Label();
            this.LblAttend = new System.Windows.Forms.Label();
            this.LblVehicleNo = new System.Windows.Forms.Label();
            this.LblJobNo = new System.Windows.Forms.Label();
            this.dateTimePickerEntry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDelivery = new System.Windows.Forms.DateTimePicker();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.groupBoxAttend = new System.Windows.Forms.GroupBox();
            this.BtnFetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobMAster)).BeginInit();
            this.groupBoxAttend.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(588, 31);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(85, 29);
            this.BtnView.TabIndex = 8;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(588, 74);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 29);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(526, 185);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 29);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(392, 185);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(85, 29);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(95, 185);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(85, 29);
            this.BtnInsert.TabIndex = 7;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // dataGridViewJobMAster
            // 
            this.dataGridViewJobMAster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobMAster.Location = new System.Drawing.Point(35, 231);
            this.dataGridViewJobMAster.Name = "dataGridViewJobMAster";
            this.dataGridViewJobMAster.Size = new System.Drawing.Size(638, 333);
            this.dataGridViewJobMAster.TabIndex = 54;
            this.dataGridViewJobMAster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewJobMAster_MouseClick);
            // 
            // COmboTypeOfJOb
            // 
            this.COmboTypeOfJOb.FormattingEnabled = true;
            this.COmboTypeOfJOb.Items.AddRange(new object[] {
            "accident",
            "service",
            "color"});
            this.COmboTypeOfJOb.Location = new System.Drawing.Point(452, 70);
            this.COmboTypeOfJOb.Name = "COmboTypeOfJOb";
            this.COmboTypeOfJOb.Size = new System.Drawing.Size(117, 24);
            this.COmboTypeOfJOb.TabIndex = 4;
            // 
            // TxtVehicleNo
            // 
            this.TxtVehicleNo.Location = new System.Drawing.Point(141, 77);
            this.TxtVehicleNo.Name = "TxtVehicleNo";
            this.TxtVehicleNo.Size = new System.Drawing.Size(131, 22);
            this.TxtVehicleNo.TabIndex = 1;
            // 
            // TxtJobDesc
            // 
            this.TxtJobDesc.Location = new System.Drawing.Point(141, 110);
            this.TxtJobDesc.Multiline = true;
            this.TxtJobDesc.Name = "TxtJobDesc";
            this.TxtJobDesc.Size = new System.Drawing.Size(131, 57);
            this.TxtJobDesc.TabIndex = 2;
            // 
            // LblDeliveryDate
            // 
            this.LblDeliveryDate.AutoSize = true;
            this.LblDeliveryDate.Location = new System.Drawing.Point(343, 150);
            this.LblDeliveryDate.Name = "LblDeliveryDate";
            this.LblDeliveryDate.Size = new System.Drawing.Size(97, 17);
            this.LblDeliveryDate.TabIndex = 24;
            this.LblDeliveryDate.Text = "Delivery Date:";
            // 
            // LblEnteryDate
            // 
            this.LblEnteryDate.AutoSize = true;
            this.LblEnteryDate.Location = new System.Drawing.Point(343, 113);
            this.LblEnteryDate.Name = "LblEnteryDate";
            this.LblEnteryDate.Size = new System.Drawing.Size(79, 17);
            this.LblEnteryDate.TabIndex = 28;
            this.LblEnteryDate.Text = "Entry Date:";
            // 
            // TxtJobno
            // 
            this.TxtJobno.Location = new System.Drawing.Point(141, 39);
            this.TxtJobno.Name = "TxtJobno";
            this.TxtJobno.Size = new System.Drawing.Size(131, 22);
            this.TxtJobno.TabIndex = 0;
            // 
            // LblTypeOfJob
            // 
            this.LblTypeOfJob.AutoSize = true;
            this.LblTypeOfJob.Location = new System.Drawing.Point(339, 77);
            this.LblTypeOfJob.Name = "LblTypeOfJob";
            this.LblTypeOfJob.Size = new System.Drawing.Size(83, 17);
            this.LblTypeOfJob.TabIndex = 26;
            this.LblTypeOfJob.Text = "Type of job:";
            // 
            // LblJobDesc
            // 
            this.LblJobDesc.AutoSize = true;
            this.LblJobDesc.Location = new System.Drawing.Point(32, 113);
            this.LblJobDesc.Name = "LblJobDesc";
            this.LblJobDesc.Size = new System.Drawing.Size(110, 17);
            this.LblJobDesc.TabIndex = 33;
            this.LblJobDesc.Text = "Job Description:";
            // 
            // LblAttend
            // 
            this.LblAttend.AutoSize = true;
            this.LblAttend.Location = new System.Drawing.Point(339, 44);
            this.LblAttend.Name = "LblAttend";
            this.LblAttend.Size = new System.Drawing.Size(61, 17);
            this.LblAttend.TabIndex = 34;
            this.LblAttend.Text = "Attened:";
            // 
            // LblVehicleNo
            // 
            this.LblVehicleNo.AutoSize = true;
            this.LblVehicleNo.Location = new System.Drawing.Point(32, 82);
            this.LblVehicleNo.Name = "LblVehicleNo";
            this.LblVehicleNo.Size = new System.Drawing.Size(78, 17);
            this.LblVehicleNo.TabIndex = 35;
            this.LblVehicleNo.Text = "vehicle No:";
            // 
            // LblJobNo
            // 
            this.LblJobNo.AutoSize = true;
            this.LblJobNo.Location = new System.Drawing.Point(32, 44);
            this.LblJobNo.Name = "LblJobNo";
            this.LblJobNo.Size = new System.Drawing.Size(57, 17);
            this.LblJobNo.TabIndex = 32;
            this.LblJobNo.Text = "Job No:";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntry.Location = new System.Drawing.Point(452, 108);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(117, 22);
            this.dateTimePickerEntry.TabIndex = 5;
            this.dateTimePickerEntry.ValueChanged += new System.EventHandler(this.dateTimePickerEntry_ValueChanged);
            // 
            // dateTimePickerDelivery
            // 
            this.dateTimePickerDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDelivery.Location = new System.Drawing.Point(452, 145);
            this.dateTimePickerDelivery.Name = "dateTimePickerDelivery";
            this.dateTimePickerDelivery.Size = new System.Drawing.Size(119, 22);
            this.dateTimePickerDelivery.TabIndex = 6;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(6, 11);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(53, 21);
            this.radioButtonYes.TabIndex = 0;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Location = new System.Drawing.Point(65, 11);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(47, 21);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.TabStop = true;
            this.radioButtonNO.Text = "No";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // groupBoxAttend
            // 
            this.groupBoxAttend.Controls.Add(this.radioButtonYes);
            this.groupBoxAttend.Controls.Add(this.radioButtonNO);
            this.groupBoxAttend.Location = new System.Drawing.Point(452, 24);
            this.groupBoxAttend.Name = "groupBoxAttend";
            this.groupBoxAttend.Size = new System.Drawing.Size(117, 37);
            this.groupBoxAttend.TabIndex = 3;
            this.groupBoxAttend.TabStop = false;
            // 
            // BtnFetch
            // 
            this.BtnFetch.Location = new System.Drawing.Point(247, 185);
            this.BtnFetch.Name = "BtnFetch";
            this.BtnFetch.Size = new System.Drawing.Size(85, 29);
            this.BtnFetch.TabIndex = 55;
            this.BtnFetch.Text = "Fetch";
            this.BtnFetch.UseVisualStyleBackColor = true;
            this.BtnFetch.Click += new System.EventHandler(this.BtnFetch_Click);
            // 
            // JobMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 600);
            this.Controls.Add(this.BtnFetch);
            this.Controls.Add(this.groupBoxAttend);
            this.Controls.Add(this.dateTimePickerDelivery);
            this.Controls.Add(this.dateTimePickerEntry);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.dataGridViewJobMAster);
            this.Controls.Add(this.COmboTypeOfJOb);
            this.Controls.Add(this.TxtVehicleNo);
            this.Controls.Add(this.TxtJobDesc);
            this.Controls.Add(this.LblDeliveryDate);
            this.Controls.Add(this.LblEnteryDate);
            this.Controls.Add(this.TxtJobno);
            this.Controls.Add(this.LblTypeOfJob);
            this.Controls.Add(this.LblJobDesc);
            this.Controls.Add(this.LblAttend);
            this.Controls.Add(this.LblVehicleNo);
            this.Controls.Add(this.LblJobNo);
            this.Name = "JobMaster";
            this.Text = "JobMaster";
            this.Load += new System.EventHandler(this.JobMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobMAster)).EndInit();
            this.groupBoxAttend.ResumeLayout(false);
            this.groupBoxAttend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.DataGridView dataGridViewJobMAster;
        private System.Windows.Forms.ComboBox COmboTypeOfJOb;
        private System.Windows.Forms.TextBox TxtVehicleNo;
        private System.Windows.Forms.TextBox TxtJobDesc;
        private System.Windows.Forms.Label LblDeliveryDate;
        private System.Windows.Forms.Label LblEnteryDate;
        private System.Windows.Forms.TextBox TxtJobno;
        private System.Windows.Forms.Label LblTypeOfJob;
        private System.Windows.Forms.Label LblJobDesc;
        private System.Windows.Forms.Label LblAttend;
        private System.Windows.Forms.Label LblVehicleNo;
        private System.Windows.Forms.Label LblJobNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerDelivery;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.GroupBox groupBoxAttend;
        private System.Windows.Forms.Button BtnFetch;
    }
}