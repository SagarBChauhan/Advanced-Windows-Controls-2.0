namespace PracticeList4
{
    partial class Product
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
            this.LblProductNo = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblProfitPercentage = new System.Windows.Forms.Label();
            this.LblQtyOnHand = new System.Windows.Forms.Label();
            this.Lblreorder_level = new System.Windows.Forms.Label();
            this.Lblcost_price = new System.Windows.Forms.Label();
            this.Lblsell_price = new System.Windows.Forms.Label();
            this.maskedTextBoxProdNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtDescreption = new System.Windows.Forms.TextBox();
            this.TxtProfitPer = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtReorderleval = new System.Windows.Forms.TextBox();
            this.TxtCostPrice = new System.Windows.Forms.TextBox();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.btnVIEW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductNo
            // 
            this.LblProductNo.AutoSize = true;
            this.LblProductNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductNo.Location = new System.Drawing.Point(122, 35);
            this.LblProductNo.Name = "LblProductNo";
            this.LblProductNo.Size = new System.Drawing.Size(92, 17);
            this.LblProductNo.TabIndex = 0;
            this.LblProductNo.Text = "Product no:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(122, 72);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(93, 17);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "description:";
            // 
            // LblProfitPercentage
            // 
            this.LblProfitPercentage.AutoSize = true;
            this.LblProfitPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfitPercentage.Location = new System.Drawing.Point(122, 145);
            this.LblProfitPercentage.Name = "LblProfitPercentage";
            this.LblProfitPercentage.Size = new System.Drawing.Size(111, 17);
            this.LblProfitPercentage.TabIndex = 0;
            this.LblProfitPercentage.Text = "profit percent:";
            // 
            // LblQtyOnHand
            // 
            this.LblQtyOnHand.AutoSize = true;
            this.LblQtyOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtyOnHand.Location = new System.Drawing.Point(573, 30);
            this.LblQtyOnHand.Name = "LblQtyOnHand";
            this.LblQtyOnHand.Size = new System.Drawing.Size(138, 17);
            this.LblQtyOnHand.TabIndex = 0;
            this.LblQtyOnHand.Text = "Quantity on hand:";
            // 
            // Lblreorder_level
            // 
            this.Lblreorder_level.AutoSize = true;
            this.Lblreorder_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblreorder_level.Location = new System.Drawing.Point(573, 63);
            this.Lblreorder_level.Name = "Lblreorder_level";
            this.Lblreorder_level.Size = new System.Drawing.Size(106, 17);
            this.Lblreorder_level.TabIndex = 0;
            this.Lblreorder_level.Text = "reorder level:";
            // 
            // Lblcost_price
            // 
            this.Lblcost_price.AutoSize = true;
            this.Lblcost_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcost_price.Location = new System.Drawing.Point(573, 101);
            this.Lblcost_price.Name = "Lblcost_price";
            this.Lblcost_price.Size = new System.Drawing.Size(84, 17);
            this.Lblcost_price.TabIndex = 0;
            this.Lblcost_price.Text = "cost price:";
            // 
            // Lblsell_price
            // 
            this.Lblsell_price.AutoSize = true;
            this.Lblsell_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsell_price.Location = new System.Drawing.Point(573, 140);
            this.Lblsell_price.Name = "Lblsell_price";
            this.Lblsell_price.Size = new System.Drawing.Size(79, 17);
            this.Lblsell_price.TabIndex = 0;
            this.Lblsell_price.Text = "sell price:";
            // 
            // maskedTextBoxProdNo
            // 
            this.maskedTextBoxProdNo.Location = new System.Drawing.Point(266, 30);
            this.maskedTextBoxProdNo.Mask = "0000000000";
            this.maskedTextBoxProdNo.Name = "maskedTextBoxProdNo";
            this.maskedTextBoxProdNo.Size = new System.Drawing.Size(157, 22);
            this.maskedTextBoxProdNo.TabIndex = 0;
            // 
            // TxtDescreption
            // 
            this.TxtDescreption.Location = new System.Drawing.Point(266, 72);
            this.TxtDescreption.Multiline = true;
            this.TxtDescreption.Name = "TxtDescreption";
            this.TxtDescreption.Size = new System.Drawing.Size(157, 46);
            this.TxtDescreption.TabIndex = 1;
            // 
            // TxtProfitPer
            // 
            this.TxtProfitPer.Location = new System.Drawing.Point(266, 140);
            this.TxtProfitPer.Name = "TxtProfitPer";
            this.TxtProfitPer.Size = new System.Drawing.Size(157, 22);
            this.TxtProfitPer.TabIndex = 2;
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(717, 25);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(157, 22);
            this.TxtQty.TabIndex = 3;
            // 
            // TxtReorderleval
            // 
            this.TxtReorderleval.Location = new System.Drawing.Point(717, 58);
            this.TxtReorderleval.Name = "TxtReorderleval";
            this.TxtReorderleval.Size = new System.Drawing.Size(157, 22);
            this.TxtReorderleval.TabIndex = 4;
            // 
            // TxtCostPrice
            // 
            this.TxtCostPrice.Location = new System.Drawing.Point(717, 96);
            this.TxtCostPrice.Name = "TxtCostPrice";
            this.TxtCostPrice.Size = new System.Drawing.Size(157, 22);
            this.TxtCostPrice.TabIndex = 5;
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(717, 135);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(157, 22);
            this.TxtSellPrice.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(214, 186);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(111, 31);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(355, 186);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(111, 31);
            this.BtnRemove.TabIndex = 8;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(504, 186);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(111, 31);
            this.BtnSearch.TabIndex = 9;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnVIEW
            // 
            this.btnVIEW.Location = new System.Drawing.Point(649, 186);
            this.btnVIEW.Name = "btnVIEW";
            this.btnVIEW.Size = new System.Drawing.Size(111, 31);
            this.btnVIEW.TabIndex = 31;
            this.btnVIEW.Text = "VIEW";
            this.btnVIEW.UseVisualStyleBackColor = true;
            this.btnVIEW.Click += new System.EventHandler(this.btnVIEW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 286);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVIEW);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtSellPrice);
            this.Controls.Add(this.TxtCostPrice);
            this.Controls.Add(this.TxtReorderleval);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtProfitPer);
            this.Controls.Add(this.TxtDescreption);
            this.Controls.Add(this.maskedTextBoxProdNo);
            this.Controls.Add(this.Lblsell_price);
            this.Controls.Add(this.Lblcost_price);
            this.Controls.Add(this.Lblreorder_level);
            this.Controls.Add(this.LblQtyOnHand);
            this.Controls.Add(this.LblProfitPercentage);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblProductNo);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProductNo;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblProfitPercentage;
        private System.Windows.Forms.Label LblQtyOnHand;
        private System.Windows.Forms.Label Lblreorder_level;
        private System.Windows.Forms.Label Lblcost_price;
        private System.Windows.Forms.Label Lblsell_price;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProdNo;
        private System.Windows.Forms.TextBox TxtDescreption;
        private System.Windows.Forms.TextBox TxtProfitPer;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox TxtReorderleval;
        private System.Windows.Forms.TextBox TxtCostPrice;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button btnVIEW;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}