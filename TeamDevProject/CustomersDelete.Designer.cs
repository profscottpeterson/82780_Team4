namespace TeamDevProject
{
    partial class CustomersDelete
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
            this.btnReturnCustomerDelete = new System.Windows.Forms.Button();
            this.btnResetCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerDeleteGo = new System.Windows.Forms.Button();
            this.lblCustomerDeleteTitle = new System.Windows.Forms.Label();
            this.txtIDCustomerDelete = new System.Windows.Forms.TextBox();
            this.lblCustomerDeleteID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnCustomerDelete
            // 
            this.btnReturnCustomerDelete.Location = new System.Drawing.Point(213, 103);
            this.btnReturnCustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnCustomerDelete.Name = "btnReturnCustomerDelete";
            this.btnReturnCustomerDelete.Size = new System.Drawing.Size(116, 32);
            this.btnReturnCustomerDelete.TabIndex = 3;
            this.btnReturnCustomerDelete.Text = "Return";
            this.btnReturnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnReturnCustomerDelete.Click += new System.EventHandler(this.btnReturnCustomerDelete_Click);
            // 
            // btnResetCustomerDelete
            // 
            this.btnResetCustomerDelete.Location = new System.Drawing.Point(213, 66);
            this.btnResetCustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetCustomerDelete.Name = "btnResetCustomerDelete";
            this.btnResetCustomerDelete.Size = new System.Drawing.Size(116, 32);
            this.btnResetCustomerDelete.TabIndex = 2;
            this.btnResetCustomerDelete.Text = "Reset";
            this.btnResetCustomerDelete.UseVisualStyleBackColor = true;
            this.btnResetCustomerDelete.Click += new System.EventHandler(this.btnResetCustomerDelete_Click);
            // 
            // btnCustomerDeleteGo
            // 
            this.btnCustomerDeleteGo.Location = new System.Drawing.Point(213, 11);
            this.btnCustomerDeleteGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerDeleteGo.Name = "btnCustomerDeleteGo";
            this.btnCustomerDeleteGo.Size = new System.Drawing.Size(116, 50);
            this.btnCustomerDeleteGo.TabIndex = 1;
            this.btnCustomerDeleteGo.Text = "Delete";
            this.btnCustomerDeleteGo.UseVisualStyleBackColor = true;
            this.btnCustomerDeleteGo.Click += new System.EventHandler(this.btnCustomerDeleteGo_Click);
            // 
            // lblCustomerDeleteTitle
            // 
            this.lblCustomerDeleteTitle.AutoSize = true;
            this.lblCustomerDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDeleteTitle.Location = new System.Drawing.Point(9, 7);
            this.lblCustomerDeleteTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerDeleteTitle.Name = "lblCustomerDeleteTitle";
            this.lblCustomerDeleteTitle.Size = new System.Drawing.Size(139, 26);
            this.lblCustomerDeleteTitle.TabIndex = 18;
            this.lblCustomerDeleteTitle.Text = "Delete Fields";
            // 
            // txtIDCustomerDelete
            // 
            this.txtIDCustomerDelete.Location = new System.Drawing.Point(99, 67);
            this.txtIDCustomerDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCustomerDelete.Name = "txtIDCustomerDelete";
            this.txtIDCustomerDelete.Size = new System.Drawing.Size(49, 20);
            this.txtIDCustomerDelete.TabIndex = 0;
            // 
            // lblCustomerDeleteID
            // 
            this.lblCustomerDeleteID.AutoSize = true;
            this.lblCustomerDeleteID.Location = new System.Drawing.Point(29, 70);
            this.lblCustomerDeleteID.Name = "lblCustomerDeleteID";
            this.lblCustomerDeleteID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerDeleteID.TabIndex = 32;
            this.lblCustomerDeleteID.Text = "Customer ID";
            // 
            // CustomersDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 140);
            this.Controls.Add(this.lblCustomerDeleteID);
            this.Controls.Add(this.btnReturnCustomerDelete);
            this.Controls.Add(this.btnResetCustomerDelete);
            this.Controls.Add(this.btnCustomerDeleteGo);
            this.Controls.Add(this.txtIDCustomerDelete);
            this.Controls.Add(this.lblCustomerDeleteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomersDelete";
            this.Text = "Delete Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnCustomerDelete;
        private System.Windows.Forms.Button btnResetCustomerDelete;
        private System.Windows.Forms.Button btnCustomerDeleteGo;
        private System.Windows.Forms.Label lblCustomerDeleteTitle;
        private System.Windows.Forms.TextBox txtIDCustomerDelete;
        private System.Windows.Forms.Label lblCustomerDeleteID;
    }
}