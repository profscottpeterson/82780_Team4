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
            this.btnInventorySearch = new System.Windows.Forms.Button();
            this.lbxInventoryMenu = new System.Windows.Forms.ListBox();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.btnInventoryExit = new System.Windows.Forms.Button();
            this.btnInventoryReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventoryDelete
            // 
            this.btnInventoryDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryDelete.Location = new System.Drawing.Point(24, 267);
            this.btnInventoryDelete.Name = "btnInventoryDelete";
            this.btnInventoryDelete.Size = new System.Drawing.Size(114, 44);
            this.btnInventoryDelete.TabIndex = 15;
            this.btnInventoryDelete.Text = "Delete";
            this.btnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnInventoryDelete.Click += new System.EventHandler(this.btnInventoryDelete_Click);
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdd.Location = new System.Drawing.Point(24, 188);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(114, 44);
            this.btnInventoryAdd.TabIndex = 14;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // btnInventorySearch
            // 
            this.btnInventorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySearch.Location = new System.Drawing.Point(24, 108);
            this.btnInventorySearch.Name = "btnInventorySearch";
            this.btnInventorySearch.Size = new System.Drawing.Size(114, 44);
            this.btnInventorySearch.TabIndex = 13;
            this.btnInventorySearch.Text = "Search";
            this.btnInventorySearch.UseVisualStyleBackColor = true;
            this.btnInventorySearch.Click += new System.EventHandler(this.btnInventorySearch_Click);
            // 
            // lbxInventoryMenu
            // 
            this.lbxInventoryMenu.FormattingEnabled = true;
            this.lbxInventoryMenu.ItemHeight = 16;
            this.lbxInventoryMenu.Location = new System.Drawing.Point(298, 13);
            this.lbxInventoryMenu.Name = "lbxInventoryMenu";
            this.lbxInventoryMenu.Size = new System.Drawing.Size(301, 356);
            this.lbxInventoryMenu.TabIndex = 12;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.Location = new System.Drawing.Point(15, 13);
            this.lblInventoryTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(183, 49);
            this.lblInventoryTitle.TabIndex = 11;
            this.lblInventoryTitle.Text = "Inventory";
            // 
            // btnInventoryExit
            // 
            this.btnInventoryExit.Location = new System.Drawing.Point(150, 338);
            this.btnInventoryExit.Name = "btnInventoryExit";
            this.btnInventoryExit.Size = new System.Drawing.Size(84, 33);
            this.btnInventoryExit.TabIndex = 16;
            this.btnInventoryExit.Text = "Exit";
            this.btnInventoryExit.UseVisualStyleBackColor = true;
            this.btnInventoryExit.Click += new System.EventHandler(this.btnInventoryExit_Click);
            // 
            // btnInventoryReturn
            // 
            this.btnInventoryReturn.Location = new System.Drawing.Point(54, 338);
            this.btnInventoryReturn.Name = "btnInventoryReturn";
            this.btnInventoryReturn.Size = new System.Drawing.Size(84, 33);
            this.btnInventoryReturn.TabIndex = 17;
            this.btnInventoryReturn.Text = "Return";
            this.btnInventoryReturn.UseVisualStyleBackColor = true;
            this.btnInventoryReturn.Click += new System.EventHandler(this.btnInventoryReturn_Click);
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 383);
            this.Controls.Add(this.btnInventoryExit);
            this.Controls.Add(this.btnInventoryReturn);
            this.Controls.Add(this.btnInventoryDelete);
            this.Controls.Add(this.btnInventoryAdd);
            this.Controls.Add(this.btnInventorySearch);
            this.Controls.Add(this.lbxInventoryMenu);
            this.Controls.Add(this.lblInventoryTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryMain";
            this.Text = "InventoryMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryDelete;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Button btnInventorySearch;
        private System.Windows.Forms.ListBox lbxInventoryMenu;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.Button btnInventoryExit;
        private System.Windows.Forms.Button btnInventoryReturn;
    }
}