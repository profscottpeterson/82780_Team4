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
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerReturn = new System.Windows.Forms.Button();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerSearchFName = new System.Windows.Forms.Label();
            this.txtBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnCustomerRefresh = new System.Windows.Forms.Button();
            this.txtBoxSearchCustomerLName = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerSearchEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerSearchID = new System.Windows.Forms.TextBox();
            this.lblCustomerSearchID = new System.Windows.Forms.Label();
            this.lblCustomerSearchEmail = new System.Windows.Forms.Label();
            this.lblCustomerSearchLName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.AutoSize = true;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersTitle.Location = new System.Drawing.Point(14, 10);
            this.lblCustomersTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(167, 40);
            this.lblCustomersTitle.TabIndex = 1;
            this.lblCustomersTitle.Text = "Customers";
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(20, 216);
            this.btnCustomerAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(86, 36);
            this.btnCustomerAdd.TabIndex = 4;
            this.btnCustomerAdd.Text = "Add";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(110, 216);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(86, 36);
            this.btnCustomerDelete.TabIndex = 5;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerReturn
            // 
            this.btnCustomerReturn.Location = new System.Drawing.Point(43, 272);
            this.btnCustomerReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerReturn.Name = "btnCustomerReturn";
            this.btnCustomerReturn.Size = new System.Drawing.Size(63, 27);
            this.btnCustomerReturn.TabIndex = 6;
            this.btnCustomerReturn.Text = "Return";
            this.btnCustomerReturn.UseVisualStyleBackColor = true;
            this.btnCustomerReturn.Click += new System.EventHandler(this.btnCustomerReturn_Click);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(208, 38);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.Size = new System.Drawing.Size(299, 261);
            this.dataGridCustomer.TabIndex = 8;
            // 
            // lblCustomerSearchFName
            // 
            this.lblCustomerSearchFName.AutoSize = true;
            this.lblCustomerSearchFName.Location = new System.Drawing.Point(16, 97);
            this.lblCustomerSearchFName.Name = "lblCustomerSearchFName";
            this.lblCustomerSearchFName.Size = new System.Drawing.Size(108, 13);
            this.lblCustomerSearchFName.TabIndex = 8;
            this.lblCustomerSearchFName.Text = "Search by First Name";
            // 
            // txtBoxSearchCustomer
            // 
            this.txtBoxSearchCustomer.Location = new System.Drawing.Point(20, 113);
            this.txtBoxSearchCustomer.Name = "txtBoxSearchCustomer";
            this.txtBoxSearchCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchCustomer.TabIndex = 1;
            this.txtBoxSearchCustomer.TextChanged += new System.EventHandler(this.txtBoxSearchCustomer_TextChanged);
            // 
            // btnCustomerRefresh
            // 
            this.btnCustomerRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRefresh.Location = new System.Drawing.Point(110, 272);
            this.btnCustomerRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerRefresh.Name = "btnCustomerRefresh";
            this.btnCustomerRefresh.Size = new System.Drawing.Size(63, 27);
            this.btnCustomerRefresh.TabIndex = 7;
            this.btnCustomerRefresh.Text = "Refresh";
            this.btnCustomerRefresh.UseVisualStyleBackColor = true;
            this.btnCustomerRefresh.Click += new System.EventHandler(this.CustomersMain_Load);
            // 
            // txtBoxSearchCustomerLName
            // 
            this.txtBoxSearchCustomerLName.Location = new System.Drawing.Point(20, 150);
            this.txtBoxSearchCustomerLName.Name = "txtBoxSearchCustomerLName";
            this.txtBoxSearchCustomerLName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchCustomerLName.TabIndex = 2;
            this.txtBoxSearchCustomerLName.TextChanged += new System.EventHandler(this.txtBoxSearchCustomer_TextChanged);
            // 
            // txtBoxCustomerSearchEmail
            // 
            this.txtBoxCustomerSearchEmail.Location = new System.Drawing.Point(19, 185);
            this.txtBoxCustomerSearchEmail.Name = "txtBoxCustomerSearchEmail";
            this.txtBoxCustomerSearchEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCustomerSearchEmail.TabIndex = 3;
            this.txtBoxCustomerSearchEmail.TextChanged += new System.EventHandler(this.txtBoxSearchCustomer_TextChanged);
            // 
            // txtBoxCustomerSearchID
            // 
            this.txtBoxCustomerSearchID.Location = new System.Drawing.Point(19, 76);
            this.txtBoxCustomerSearchID.Name = "txtBoxCustomerSearchID";
            this.txtBoxCustomerSearchID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCustomerSearchID.TabIndex = 0;
            this.txtBoxCustomerSearchID.TextChanged += new System.EventHandler(this.txtBoxSearchCustomer_TextChanged);
            // 
            // lblCustomerSearchID
            // 
            this.lblCustomerSearchID.AutoSize = true;
            this.lblCustomerSearchID.Location = new System.Drawing.Point(17, 58);
            this.lblCustomerSearchID.Name = "lblCustomerSearchID";
            this.lblCustomerSearchID.Size = new System.Drawing.Size(69, 13);
            this.lblCustomerSearchID.TabIndex = 8;
            this.lblCustomerSearchID.Text = "Search by ID";
            // 
            // lblCustomerSearchEmail
            // 
            this.lblCustomerSearchEmail.AutoSize = true;
            this.lblCustomerSearchEmail.Location = new System.Drawing.Point(18, 171);
            this.lblCustomerSearchEmail.Name = "lblCustomerSearchEmail";
            this.lblCustomerSearchEmail.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerSearchEmail.TabIndex = 8;
            this.lblCustomerSearchEmail.Text = "Search by Email";
            // 
            // lblCustomerSearchLName
            // 
            this.lblCustomerSearchLName.AutoSize = true;
            this.lblCustomerSearchLName.Location = new System.Drawing.Point(19, 132);
            this.lblCustomerSearchLName.Name = "lblCustomerSearchLName";
            this.lblCustomerSearchLName.Size = new System.Drawing.Size(109, 13);
            this.lblCustomerSearchLName.TabIndex = 8;
            this.lblCustomerSearchLName.Text = "Search by Last Name";
            // 
            // CustomersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 311);
            this.Controls.Add(this.txtBoxCustomerSearchID);
            this.Controls.Add(this.txtBoxCustomerSearchEmail);
            this.Controls.Add(this.txtBoxSearchCustomerLName);
            this.Controls.Add(this.txtBoxSearchCustomer);
            this.Controls.Add(this.lblCustomerSearchLName);
            this.Controls.Add(this.lblCustomerSearchEmail);
            this.Controls.Add(this.lblCustomerSearchID);
            this.Controls.Add(this.lblCustomerSearchFName);
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.btnCustomerReturn);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerRefresh);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.lblCustomersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersMain";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerReturn;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label lblCustomerSearchFName;
        private System.Windows.Forms.TextBox txtBoxSearchCustomer;
        private System.Windows.Forms.Button btnCustomerRefresh;
        private System.Windows.Forms.TextBox txtBoxSearchCustomerLName;
        private System.Windows.Forms.TextBox txtBoxCustomerSearchEmail;
        private System.Windows.Forms.TextBox txtBoxCustomerSearchID;
        private System.Windows.Forms.Label lblCustomerSearchID;
        private System.Windows.Forms.Label lblCustomerSearchEmail;
        private System.Windows.Forms.Label lblCustomerSearchLName;
    }
}