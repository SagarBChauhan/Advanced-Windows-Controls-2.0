namespace PracticeList4
{
    partial class medicines
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVIEW = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.TxtReorderleval = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Lblsell_price = new System.Windows.Forms.Label();
            this.Lblreorder_level = new System.Windows.Forms.Label();
            this.LblQty = new System.Windows.Forms.Label();
            this.LblProfitPercentage = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblMedicineNo = new System.Windows.Forms.Label();
            this.TxtMedicineNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComboKey = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 286);
            this.dataGridView1.TabIndex = 51;
            // 
            // btnVIEW
            // 
            this.btnVIEW.Location = new System.Drawing.Point(602, 168);
            this.btnVIEW.Name = "btnVIEW";
            this.btnVIEW.Size = new System.Drawing.Size(111, 31);
            this.btnVIEW.TabIndex = 50;
            this.btnVIEW.Text = "VIEW";
            this.btnVIEW.UseVisualStyleBackColor = true;
            this.btnVIEW.Click += new System.EventHandler(this.btnVIEW_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(470, 168);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(111, 31);
            this.BtnSearch.TabIndex = 49;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(153, 168);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(111, 31);
            this.BtnRemove.TabIndex = 48;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 168);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(111, 31);
            this.BtnAdd.TabIndex = 47;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(556, 100);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(157, 22);
            this.TxtSellPrice.TabIndex = 46;
            // 
            // TxtReorderleval
            // 
            this.TxtReorderleval.Location = new System.Drawing.Point(556, 59);
            this.TxtReorderleval.Name = "TxtReorderleval";
            this.TxtReorderleval.Size = new System.Drawing.Size(157, 22);
            this.TxtReorderleval.TabIndex = 44;
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(556, 22);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(157, 22);
            this.TxtQty.TabIndex = 43;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(153, 64);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(157, 22);
            this.TxtName.TabIndex = 41;
            // 
            // Lblsell_price
            // 
            this.Lblsell_price.AutoSize = true;
            this.Lblsell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsell_price.Location = new System.Drawing.Point(412, 105);
            this.Lblsell_price.Name = "Lblsell_price";
            this.Lblsell_price.Size = new System.Drawing.Size(79, 17);
            this.Lblsell_price.TabIndex = 36;
            this.Lblsell_price.Text = "sell price:";
            // 
            // Lblreorder_level
            // 
            this.Lblreorder_level.AutoSize = true;
            this.Lblreorder_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblreorder_level.Location = new System.Drawing.Point(412, 64);
            this.Lblreorder_level.Name = "Lblreorder_level";
            this.Lblreorder_level.Size = new System.Drawing.Size(106, 17);
            this.Lblreorder_level.TabIndex = 34;
            this.Lblreorder_level.Text = "reorder level:";
            // 
            // LblQty
            // 
            this.LblQty.AutoSize = true;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(412, 27);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(74, 17);
            this.LblQty.TabIndex = 39;
            this.LblQty.Text = "Quantity:";
            // 
            // LblProfitPercentage
            // 
            this.LblProfitPercentage.AutoSize = true;
            this.LblProfitPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfitPercentage.Location = new System.Drawing.Point(9, 107);
            this.LblProfitPercentage.Name = "LblProfitPercentage";
            this.LblProfitPercentage.Size = new System.Drawing.Size(96, 17);
            this.LblProfitPercentage.TabIndex = 40;
            this.LblProfitPercentage.Text = "Expiry Date:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(9, 64);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(54, 17);
            this.LblName.TabIndex = 37;
            this.LblName.Text = "Name:";
            // 
            // LblMedicineNo
            // 
            this.LblMedicineNo.AutoSize = true;
            this.LblMedicineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedicineNo.Location = new System.Drawing.Point(9, 27);
            this.LblMedicineNo.Name = "LblMedicineNo";
            this.LblMedicineNo.Size = new System.Drawing.Size(102, 17);
            this.LblMedicineNo.TabIndex = 38;
            this.LblMedicineNo.Text = "Medicine No:";
            // 
            // TxtMedicineNo
            // 
            this.TxtMedicineNo.Location = new System.Drawing.Point(153, 27);
            this.TxtMedicineNo.Name = "TxtMedicineNo";
            this.TxtMedicineNo.Size = new System.Drawing.Size(157, 22);
            this.TxtMedicineNo.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // ComboKey
            // 
            this.ComboKey.FormattingEnabled = true;
            this.ComboKey.Items.AddRange(new object[] {
            "Out of stock",
            "Expired"});
            this.ComboKey.Location = new System.Drawing.Point(326, 172);
            this.ComboKey.Name = "ComboKey";
            this.ComboKey.Size = new System.Drawing.Size(121, 24);
            this.ComboKey.TabIndex = 53;
            this.ComboKey.DockChanged += new System.EventHandler(this.ComboKey_DockChanged);
            // 
            // medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 511);
            this.Controls.Add(this.ComboKey);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVIEW);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtSellPrice);
            this.Controls.Add(this.TxtReorderleval);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtMedicineNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Lblsell_price);
            this.Controls.Add(this.Lblreorder_level);
            this.Controls.Add(this.LblQty);
            this.Controls.Add(this.LblProfitPercentage);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblMedicineNo);
            this.Name = "medicines";
            this.Text = "medicines";
            this.Load += new System.EventHandler(this.medicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVIEW;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.TextBox TxtReorderleval;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label Lblsell_price;
        private System.Windows.Forms.Label Lblreorder_level;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label LblProfitPercentage;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblMedicineNo;
        private System.Windows.Forms.TextBox TxtMedicineNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboKey;
    }
}