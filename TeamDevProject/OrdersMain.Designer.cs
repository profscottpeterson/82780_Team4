namespace TeamDevProject
{
    partial class OrdersMain
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
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.btnOrdersReturn = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            this.txtBoxSearchOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderSearchDate = new System.Windows.Forms.Label();
            this.txtBoxSearchOrderCustID = new System.Windows.Forms.TextBox();
            this.lblOrderSearchCustID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.Location = new System.Drawing.Point(147, 266);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(115, 44);
            this.btnOrderDelete.TabIndex = 5;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.Location = new System.Drawing.Point(26, 266);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(115, 44);
            this.btnOrderAdd.TabIndex = 4;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(19, 12);
            this.lblOrdersTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(137, 49);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Orders";
            // 
            // btnOrdersReturn
            // 
            this.btnOrdersReturn.Location = new System.Drawing.Point(57, 335);
            this.btnOrdersReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdersReturn.Name = "btnOrdersReturn";
            this.btnOrdersReturn.Size = new System.Drawing.Size(84, 33);
            this.btnOrdersReturn.TabIndex = 6;
            this.btnOrdersReturn.Text = "Return";
            this.btnOrdersReturn.UseVisualStyleBackColor = true;
            this.btnOrdersReturn.Click += new System.EventHandler(this.btnOrdersReturn_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(276, 49);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(399, 321);
            this.dataGridOrder.TabIndex = 8;
            // 
            // txtBoxSearchOrderID
            // 
            this.txtBoxSearchOrderID.Location = new System.Drawing.Point(25, 93);
            this.txtBoxSearchOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxSearchOrderID.Name = "txtBoxSearchOrderID";
            this.txtBoxSearchOrderID.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSearchOrderID.TabIndex = 1;
            this.txtBoxSearchOrderID.TextChanged += new System.EventHandler(this.txtBoxSearchOrder_TextChanged);
            // 
            // lblOrderSearch
            // 
            this.lblOrderSearch.AutoSize = true;
            this.lblOrderSearch.Location = new System.Drawing.Point(23, 72);
            this.lblOrderSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderSearch.Name = "lblOrderSearch";
            this.lblOrderSearch.Size = new System.Drawing.Size(89, 17);
            this.lblOrderSearch.TabIndex = 21;
            this.lblOrderSearch.Text = "Search by ID";
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryRefresh.Location = new System.Drawing.Point(147, 335);
            this.btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(84, 33);
            this.btnInventoryRefresh.TabIndex = 7;
            this.btnInventoryRefresh.Text = "Refresh";
            this.btnInventoryRefresh.UseVisualStyleBackColor = true;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.OrdersMain_Load);
            // 
            // txtBoxSearchOrderDate
            // 
            this.txtBoxSearchOrderDate.Location = new System.Drawing.Point(26, 214);
            this.txtBoxSearchOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchOrderDate.Name = "txtBoxSearchOrderDate";
            this.txtBoxSearchOrderDate.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSearchOrderDate.TabIndex = 3;
            this.txtBoxSearchOrderDate.TextChanged += new System.EventHandler(this.txtBoxSearchOrder_TextChanged);
            // 
            // lblOrderSearchDate
            // 
            this.lblOrderSearchDate.AutoSize = true;
            this.lblOrderSearchDate.Location = new System.Drawing.Point(25, 193);
            this.lblOrderSearchDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderSearchDate.Name = "lblOrderSearchDate";
            this.lblOrderSearchDate.Size = new System.Drawing.Size(106, 17);
            this.lblOrderSearchDate.TabIndex = 27;
            this.lblOrderSearchDate.Text = "Search by Date";
            // 
            // txtBoxSearchOrderCustID
            // 
            this.txtBoxSearchOrderCustID.Location = new System.Drawing.Point(26, 153);
            this.txtBoxSearchOrderCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchOrderCustID.Name = "txtBoxSearchOrderCustID";
            this.txtBoxSearchOrderCustID.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSearchOrderCustID.TabIndex = 2;
            this.txtBoxSearchOrderCustID.TextChanged += new System.EventHandler(this.txtBoxSearchOrder_TextChanged);
            // 
            // lblOrderSearchCustID
            // 
            this.lblOrderSearchCustID.AutoSize = true;
            this.lblOrderSearchCustID.Location = new System.Drawing.Point(22, 133);
            this.lblOrderSearchCustID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderSearchCustID.Name = "lblOrderSearchCustID";
            this.lblOrderSearchCustID.Size = new System.Drawing.Size(153, 17);
            this.lblOrderSearchCustID.TabIndex = 26;
            this.lblOrderSearchCustID.Text = "Search by Customer ID";
            // 
            // OrdersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 383);
            this.Controls.Add(this.txtBoxSearchOrderDate);
            this.Controls.Add(this.lblOrderSearchDate);
            this.Controls.Add(this.txtBoxSearchOrderCustID);
            this.Controls.Add(this.lblOrderSearchCustID);
            this.Controls.Add(this.btnInventoryRefresh);
            this.Controls.Add(this.txtBoxSearchOrderID);
            this.Controls.Add(this.lblOrderSearch);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.btnOrdersReturn);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.lblOrdersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersMain";
            this.Text = "OrdersMain";
            this.Load += new System.EventHandler(this.OrdersMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Button btnOrdersReturn;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.TextBox txtBoxSearchOrderID;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.TextBox txtBoxSearchOrderDate;
        private System.Windows.Forms.Label lblOrderSearchDate;
        private System.Windows.Forms.TextBox txtBoxSearchOrderCustID;
        private System.Windows.Forms.Label lblOrderSearchCustID;
    }
}