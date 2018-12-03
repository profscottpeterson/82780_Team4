namespace TeamDevProject
{
    partial class OrderItemAdd
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
            this.lblOrderItemAddTitle = new System.Windows.Forms.Label();
            this.lblOrderItemAddOrderID = new System.Windows.Forms.Label();
            this.lblOrderItemAddInvID = new System.Windows.Forms.Label();
            this.txtOrderIDOrderItemAdd = new System.Windows.Forms.TextBox();
            this.txtInvIDOrderItemAdd = new System.Windows.Forms.TextBox();
            this.btnReturnOrderItemAdd = new System.Windows.Forms.Button();
            this.btnResetOrderItemAdd = new System.Windows.Forms.Button();
            this.btnOrderItemAddGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderItemAddTitle
            // 
            this.lblOrderItemAddTitle.AutoSize = true;
            this.lblOrderItemAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderItemAddTitle.Location = new System.Drawing.Point(9, 7);
            this.lblOrderItemAddTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderItemAddTitle.Name = "lblOrderItemAddTitle";
            this.lblOrderItemAddTitle.Size = new System.Drawing.Size(115, 26);
            this.lblOrderItemAddTitle.TabIndex = 1;
            this.lblOrderItemAddTitle.Text = "Add Fields";
            // 
            // lblOrderItemAddOrderID
            // 
            this.lblOrderItemAddOrderID.AutoSize = true;
            this.lblOrderItemAddOrderID.Location = new System.Drawing.Point(30, 58);
            this.lblOrderItemAddOrderID.Name = "lblOrderItemAddOrderID";
            this.lblOrderItemAddOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderItemAddOrderID.TabIndex = 21;
            this.lblOrderItemAddOrderID.Text = "Order ID";
            // 
            // lblOrderItemAddInvID
            // 
            this.lblOrderItemAddInvID.AutoSize = true;
            this.lblOrderItemAddInvID.Location = new System.Drawing.Point(12, 95);
            this.lblOrderItemAddInvID.Name = "lblOrderItemAddInvID";
            this.lblOrderItemAddInvID.Size = new System.Drawing.Size(65, 13);
            this.lblOrderItemAddInvID.TabIndex = 22;
            this.lblOrderItemAddInvID.Text = "Inventory ID";
            // 
            // txtOrderIDOrderItemAdd
            // 
            this.txtOrderIDOrderItemAdd.Location = new System.Drawing.Point(92, 55);
            this.txtOrderIDOrderItemAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderIDOrderItemAdd.Name = "txtOrderIDOrderItemAdd";
            this.txtOrderIDOrderItemAdd.Size = new System.Drawing.Size(102, 20);
            this.txtOrderIDOrderItemAdd.TabIndex = 20;
            // 
            // txtInvIDOrderItemAdd
            // 
            this.txtInvIDOrderItemAdd.Location = new System.Drawing.Point(92, 92);
            this.txtInvIDOrderItemAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvIDOrderItemAdd.Name = "txtInvIDOrderItemAdd";
            this.txtInvIDOrderItemAdd.Size = new System.Drawing.Size(102, 20);
            this.txtInvIDOrderItemAdd.TabIndex = 19;
            // 
            // btnReturnOrderItemAdd
            // 
            this.btnReturnOrderItemAdd.Location = new System.Drawing.Point(312, 104);
            this.btnReturnOrderItemAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnOrderItemAdd.Name = "btnReturnOrderItemAdd";
            this.btnReturnOrderItemAdd.Size = new System.Drawing.Size(116, 32);
            this.btnReturnOrderItemAdd.TabIndex = 25;
            this.btnReturnOrderItemAdd.Text = "Return";
            this.btnReturnOrderItemAdd.UseVisualStyleBackColor = true;
            this.btnReturnOrderItemAdd.Click += new System.EventHandler(this.btnReturnOrderItemAdd_Click);
            // 
            // btnResetOrderItemAdd
            // 
            this.btnResetOrderItemAdd.Location = new System.Drawing.Point(312, 67);
            this.btnResetOrderItemAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetOrderItemAdd.Name = "btnResetOrderItemAdd";
            this.btnResetOrderItemAdd.Size = new System.Drawing.Size(116, 32);
            this.btnResetOrderItemAdd.TabIndex = 24;
            this.btnResetOrderItemAdd.Text = "Reset";
            this.btnResetOrderItemAdd.UseVisualStyleBackColor = true;
            this.btnResetOrderItemAdd.Click += new System.EventHandler(this.btnResetOrderItemAdd_Click);
            // 
            // btnOrderItemAddGo
            // 
            this.btnOrderItemAddGo.Location = new System.Drawing.Point(312, 12);
            this.btnOrderItemAddGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderItemAddGo.Name = "btnOrderItemAddGo";
            this.btnOrderItemAddGo.Size = new System.Drawing.Size(116, 50);
            this.btnOrderItemAddGo.TabIndex = 23;
            this.btnOrderItemAddGo.Text = "Add";
            this.btnOrderItemAddGo.UseVisualStyleBackColor = true;
            this.btnOrderItemAddGo.Click += new System.EventHandler(this.btnOrderItemAddGo_Click);
            // 
            // OrderItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 150);
            this.Controls.Add(this.btnReturnOrderItemAdd);
            this.Controls.Add(this.btnResetOrderItemAdd);
            this.Controls.Add(this.btnOrderItemAddGo);
            this.Controls.Add(this.lblOrderItemAddOrderID);
            this.Controls.Add(this.lblOrderItemAddInvID);
            this.Controls.Add(this.txtOrderIDOrderItemAdd);
            this.Controls.Add(this.txtInvIDOrderItemAdd);
            this.Controls.Add(this.lblOrderItemAddTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderItemAdd";
            this.Text = "Add New Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderItemAddTitle;
        private System.Windows.Forms.Label lblOrderItemAddOrderID;
        private System.Windows.Forms.Label lblOrderItemAddInvID;
        private System.Windows.Forms.TextBox txtOrderIDOrderItemAdd;
        private System.Windows.Forms.TextBox txtInvIDOrderItemAdd;
        private System.Windows.Forms.Button btnReturnOrderItemAdd;
        private System.Windows.Forms.Button btnResetOrderItemAdd;
        private System.Windows.Forms.Button btnOrderItemAddGo;
    }
}