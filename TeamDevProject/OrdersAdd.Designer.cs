namespace TeamDevProject
{
    partial class OrdersAdd
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
            this.btnReturnOrdersAdd = new System.Windows.Forms.Button();
            this.btnResetOrdersAdd = new System.Windows.Forms.Button();
            this.btnOrdersAddGo = new System.Windows.Forms.Button();
            this.txtCustIDOrdersAdd = new System.Windows.Forms.TextBox();
            this.lblOrdersAddTitle = new System.Windows.Forms.Label();
            this.ordersDatePk = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnOrdersAdd
            // 
            this.btnReturnOrdersAdd.Location = new System.Drawing.Point(313, 104);
            this.btnReturnOrdersAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnOrdersAdd.Name = "btnReturnOrdersAdd";
            this.btnReturnOrdersAdd.Size = new System.Drawing.Size(116, 32);
            this.btnReturnOrdersAdd.TabIndex = 4;
            this.btnReturnOrdersAdd.Text = "Return";
            this.btnReturnOrdersAdd.UseVisualStyleBackColor = true;
            this.btnReturnOrdersAdd.Click += new System.EventHandler(this.btnReturnOrdersAdd_Click);
            // 
            // btnResetOrdersAdd
            // 
            this.btnResetOrdersAdd.Location = new System.Drawing.Point(313, 67);
            this.btnResetOrdersAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetOrdersAdd.Name = "btnResetOrdersAdd";
            this.btnResetOrdersAdd.Size = new System.Drawing.Size(116, 32);
            this.btnResetOrdersAdd.TabIndex = 3;
            this.btnResetOrdersAdd.Text = "Reset";
            this.btnResetOrdersAdd.UseVisualStyleBackColor = true;
            this.btnResetOrdersAdd.Click += new System.EventHandler(this.btnResetOrdersAdd_Click);
            // 
            // btnOrdersAddGo
            // 
            this.btnOrdersAddGo.Location = new System.Drawing.Point(313, 12);
            this.btnOrdersAddGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdersAddGo.Name = "btnOrdersAddGo";
            this.btnOrdersAddGo.Size = new System.Drawing.Size(116, 50);
            this.btnOrdersAddGo.TabIndex = 2;
            this.btnOrdersAddGo.Text = "Add";
            this.btnOrdersAddGo.UseVisualStyleBackColor = true;
            this.btnOrdersAddGo.Click += new System.EventHandler(this.btnOrdersAddGo_Click);
            // 
            // txtCustIDOrdersAdd
            // 
            this.txtCustIDOrdersAdd.Location = new System.Drawing.Point(91, 78);
            this.txtCustIDOrdersAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustIDOrdersAdd.Name = "txtCustIDOrdersAdd";
            this.txtCustIDOrdersAdd.Size = new System.Drawing.Size(102, 20);
            this.txtCustIDOrdersAdd.TabIndex = 1;
            // 
            // lblOrdersAddTitle
            // 
            this.lblOrdersAddTitle.AutoSize = true;
            this.lblOrdersAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersAddTitle.Location = new System.Drawing.Point(9, 7);
            this.lblOrdersAddTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersAddTitle.Name = "lblOrdersAddTitle";
            this.lblOrdersAddTitle.Size = new System.Drawing.Size(115, 26);
            this.lblOrdersAddTitle.TabIndex = 32;
            this.lblOrdersAddTitle.Text = "Add Fields";
            // 
            // ordersDatePk
            // 
            this.ordersDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ordersDatePk.Location = new System.Drawing.Point(91, 46);
            this.ordersDatePk.Name = "ordersDatePk";
            this.ordersDatePk.Size = new System.Drawing.Size(102, 20);
            this.ordersDatePk.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 13);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Order Date";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(21, 81);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 45;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // OrdersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 150);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.ordersDatePk);
            this.Controls.Add(this.btnReturnOrdersAdd);
            this.Controls.Add(this.btnResetOrdersAdd);
            this.Controls.Add(this.btnOrdersAddGo);
            this.Controls.Add(this.txtCustIDOrdersAdd);
            this.Controls.Add(this.lblOrdersAddTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersAdd";
            this.Text = "Add Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnOrdersAdd;
        private System.Windows.Forms.Button btnResetOrdersAdd;
        private System.Windows.Forms.Button btnOrdersAddGo;
        private System.Windows.Forms.TextBox txtCustIDOrdersAdd;
        private System.Windows.Forms.Label lblOrdersAddTitle;
        private System.Windows.Forms.DateTimePicker ordersDatePk;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerID;
    }
}