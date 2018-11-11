namespace TeamDevProject
{
    partial class InventoryMain
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
            this.btnInventoryDelete = new System.Windows.Forms.Button();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.btnInventoryExit = new System.Windows.Forms.Button();
            this.btnInventoryReturn = new System.Windows.Forms.Button();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchInventory = new System.Windows.Forms.TextBox();
            this.lblInventorySearch = new System.Windows.Forms.Label();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.Location = new System.Drawing.Point(24, 268);
            this.btnInventoryDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(115, 44);
            this.btnInventoryDelete.TabIndex = 15;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdd.Location = new System.Drawing.Point(24, 192);
            this.btnInventoryAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(115, 44);
            this.btnInventoryAdd.TabIndex = 14;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.Location = new System.Drawing.Point(15, 14);
            this.lblInventoryTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(183, 49);
            this.lblInventoryTitle.TabIndex = 11;
            this.lblInventoryTitle.Text = "Inventory";
            // 
            // btnInventoryExit
            // 
            this.btnInventoryExit.Location = new System.Drawing.Point(151, 329);
            this.btnInventoryExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryExit.Name = "btnInventoryExit";
            this.btnInventoryExit.Size = new System.Drawing.Size(84, 33);
            this.btnInventoryExit.TabIndex = 16;
            this.btnInventoryExit.Text = "Exit";
            this.btnInventoryExit.UseVisualStyleBackColor = true;
            this.btnInventoryExit.Click += new System.EventHandler(this.btnInventoryExit_Click);
            // 
            // btnInventoryReturn
            // 
            this.btnInventoryReturn.Location = new System.Drawing.Point(55, 329);
            this.btnInventoryReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryReturn.Name = "btnInventoryReturn";
            this.btnInventoryReturn.Size = new System.Drawing.Size(84, 33);
            this.btnInventoryReturn.TabIndex = 17;
            this.btnInventoryReturn.Text = "Return";
            this.btnInventoryReturn.UseVisualStyleBackColor = true;
            this.btnInventoryReturn.Click += new System.EventHandler(this.btnInventoryReturn_Click);
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(276, 49);
            this.dataGridInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.Size = new System.Drawing.Size(399, 321);
            this.dataGridInventory.TabIndex = 18;
            // 
            // txtBoxSearchInventory
            // 
            this.txtBoxSearchInventory.Location = new System.Drawing.Point(25, 140);
            this.txtBoxSearchInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearchInventory.Name = "txtBoxSearchInventory";
            this.txtBoxSearchInventory.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSearchInventory.TabIndex = 20;
            this.txtBoxSearchInventory.TextChanged += new System.EventHandler(this.txtBoxSearchInventory_TextChanged);
            // 
            // lblInventorySearch
            // 
            this.lblInventorySearch.AutoSize = true;
            this.lblInventorySearch.Location = new System.Drawing.Point(21, 119);
            this.lblInventorySearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventorySearch.Name = "lblInventorySearch";
            this.lblInventorySearch.Size = new System.Drawing.Size(143, 17);
            this.lblInventorySearch.TabIndex = 19;
            this.lblInventorySearch.Text = "Search by Item Name";
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryRefresh.Location = new System.Drawing.Point(151, 268);
            this.btnInventoryRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(115, 44);
            this.btnInventoryRefresh.TabIndex = 21;
            this.btnInventoryRefresh.Text = "Refresh";
            this.btnInventoryRefresh.UseVisualStyleBackColor = true;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.InventoryMain_Load);
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 383);
            this.Controls.Add(this.btnInventoryRefresh);
            this.Controls.Add(this.txtBoxSearchInventory);
            this.Controls.Add(this.lblInventorySearch);
            this.Controls.Add(this.dataGridInventory);
            this.Controls.Add(this.btnInventoryExit);
            this.Controls.Add(this.btnInventoryReturn);
            this.Controls.Add(this.btnInventoryDelete);
            this.Controls.Add(this.btnInventoryAdd);
            this.Controls.Add(this.lblInventoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryMain";
            this.Text = "InventoryMain";
            this.Load += new System.EventHandler(this.InventoryMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Button btnInventoryExit;
        private System.Windows.Forms.Button btnInventoryReturn;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.TextBox txtBoxSearchInventory;
        private System.Windows.Forms.Label lblInventorySearch;
        private System.Windows.Forms.Button btnInventoryRefresh;
    }
}