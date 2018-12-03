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
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItemSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrderItemSearch
            // 
            this.dataGridOrderItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderItemSearch.Location = new System.Drawing.Point(141, 11);
            this.dataGridOrderItemSearch.Name = "dataGridOrderItemSearch";
            this.dataGridOrderItemSearch.Size = new System.Drawing.Size(299, 261);
            this.dataGridOrderItemSearch.TabIndex = 3;
            // 
            // lblOrderItemTitle
            // 
            this.lblOrderItemTitle.AutoSize = true;
            this.lblOrderItemTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemTitle.Location = new System.Drawing.Point(14, 11);
            this.lblOrderItemTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOrderItemTitle.Name = "lblOrderItemTitle";
            this.lblOrderItemTitle.Size = new System.Drawing.Size(112, 40);
            this.lblOrderItemTitle.TabIndex = 12;
            this.lblOrderItemTitle.Text = "Search";
            // 
            // btnOrderItemReturn
            // 
            this.btnOrderItemReturn.Location = new System.Drawing.Point(43, 245);
            this.btnOrderItemReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderItemReturn.Name = "btnOrderItemReturn";
            this.btnOrderItemReturn.Size = new System.Drawing.Size(63, 27);
            this.btnOrderItemReturn.TabIndex = 2;
            this.btnOrderItemReturn.Text = "Return";
            this.btnOrderItemReturn.UseVisualStyleBackColor = true;
            this.btnOrderItemReturn.Click += new System.EventHandler(this.btnOrderItemReturn_Click);
            // 
            // txtBoxSearchOrderItemID
            // 
            this.txtBoxSearchOrderItemID.Location = new System.Drawing.Point(20, 85);
            this.txtBoxSearchOrderItemID.Name = "txtBoxSearchOrderItemID";
            this.txtBoxSearchOrderItemID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchOrderItemID.TabIndex = 0;
            this.txtBoxSearchOrderItemID.Click += new System.EventHandler(this.txtBoxSearchOrderItemID_Click);
            // 
            // lblOrderItemSearchID
            // 
            this.lblOrderItemSearchID.AutoSize = true;
            this.lblOrderItemSearchID.Location = new System.Drawing.Point(19, 68);
            this.lblOrderItemSearchID.Name = "lblOrderItemSearchID";
            this.lblOrderItemSearchID.Size = new System.Drawing.Size(98, 13);
            this.lblOrderItemSearchID.TabIndex = 24;
            this.lblOrderItemSearchID.Text = "Search by Order ID";
            // 
            // btnOrderItemGo
            // 
            this.btnOrderItemGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderItemGo.Location = new System.Drawing.Point(20, 119);
            this.btnOrderItemGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderItemGo.Name = "btnOrderItemGo";
            this.btnOrderItemGo.Size = new System.Drawing.Size(86, 36);
            this.btnOrderItemGo.TabIndex = 1;
            this.btnOrderItemGo.Text = "Go";
            this.btnOrderItemGo.UseVisualStyleBackColor = true;
            this.btnOrderItemGo.Click += new System.EventHandler(this.btnOrderItemGo_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(5, 246);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 35;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // OrderItemSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 280);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOrderItemGo);
            this.Controls.Add(this.txtBoxSearchOrderItemID);
            this.Controls.Add(this.lblOrderItemSearchID);
            this.Controls.Add(this.btnOrderItemReturn);
            this.Controls.Add(this.lblOrderItemTitle);
            this.Controls.Add(this.dataGridOrderItemSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderItemSearch";
            this.Text = "Search Order Contents";
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
        private System.Windows.Forms.Button btnHelp;
    }
}