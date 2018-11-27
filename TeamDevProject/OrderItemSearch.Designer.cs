namespace TeamDevProject
{
    partial class OrderItemSearch
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
            this.dataGridOrderItemSearch = new System.Windows.Forms.DataGridView();
            this.lblOrderItemTitle = new System.Windows.Forms.Label();
            this.btnOrderItemReturn = new System.Windows.Forms.Button();
            this.txtBoxSearchOrderItemID = new System.Windows.Forms.TextBox();
            this.lblOrderItemSearchID = new System.Windows.Forms.Label();
            this.btnOrderItemGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItemSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrderItemSearch
            // 
            this.dataGridOrderItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderItemSearch.Location = new System.Drawing.Point(188, 13);
            this.dataGridOrderItemSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrderItemSearch.Name = "dataGridOrderItemSearch";
            this.dataGridOrderItemSearch.Size = new System.Drawing.Size(399, 321);
            this.dataGridOrderItemSearch.TabIndex = 9;
            // 
            // lblOrderItemTitle
            // 
            this.lblOrderItemTitle.AutoSize = true;
            this.lblOrderItemTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemTitle.Location = new System.Drawing.Point(18, 13);
            this.lblOrderItemTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblOrderItemTitle.Name = "lblOrderItemTitle";
            this.lblOrderItemTitle.Size = new System.Drawing.Size(136, 49);
            this.lblOrderItemTitle.TabIndex = 12;
            this.lblOrderItemTitle.Text = "Search";
            // 
            // btnOrderItemReturn
            // 
            this.btnOrderItemReturn.Location = new System.Drawing.Point(27, 301);
            this.btnOrderItemReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemReturn.Name = "btnOrderItemReturn";
            this.btnOrderItemReturn.Size = new System.Drawing.Size(84, 33);
            this.btnOrderItemReturn.TabIndex = 13;
            this.btnOrderItemReturn.Text = "Return";
            this.btnOrderItemReturn.UseVisualStyleBackColor = true;
            this.btnOrderItemReturn.Click += new System.EventHandler(this.btnOrderItemReturn_Click);
            // 
            // txtBoxSearchOrderItemID
            // 
            this.txtBoxSearchOrderItemID.Location = new System.Drawing.Point(27, 105);
            this.txtBoxSearchOrderItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchOrderItemID.Name = "txtBoxSearchOrderItemID";
            this.txtBoxSearchOrderItemID.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSearchOrderItemID.TabIndex = 23;
            // 
            // lblOrderItemSearchID
            // 
            this.lblOrderItemSearchID.AutoSize = true;
            this.lblOrderItemSearchID.Location = new System.Drawing.Point(25, 84);
            this.lblOrderItemSearchID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderItemSearchID.Name = "lblOrderItemSearchID";
            this.lblOrderItemSearchID.Size = new System.Drawing.Size(130, 17);
            this.lblOrderItemSearchID.TabIndex = 24;
            this.lblOrderItemSearchID.Text = "Search by Order ID";
            // 
            // btnOrderItemGo
            // 
            this.btnOrderItemGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemGo.Location = new System.Drawing.Point(27, 147);
            this.btnOrderItemGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderItemGo.Name = "btnOrderItemGo";
            this.btnOrderItemGo.Size = new System.Drawing.Size(115, 44);
            this.btnOrderItemGo.TabIndex = 25;
            this.btnOrderItemGo.Text = "Go";
            this.btnOrderItemGo.UseVisualStyleBackColor = true;
            this.btnOrderItemGo.Click += new System.EventHandler(this.btnOrderItemGo_Click);
            // 
            // OrderItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 345);
            this.Controls.Add(this.btnOrderItemGo);
            this.Controls.Add(this.txtBoxSearchOrderItemID);
            this.Controls.Add(this.lblOrderItemSearchID);
            this.Controls.Add(this.btnOrderItemReturn);
            this.Controls.Add(this.lblOrderItemTitle);
            this.Controls.Add(this.dataGridOrderItemSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderItemSearch";
            this.Text = "OrderItemSearch";
            this.Load += new System.EventHandler(this.OrderItemSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItemSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrderItemSearch;
        private System.Windows.Forms.Label lblOrderItemTitle;
        private System.Windows.Forms.Button btnOrderItemReturn;
        private System.Windows.Forms.TextBox txtBoxSearchOrderItemID;
        private System.Windows.Forms.Label lblOrderItemSearchID;
        private System.Windows.Forms.Button btnOrderItemGo;
    }
}