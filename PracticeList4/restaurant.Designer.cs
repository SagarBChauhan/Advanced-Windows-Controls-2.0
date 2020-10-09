namespace PracticeList4
{
    partial class restaurant
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
            this.LblItemNo = new System.Windows.Forms.Label();
            this.LblItemNAme = new System.Windows.Forms.Label();
            this.LblItemPrice = new System.Windows.Forms.Label();
            this.LblItemQty = new System.Windows.Forms.Label();
            this.TxtNo = new System.Windows.Forms.TextBox();
            this.TxtNAme = new System.Windows.Forms.TextBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblItemNo
            // 
            this.LblItemNo.AutoSize = true;
            this.LblItemNo.Location = new System.Drawing.Point(30, 34);
            this.LblItemNo.Name = "LblItemNo";
            this.LblItemNo.Size = new System.Drawing.Size(60, 17);
            this.LblItemNo.TabIndex = 0;
            this.LblItemNo.Text = "Item No:";
            // 
            // LblItemNAme
            // 
            this.LblItemNAme.AutoSize = true;
            this.LblItemNAme.Location = new System.Drawing.Point(30, 71);
            this.LblItemNAme.Name = "LblItemNAme";
            this.LblItemNAme.Size = new System.Drawing.Size(79, 17);
            this.LblItemNAme.TabIndex = 0;
            this.LblItemNAme.Text = "Item Name:";
            // 
            // LblItemPrice
            // 
            this.LblItemPrice.AutoSize = true;
            this.LblItemPrice.Location = new System.Drawing.Point(30, 110);
            this.LblItemPrice.Name = "LblItemPrice";
            this.LblItemPrice.Size = new System.Drawing.Size(74, 17);
            this.LblItemPrice.TabIndex = 0;
            this.LblItemPrice.Text = "Item Price:";
            // 
            // LblItemQty
            // 
            this.LblItemQty.AutoSize = true;
            this.LblItemQty.Location = new System.Drawing.Point(30, 145);
            this.LblItemQty.Name = "LblItemQty";
            this.LblItemQty.Size = new System.Drawing.Size(64, 17);
            this.LblItemQty.TabIndex = 0;
            this.LblItemQty.Text = "Item Qty:";
            // 
            // TxtNo
            // 
            this.TxtNo.Location = new System.Drawing.Point(139, 29);
            this.TxtNo.Name = "TxtNo";
            this.TxtNo.Size = new System.Drawing.Size(100, 22);
            this.TxtNo.TabIndex = 1;
            // 
            // TxtNAme
            // 
            this.TxtNAme.Location = new System.Drawing.Point(139, 66);
            this.TxtNAme.Name = "TxtNAme";
            this.TxtNAme.Size = new System.Drawing.Size(100, 22);
            this.TxtNAme.TabIndex = 2;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(139, 105);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(100, 22);
            this.TxtPrice.TabIndex = 3;
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(139, 140);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(100, 22);
            this.TxtQty.TabIndex = 4;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(33, 189);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(153, 189);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(270, 189);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(270, 28);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(270, 65);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 8;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnBill
            // 
            this.BtnBill.Location = new System.Drawing.Point(270, 104);
            this.BtnBill.Name = "BtnBill";
            this.BtnBill.Size = new System.Drawing.Size(75, 23);
            this.BtnBill.TabIndex = 8;
            this.BtnBill.Text = "Bill";
            this.BtnBill.UseVisualStyleBackColor = true;
            this.BtnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 419);
            this.Controls.Add(this.BtnBill);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtNAme);
            this.Controls.Add(this.TxtNo);
            this.Controls.Add(this.LblItemQty);
            this.Controls.Add(this.LblItemPrice);
            this.Controls.Add(this.LblItemNAme);
            this.Controls.Add(this.LblItemNo);
            this.Name = "restaurant";
            this.Text = "restaurant";
            this.Load += new System.EventHandler(this.restaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblItemNo;
        private System.Windows.Forms.Label LblItemNAme;
        private System.Windows.Forms.Label LblItemPrice;
        private System.Windows.Forms.Label LblItemQty;
        private System.Windows.Forms.TextBox TxtNo;
        private System.Windows.Forms.TextBox TxtNAme;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnBill;
    }
}