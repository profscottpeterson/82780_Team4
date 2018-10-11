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
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.lbxOrderMenu = new System.Windows.Forms.ListBox();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.Location = new System.Drawing.Point(24, 267);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(114, 44);
            this.btnOrderDelete.TabIndex = 10;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.Location = new System.Drawing.Point(24, 188);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(114, 44);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSearch.Location = new System.Drawing.Point(24, 108);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(114, 44);
            this.btnOrderSearch.TabIndex = 8;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            // 
            // lbxOrderMenu
            // 
            this.lbxOrderMenu.FormattingEnabled = true;
            this.lbxOrderMenu.ItemHeight = 16;
            this.lbxOrderMenu.Location = new System.Drawing.Point(298, 13);
            this.lbxOrderMenu.Name = "lbxOrderMenu";
            this.lbxOrderMenu.Size = new System.Drawing.Size(301, 356);
            this.lbxOrderMenu.TabIndex = 7;
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 13);
            this.lblOrdersTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(141, 51);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Orders";
            // 
            // OrdersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 383);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.btnOrderSearch);
            this.Controls.Add(this.lbxOrderMenu);
            this.Controls.Add(this.lblOrdersTitle);
            this.Name = "OrdersMain";
            this.Text = "OrdersMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.ListBox lbxOrderMenu;
        private System.Windows.Forms.Label lblOrdersTitle;
    }
}