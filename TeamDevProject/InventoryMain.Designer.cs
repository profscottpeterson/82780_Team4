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
            this.btnInventorySearch = new System.Windows.Forms.Button();
            this.txtBoxSearchInventory = new System.Windows.Forms.TextBox();
            this.lblInventorySearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.Location = new System.Drawing.Point(52, 217);
            this.btnInventoryDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(86, 36);
            this.btnInventoryDelete.TabIndex = 15;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdd.Location = new System.Drawing.Point(-1, 168);
            this.btnInventoryAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(86, 36);
            this.btnInventoryAdd.TabIndex = 14;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.Location = new System.Drawing.Point(11, 11);
            this.lblInventoryTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(151, 40);
            this.lblInventoryTitle.TabIndex = 11;
            this.lblInventoryTitle.Text = "Inventory";
            // 
            // btnInventoryExit
            // 
            this.btnInventoryExit.Location = new System.Drawing.Point(112, 275);
            this.btnInventoryExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryExit.Name = "btnInventoryExit";
            this.btnInventoryExit.Size = new System.Drawing.Size(63, 27);
            this.btnInventoryExit.TabIndex = 16;
            this.btnInventoryExit.Text = "Exit";
            this.btnInventoryExit.UseVisualStyleBackColor = true;
            this.btnInventoryExit.Click += new System.EventHandler(this.btnInventoryExit_Click);
            // 
            // btnInventoryReturn
            // 
            this.btnInventoryReturn.Location = new System.Drawing.Point(40, 275);
            this.btnInventoryReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventoryReturn.Name = "btnInventoryReturn";
            this.btnInventoryReturn.Size = new System.Drawing.Size(63, 27);
            this.btnInventoryReturn.TabIndex = 17;
            this.btnInventoryReturn.Text = "Return";
            this.btnInventoryReturn.UseVisualStyleBackColor = true;
            this.btnInventoryReturn.Click += new System.EventHandler(this.btnInventoryReturn_Click);
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(228, 41);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.Size = new System.Drawing.Size(270, 250);
            this.dataGridInventory.TabIndex = 18;
            // 
            // btnInventorySearch
            // 
            this.btnInventorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySearch.Location = new System.Drawing.Point(112, 168);
            this.btnInventorySearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventorySearch.Name = "btnInventorySearch";
            this.btnInventorySearch.Size = new System.Drawing.Size(86, 36);
            this.btnInventorySearch.TabIndex = 13;
            this.btnInventorySearch.Text = "Search";
            this.btnInventorySearch.UseVisualStyleBackColor = true;
            this.btnInventorySearch.Click += new System.EventHandler(this.btnInventorySearch_Click);
            // 
            // txtBoxSearchInventory
            // 
            this.txtBoxSearchInventory.Location = new System.Drawing.Point(21, 87);
            this.txtBoxSearchInventory.Name = "txtBoxSearchInventory";
            this.txtBoxSearchInventory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchInventory.TabIndex = 20;
            this.txtBoxSearchInventory.TextChanged += new System.EventHandler(this.txtBoxSearchInventory_TextChanged);
            // 
            // lblInventorySearch
            // 
            this.lblInventorySearch.AutoSize = true;
            this.lblInventorySearch.Location = new System.Drawing.Point(18, 70);
            this.lblInventorySearch.Name = "lblInventorySearch";
            this.lblInventorySearch.Size = new System.Drawing.Size(109, 13);
            this.lblInventorySearch.TabIndex = 19;
            this.lblInventorySearch.Text = "Search by Item Name";
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 342);
            this.Controls.Add(this.txtBoxSearchInventory);
            this.Controls.Add(this.lblInventorySearch);
            this.Controls.Add(this.dataGridInventory);
            this.Controls.Add(this.btnInventoryExit);
            this.Controls.Add(this.btnInventoryReturn);
            this.Controls.Add(this.btnInventoryDelete);
            this.Controls.Add(this.btnInventoryAdd);
            this.Controls.Add(this.btnInventorySearch);
            this.Controls.Add(this.lblInventoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnInventorySearch;
        private System.Windows.Forms.TextBox txtBoxSearchInventory;
        private System.Windows.Forms.Label lblInventorySearch;
    }
}