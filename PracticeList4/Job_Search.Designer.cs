namespace PracticeList4
{
    partial class Job_Search
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewJobMAster = new System.Windows.Forms.DataGridView();
            this.COmboTypeOfJOb = new System.Windows.Forms.ComboBox();
            this.TxtVehicleNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobMAster)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(683, 185);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(85, 29);
            this.BtnSearch.TabIndex = 57;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(487, 296);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(85, 29);
            this.BtnUpdate.TabIndex = 58;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewJobMAster
            // 
            this.dataGridViewJobMAster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobMAster.Location = new System.Drawing.Point(130, 342);
            this.dataGridViewJobMAster.Name = "dataGridViewJobMAster";
            this.dataGridViewJobMAster.Size = new System.Drawing.Size(638, 333);
            this.dataGridViewJobMAster.TabIndex = 59;
            // 
            // COmboTypeOfJOb
            // 
            this.COmboTypeOfJOb.FormattingEnabled = true;
            this.COmboTypeOfJOb.Items.AddRange(new object[] {
            "accident",
            "service",
            "color"});
            this.COmboTypeOfJOb.Location = new System.Drawing.Point(547, 181);
            this.COmboTypeOfJOb.Name = "COmboTypeOfJOb";
            this.COmboTypeOfJOb.Size = new System.Drawing.Size(117, 24);
            this.COmboTypeOfJOb.TabIndex = 56;
            // 
            // TxtVehicleNo
            // 
            this.TxtVehicleNo.Location = new System.Drawing.Point(236, 188);
            this.TxtVehicleNo.Name = "TxtVehicleNo";
            this.TxtVehicleNo.Size = new System.Drawing.Size(131, 22);
            this.TxtVehicleNo.TabIndex = 55;
            // 
            // Job_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 760);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.dataGridViewJobMAster);
            this.Controls.Add(this.COmboTypeOfJOb);
            this.Controls.Add(this.TxtVehicleNo);
            this.Name = "Job_Search";
            this.Text = "Job_Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobMAster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewJobMAster;
        private System.Windows.Forms.ComboBox COmboTypeOfJOb;
        private System.Windows.Forms.TextBox TxtVehicleNo;
    }
}