namespace PracticeList4
{
    partial class Bill
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
            this.BtnRestaurant = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblItemQty = new System.Windows.Forms.Label();
            this.LblItemPrice = new System.Windows.Forms.Label();
            this.LblItemNAme = new System.Windows.Forms.Label();
            this.LblItemNo = new System.Windows.Forms.Label();
            this.LblResItemQty = new System.Windows.Forms.Label();
            this.LblResItemprice = new System.Windows.Forms.Label();
            this.LblResItemName = new System.Windows.Forms.Label();
            this.LblResItemNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRestaurant
            // 
            this.BtnRestaurant.Location = new System.Drawing.Point(635, 143);
            this.BtnRestaurant.Name = "BtnRestaurant";
            this.BtnRestaurant.Size = new System.Drawing.Size(95, 23);
            this.BtnRestaurant.TabIndex = 20;
            this.BtnRestaurant.Text = "Restaurant";
            this.BtnRestaurant.UseVisualStyleBackColor = true;
            this.BtnRestaurant.Click += new System.EventHandler(this.BtnRestaurant_Click);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(655, 104);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 21;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(655, 64);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // LblItemQty
            // 
            this.LblItemQty.AutoSize = true;
            this.LblItemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemQty.Location = new System.Drawing.Point(70, 178);
            this.LblItemQty.Name = "LblItemQty";
            this.LblItemQty.Size = new System.Drawing.Size(73, 17);
            this.LblItemQty.TabIndex = 10;
            this.LblItemQty.Text = "Item Qty:";
            // 
            // LblItemPrice
            // 
            this.LblItemPrice.AutoSize = true;
            this.LblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemPrice.Location = new System.Drawing.Point(70, 143);
            this.LblItemPrice.Name = "LblItemPrice";
            this.LblItemPrice.Size = new System.Drawing.Size(85, 17);
            this.LblItemPrice.TabIndex = 9;
            this.LblItemPrice.Text = "Item Price:";
            // 
            // LblItemNAme
            // 
            this.LblItemNAme.AutoSize = true;
            this.LblItemNAme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemNAme.Location = new System.Drawing.Point(70, 104);
            this.LblItemNAme.Name = "LblItemNAme";
            this.LblItemNAme.Size = new System.Drawing.Size(89, 17);
            this.LblItemNAme.TabIndex = 12;
            this.LblItemNAme.Text = "Item Name:";
            // 
            // LblItemNo
            // 
            this.LblItemNo.AutoSize = true;
            this.LblItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemNo.Location = new System.Drawing.Point(70, 67);
            this.LblItemNo.Name = "LblItemNo";
            this.LblItemNo.Size = new System.Drawing.Size(68, 17);
            this.LblItemNo.TabIndex = 11;
            this.LblItemNo.Text = "Item No:";
            // 
            // LblResItemQty
            // 
            this.LblResItemQty.AutoSize = true;
            this.LblResItemQty.Location = new System.Drawing.Point(168, 178);
            this.LblResItemQty.Name = "LblResItemQty";
            this.LblResItemQty.Size = new System.Drawing.Size(0, 17);
            this.LblResItemQty.TabIndex = 24;
            // 
            // LblResItemprice
            // 
            this.LblResItemprice.AutoSize = true;
            this.LblResItemprice.Location = new System.Drawing.Point(168, 143);
            this.LblResItemprice.Name = "LblResItemprice";
            this.LblResItemprice.Size = new System.Drawing.Size(0, 17);
            this.LblResItemprice.TabIndex = 23;
            // 
            // LblResItemName
            // 
            this.LblResItemName.AutoSize = true;
            this.LblResItemName.Location = new System.Drawing.Point(168, 104);
            this.LblResItemName.Name = "LblResItemName";
            this.LblResItemName.Size = new System.Drawing.Size(0, 17);
            this.LblResItemName.TabIndex = 26;
            // 
            // LblResItemNo
            // 
            this.LblResItemNo.AutoSize = true;
            this.LblResItemNo.Location = new System.Drawing.Point(168, 67);
            this.LblResItemNo.Name = "LblResItemNo";
            this.LblResItemNo.Size = new System.Drawing.Size(0, 17);
            this.LblResItemNo.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 317);
            this.dataGridView1.TabIndex = 27;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblResItemQty);
            this.Controls.Add(this.LblResItemprice);
            this.Controls.Add(this.LblResItemName);
            this.Controls.Add(this.LblResItemNo);
            this.Controls.Add(this.BtnRestaurant);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblItemQty);
            this.Controls.Add(this.LblItemPrice);
            this.Controls.Add(this.LblItemNAme);
            this.Controls.Add(this.LblItemNo);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRestaurant;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblItemQty;
        private System.Windows.Forms.Label LblItemPrice;
        private System.Windows.Forms.Label LblItemNAme;
        private System.Windows.Forms.Label LblItemNo;
        private System.Windows.Forms.Label LblResItemQty;
        private System.Windows.Forms.Label LblResItemprice;
        private System.Windows.Forms.Label LblResItemName;
        private System.Windows.Forms.Label LblResItemNo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}