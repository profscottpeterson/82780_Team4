namespace TeamDevProject
{
    partial class OrdersDelete
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
            this.btnExitOrdersDelete = new System.Windows.Forms.Button();
            this.btnReturnOrdersDelete = new System.Windows.Forms.Button();
            this.btnResetOrdersDelete = new System.Windows.Forms.Button();
            this.btnOrdersDeleteGo = new System.Windows.Forms.Button();
            this.txtIDOrdersDelete = new System.Windows.Forms.TextBox();
            this.lblOrdersDeleteTitle = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitOrdersDelete
            // 
            this.btnExitOrdersDelete.Location = new System.Drawing.Point(220, 140);
            this.btnExitOrdersDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitOrdersDelete.Name = "btnExitOrdersDelete";
            this.btnExitOrdersDelete.Size = new System.Drawing.Size(116, 32);
            this.btnExitOrdersDelete.TabIndex = 59;
            this.btnExitOrdersDelete.Text = "Exit";
            this.btnExitOrdersDelete.UseVisualStyleBackColor = true;
            this.btnExitOrdersDelete.Click += new System.EventHandler(this.btnExitOrdersDelete_Click);
            // 
            // btnReturnOrdersDelete
            // 
            this.btnReturnOrdersDelete.Location = new System.Drawing.Point(220, 103);
            this.btnReturnOrdersDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnOrdersDelete.Name = "btnReturnOrdersDelete";
            this.btnReturnOrdersDelete.Size = new System.Drawing.Size(116, 32);
            this.btnReturnOrdersDelete.TabIndex = 60;
            this.btnReturnOrdersDelete.Text = "Return";
            this.btnReturnOrdersDelete.UseVisualStyleBackColor = true;
            this.btnReturnOrdersDelete.Click += new System.EventHandler(this.btnReturnOrdersDelete_Click);
            // 
            // btnResetOrdersDelete
            // 
            this.btnResetOrdersDelete.Location = new System.Drawing.Point(220, 66);
            this.btnResetOrdersDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetOrdersDelete.Name = "btnResetOrdersDelete";
            this.btnResetOrdersDelete.Size = new System.Drawing.Size(116, 32);
            this.btnResetOrdersDelete.TabIndex = 61;
            this.btnResetOrdersDelete.Text = "Reset";
            this.btnResetOrdersDelete.UseVisualStyleBackColor = true;
            this.btnResetOrdersDelete.Click += new System.EventHandler(this.btnResetOrdersDelete_Click);
            // 
            // btnOrdersDeleteGo
            // 
            this.btnOrdersDeleteGo.Location = new System.Drawing.Point(220, 11);
            this.btnOrdersDeleteGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdersDeleteGo.Name = "btnOrdersDeleteGo";
            this.btnOrdersDeleteGo.Size = new System.Drawing.Size(116, 50);
            this.btnOrdersDeleteGo.TabIndex = 62;
            this.btnOrdersDeleteGo.Text = "Delete";
            this.btnOrdersDeleteGo.UseVisualStyleBackColor = true;
            this.btnOrdersDeleteGo.Click += new System.EventHandler(this.btnOrdersDeleteGo_Click);
            // 
            // txtIDOrdersDelete
            // 
            this.txtIDOrdersDelete.Location = new System.Drawing.Point(64, 46);
            this.txtIDOrdersDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDOrdersDelete.Name = "txtIDOrdersDelete";
            this.txtIDOrdersDelete.Size = new System.Drawing.Size(102, 20);
            this.txtIDOrdersDelete.TabIndex = 53;
            // 
            // lblOrdersDeleteTitle
            // 
            this.lblOrdersDeleteTitle.AutoSize = true;
            this.lblOrdersDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersDeleteTitle.Location = new System.Drawing.Point(9, 7);
            this.lblOrdersDeleteTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersDeleteTitle.Name = "lblOrdersDeleteTitle";
            this.lblOrdersDeleteTitle.Size = new System.Drawing.Size(139, 26);
            this.lblOrdersDeleteTitle.TabIndex = 49;
            this.lblOrdersDeleteTitle.Text = "Delete Fields";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 49);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(47, 13);
            this.lblOrderID.TabIndex = 63;
            this.lblOrderID.Text = "Order ID";
            // 
            // OrdersDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 185);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnExitOrdersDelete);
            this.Controls.Add(this.btnReturnOrdersDelete);
            this.Controls.Add(this.btnResetOrdersDelete);
            this.Controls.Add(this.btnOrdersDeleteGo);
            this.Controls.Add(this.txtIDOrdersDelete);
            this.Controls.Add(this.lblOrdersDeleteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrdersDelete";
            this.Text = "OrdersDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitOrdersDelete;
        private System.Windows.Forms.Button btnReturnOrdersDelete;
        private System.Windows.Forms.Button btnResetOrdersDelete;
        private System.Windows.Forms.Button btnOrdersDeleteGo;
        private System.Windows.Forms.TextBox txtIDOrdersDelete;
        private System.Windows.Forms.Label lblOrdersDeleteTitle;
        private System.Windows.Forms.Label lblOrderID;
    }
}