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
            this.btnOrdersExit = new System.Windows.Forms.Button();
            this.btnOrdersReturn = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchOrder = new System.Windows.Forms.TextBox();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.Location = new System.Drawing.Point(24, 268);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(115, 44);
            this.btnOrderDelete.TabIndex = 10;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.Location = new System.Drawing.Point(24, 192);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(115, 44);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 14);
            this.lblOrdersTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(137, 49);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Orders";
            // 
            // btnOrdersExit
            // 
            this.btnOrdersExit.Location = new System.Drawing.Point(151, 329);
            this.btnOrdersExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdersExit.Name = "btnOrdersExit";
            this.btnOrdersExit.Size = new System.Drawing.Size(84, 33);
            this.btnOrdersExit.TabIndex = 18;
            this.btnOrdersExit.Text = "Exit";
            this.btnOrdersExit.UseVisualStyleBackColor = true;
            this.btnOrdersExit.Click += new System.EventHandler(this.btnOrdersExit_Click);
            // 
            // btnOrdersReturn
            // 
            this.btnOrdersReturn.Location = new System.Drawing.Point(55, 329);
            this.btnOrdersReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdersReturn.Name = "btnOrdersReturn";
            this.btnOrdersReturn.Size = new System.Drawing.Size(84, 33);
            this.btnOrdersReturn.TabIndex = 19;
            this.btnOrdersReturn.Text = "Return";
            this.btnOrdersReturn.UseVisualStyleBackColor = true;
            this.btnOrdersReturn.Click += new System.EventHandler(this.btnOrdersReturn_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(276, 49);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(399, 321);
            this.dataGridOrder.TabIndex = 20;
            // 
            // txtBoxSearchOrder
            // 
            this.txtBoxSearchOrder.Location = new System.Drawing.Point(26, 144);
            this.txtBoxSearchOrder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBoxSearchOrder.Name = "txtBoxSearchOrder";
            this.txtBoxSearchOrder.Size = new System.Drawing.Size(77, 22);
            this.txtBoxSearchOrder.TabIndex = 22;
            this.txtBoxSearchOrder.TextChanged += new System.EventHandler(this.txtBoxSearchOrder_TextChanged);
            // 
            // lblOrderSearch
            // 
            this.lblOrderSearch.AutoSize = true;
            this.lblOrderSearch.Location = new System.Drawing.Point(21, 120);
            this.lblOrderSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderSearch.Name = "lblOrderSearch";
            this.lblOrderSearch.Size = new System.Drawing.Size(89, 17);
            this.lblOrderSearch.TabIndex = 21;
            this.lblOrderSearch.Text = "Search by ID";
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryRefresh.Location = new System.Drawing.Point(151, 268);
            this.btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(115, 44);
            this.btnInventoryRefresh.TabIndex = 23;
            this.btnInventoryRefresh.Text = "Refresh";
            this.btnInventoryRefresh.UseVisualStyleBackColor = true;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.OrdersMain_Load);
            // 
            // OrdersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 383);
            this.Controls.Add(this.btnInventoryRefresh);
            this.Controls.Add(this.txtBoxSearchOrder);
            this.Controls.Add(this.lblOrderSearch);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.btnOrdersExit);
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
        private System.Windows.Forms.Button btnOrdersExit;
        private System.Windows.Forms.Button btnOrdersReturn;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.TextBox txtBoxSearchOrder;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.Button btnInventoryRefresh;
    }
}