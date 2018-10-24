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
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerReturn = new System.Windows.Forms.Button();
            this.btnCustomerExit = new System.Windows.Forms.Button();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.txtBoxSearchCustomer = new System.Windows.Forms.TextBox();
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
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSearch.Location = new System.Drawing.Point(117, 152);
            this.btnCustomerSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(86, 36);
            this.btnCustomerSearch.TabIndex = 3;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(20, 152);
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
            this.btnCustomerDelete.Location = new System.Drawing.Point(20, 216);
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
            // btnCustomerExit
            // 
            this.btnCustomerExit.Location = new System.Drawing.Point(115, 272);
            this.btnCustomerExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerExit.Name = "btnCustomerExit";
            this.btnCustomerExit.Size = new System.Drawing.Size(63, 27);
            this.btnCustomerExit.TabIndex = 6;
            this.btnCustomerExit.Text = "Exit";
            this.btnCustomerExit.UseVisualStyleBackColor = true;
            this.btnCustomerExit.Click += new System.EventHandler(this.btnCustomerExit_Click);
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(208, 38);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.Size = new System.Drawing.Size(299, 261);
            this.dataGridCustomer.TabIndex = 7;
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.Location = new System.Drawing.Point(21, 89);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(86, 13);
            this.lblCustomerSearch.TabIndex = 8;
            this.lblCustomerSearch.Text = "Search by Name";
            // 
            // txtBoxSearchCustomer
            // 
            this.txtBoxSearchCustomer.Location = new System.Drawing.Point(24, 106);
            this.txtBoxSearchCustomer.Name = "txtBoxSearchCustomer";
            this.txtBoxSearchCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchCustomer.TabIndex = 9;
            this.txtBoxSearchCustomer.TextChanged += new System.EventHandler(this.txtBoxSearchCustomer_TextChanged);
            // 
            // CustomersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 311);
            this.Controls.Add(this.txtBoxSearchCustomer);
            this.Controls.Add(this.lblCustomerSearch);
            this.Controls.Add(this.dataGridCustomer);
            this.Controls.Add(this.btnCustomerExit);
            this.Controls.Add(this.btnCustomerReturn);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.lblCustomersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersMain";
            this.Text = "CustomersMain";
            this.Load += new System.EventHandler(this.CustomersMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerReturn;
        private System.Windows.Forms.Button btnCustomerExit;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label lblCustomerSearch;
        private System.Windows.Forms.TextBox txtBoxSearchCustomer;
    }
}