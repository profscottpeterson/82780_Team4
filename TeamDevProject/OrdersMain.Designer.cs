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
            this.txtBoxSearchOrder = new System.Windows.Forms.TextBox();
            this.lblOrderSearch = new System.Windows.Forms.Label();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.gbOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.Location = new System.Drawing.Point(20, 82);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(86, 36);
            this.btnOrderDelete.TabIndex = 10;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.Location = new System.Drawing.Point(20, 18);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(86, 36);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(11, 11);
            this.lblOrdersTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(113, 40);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Orders";
            // 
            // btnOrdersReturn
            // 
            this.btnOrdersReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersReturn.Location = new System.Drawing.Point(20, 146);
            this.btnOrdersReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdersReturn.Name = "btnOrdersReturn";
            this.btnOrdersReturn.Size = new System.Drawing.Size(86, 36);
            this.btnOrdersReturn.TabIndex = 19;
            this.btnOrdersReturn.Text = "Return";
            this.btnOrdersReturn.UseVisualStyleBackColor = true;
            this.btnOrdersReturn.Click += new System.EventHandler(this.btnOrdersReturn_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(285, 11);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(399, 321);
            this.dataGridOrder.TabIndex = 20;
            // 
            // txtBoxSearchOrder
            // 
            this.txtBoxSearchOrder.Location = new System.Drawing.Point(182, 73);
            this.txtBoxSearchOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchOrder.Name = "txtBoxSearchOrder";
            this.txtBoxSearchOrder.Size = new System.Drawing.Size(55, 20);
            this.txtBoxSearchOrder.TabIndex = 22;
            this.txtBoxSearchOrder.TextChanged += new System.EventHandler(this.txtBoxSearchOrder_TextChanged);
            // 
            // lblOrderSearch
            // 
            this.lblOrderSearch.AutoSize = true;
            this.lblOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSearch.Location = new System.Drawing.Point(34, 72);
            this.lblOrderSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderSearch.Name = "lblOrderSearch";
            this.lblOrderSearch.Size = new System.Drawing.Size(140, 18);
            this.lblOrderSearch.TabIndex = 21;
            this.lblOrderSearch.Text = "Search By Order ID:";
            // 
            // gbOrders
            // 
            this.gbOrders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbOrders.Controls.Add(this.btnOrderDelete);
            this.gbOrders.Controls.Add(this.btnOrderAdd);
            this.gbOrders.Controls.Add(this.btnOrdersReturn);
            this.gbOrders.Location = new System.Drawing.Point(68, 121);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(132, 191);
            this.gbOrders.TabIndex = 23;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Controls";
            // 
            // OrdersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 353);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.txtBoxSearchOrder);
            this.Controls.Add(this.lblOrderSearch);
            this.Controls.Add(this.dataGridOrder);
            this.Controls.Add(this.lblOrdersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersMain";
            this.Text = "OrdersMain";
            this.Load += new System.EventHandler(this.OrdersMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.gbOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Button btnOrdersReturn;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.TextBox txtBoxSearchOrder;
        private System.Windows.Forms.Label lblOrderSearch;
        private System.Windows.Forms.GroupBox gbOrders;
    }
}