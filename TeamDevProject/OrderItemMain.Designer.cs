namespace TeamDevProject
{
    partial class OrderItemMain
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
            this.lblOrderItemTitle = new System.Windows.Forms.Label();
            this.btnOrderItemReturn = new System.Windows.Forms.Button();
            this.btnOrderItemDelete = new System.Windows.Forms.Button();
            this.btnOrderItemRefresh = new System.Windows.Forms.Button();
            this.btnOrderItemAdd = new System.Windows.Forms.Button();
            this.btnOrderItemSearch = new System.Windows.Forms.Button();
            this.dataGridOrderItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderItemTitle
            // 
            this.lblOrderItemTitle.AutoSize = true;
            this.lblOrderItemTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemTitle.Location = new System.Drawing.Point(-2, 16);
            this.lblOrderItemTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblOrderItemTitle.Name = "lblOrderItemTitle";
            this.lblOrderItemTitle.Size = new System.Drawing.Size(285, 49);
            this.lblOrderItemTitle.TabIndex = 2;
            this.lblOrderItemTitle.Text = "Items in Orders";
            // 
            // btnOrderItemReturn
            // 
            this.btnOrderItemReturn.Location = new System.Drawing.Point(59, 284);
            this.btnOrderItemReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemReturn.Name = "btnOrderItemReturn";
            this.btnOrderItemReturn.Size = new System.Drawing.Size(84, 33);
            this.btnOrderItemReturn.TabIndex = 11;
            this.btnOrderItemReturn.Text = "Return";
            this.btnOrderItemReturn.UseVisualStyleBackColor = true;
            this.btnOrderItemReturn.Click += new System.EventHandler(this.btnOrderItemReturn_Click);
            // 
            // btnOrderItemDelete
            // 
            this.btnOrderItemDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemDelete.Location = new System.Drawing.Point(28, 213);
            this.btnOrderItemDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemDelete.Name = "btnOrderItemDelete";
            this.btnOrderItemDelete.Size = new System.Drawing.Size(115, 44);
            this.btnOrderItemDelete.TabIndex = 10;
            this.btnOrderItemDelete.Text = "Delete";
            this.btnOrderItemDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrderItemRefresh
            // 
            this.btnOrderItemRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemRefresh.Location = new System.Drawing.Point(149, 284);
            this.btnOrderItemRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemRefresh.Name = "btnOrderItemRefresh";
            this.btnOrderItemRefresh.Size = new System.Drawing.Size(84, 33);
            this.btnOrderItemRefresh.TabIndex = 12;
            this.btnOrderItemRefresh.Text = "Refresh";
            this.btnOrderItemRefresh.UseVisualStyleBackColor = true;
            this.btnOrderItemRefresh.Click += new System.EventHandler(this.OrderItemMain_Load);
            // 
            // btnOrderItemAdd
            // 
            this.btnOrderItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemAdd.Location = new System.Drawing.Point(28, 149);
            this.btnOrderItemAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemAdd.Name = "btnOrderItemAdd";
            this.btnOrderItemAdd.Size = new System.Drawing.Size(115, 44);
            this.btnOrderItemAdd.TabIndex = 9;
            this.btnOrderItemAdd.Text = "Add";
            this.btnOrderItemAdd.UseVisualStyleBackColor = true;
            // 
            // btnOrderItemSearch
            // 
            this.btnOrderItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemSearch.Location = new System.Drawing.Point(28, 85);
            this.btnOrderItemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemSearch.Name = "btnOrderItemSearch";
            this.btnOrderItemSearch.Size = new System.Drawing.Size(115, 44);
            this.btnOrderItemSearch.TabIndex = 9;
            this.btnOrderItemSearch.Text = "Search";
            this.btnOrderItemSearch.UseVisualStyleBackColor = true;
            this.btnOrderItemSearch.Click += new System.EventHandler(this.btnOrderItemSearch_Click);
            // 
            // dataGridOrderItem
            // 
            this.dataGridOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderItem.Location = new System.Drawing.Point(323, 16);
            this.dataGridOrderItem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrderItem.Name = "dataGridOrderItem";
            this.dataGridOrderItem.Size = new System.Drawing.Size(372, 321);
            this.dataGridOrderItem.TabIndex = 13;
            // 
            // OrderItemMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 348);
            this.Controls.Add(this.dataGridOrderItem);
            this.Controls.Add(this.btnOrderItemReturn);
            this.Controls.Add(this.btnOrderItemDelete);
            this.Controls.Add(this.btnOrderItemRefresh);
            this.Controls.Add(this.btnOrderItemSearch);
            this.Controls.Add(this.btnOrderItemAdd);
            this.Controls.Add(this.lblOrderItemTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderItemMain";
            this.Text = "OrderItemMain";
            this.Load += new System.EventHandler(this.OrderItemMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderItemTitle;
        private System.Windows.Forms.Button btnOrderItemReturn;
        private System.Windows.Forms.Button btnOrderItemDelete;
        private System.Windows.Forms.Button btnOrderItemRefresh;
        private System.Windows.Forms.Button btnOrderItemAdd;
        private System.Windows.Forms.Button btnOrderItemSearch;
        private System.Windows.Forms.DataGridView dataGridOrderItem;
    }
}