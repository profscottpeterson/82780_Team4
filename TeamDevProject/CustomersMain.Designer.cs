namespace TeamDevProject
{
    partial class CustomersMain
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
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.lbxCustomerMenu = new System.Windows.Forms.ListBox();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerReturn = new System.Windows.Forms.Button();
            this.btnCustomerExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.AutoSize = true;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersTitle.Location = new System.Drawing.Point(18, 12);
            this.lblCustomersTitle.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(203, 49);
            this.lblCustomersTitle.TabIndex = 1;
            this.lblCustomersTitle.Text = "Customers";
            // 
            // lbxCustomerMenu
            // 
            this.lbxCustomerMenu.FormattingEnabled = true;
            this.lbxCustomerMenu.ItemHeight = 16;
            this.lbxCustomerMenu.Location = new System.Drawing.Point(301, 12);
            this.lbxCustomerMenu.Name = "lbxCustomerMenu";
            this.lbxCustomerMenu.Size = new System.Drawing.Size(301, 356);
            this.lbxCustomerMenu.TabIndex = 2;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSearch.Location = new System.Drawing.Point(27, 107);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(114, 44);
            this.btnCustomerSearch.TabIndex = 3;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(27, 187);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(114, 44);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(27, 266);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(114, 44);
            this.btnCustomerDelete.TabIndex = 5;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerReturn
            // 
            this.btnCustomerReturn.Location = new System.Drawing.Point(57, 335);
            this.btnCustomerReturn.Name = "btnCustomerReturn";
            this.btnCustomerReturn.Size = new System.Drawing.Size(84, 33);
            this.btnCustomerReturn.TabIndex = 6;
            this.btnCustomerReturn.Text = "Return";
            this.btnCustomerReturn.UseVisualStyleBackColor = true;
            this.btnCustomerReturn.Click += new System.EventHandler(this.btnCustomerReturn_Click);
            // 
            // btnCustomerExit
            // 
            this.btnCustomerExit.Location = new System.Drawing.Point(153, 335);
            this.btnCustomerExit.Name = "btnCustomerExit";
            this.btnCustomerExit.Size = new System.Drawing.Size(84, 33);
            this.btnCustomerExit.TabIndex = 6;
            this.btnCustomerExit.Text = "Exit";
            this.btnCustomerExit.UseVisualStyleBackColor = true;
            this.btnCustomerExit.Click += new System.EventHandler(this.btnCustomerExit_Click);
            // 
            // CustomersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 383);
            this.Controls.Add(this.btnCustomerExit);
            this.Controls.Add(this.btnCustomerReturn);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.lbxCustomerMenu);
            this.Controls.Add(this.lblCustomersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomersMain";
            this.Text = "CustomersMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.ListBox lbxCustomerMenu;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerReturn;
        private System.Windows.Forms.Button btnCustomerExit;
    }
}