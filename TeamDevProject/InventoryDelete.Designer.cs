namespace TeamDevProject
{
    partial class InventoryDelete
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
            this.btnReturnInventoryDelete = new System.Windows.Forms.Button();
            this.btnResetInventoryDelete = new System.Windows.Forms.Button();
            this.btnInventoryDeleteGo = new System.Windows.Forms.Button();
            this.txtIDInventoryDelete = new System.Windows.Forms.TextBox();
            this.lblInventoryDeleteTitle = new System.Windows.Forms.Label();
            this.lblInventoryDeleteID = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnInventoryDelete
            // 
            this.btnReturnInventoryDelete.Location = new System.Drawing.Point(212, 103);
            this.btnReturnInventoryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnInventoryDelete.Name = "btnReturnInventoryDelete";
            this.btnReturnInventoryDelete.Size = new System.Drawing.Size(116, 32);
            this.btnReturnInventoryDelete.TabIndex = 3;
            this.btnReturnInventoryDelete.Text = "Return";
            this.btnReturnInventoryDelete.UseVisualStyleBackColor = true;
            this.btnReturnInventoryDelete.Click += new System.EventHandler(this.btnReturnInventoryDelete_Click);
            // 
            // btnResetInventoryDelete
            // 
            this.btnResetInventoryDelete.Location = new System.Drawing.Point(212, 66);
            this.btnResetInventoryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetInventoryDelete.Name = "btnResetInventoryDelete";
            this.btnResetInventoryDelete.Size = new System.Drawing.Size(116, 32);
            this.btnResetInventoryDelete.TabIndex = 2;
            this.btnResetInventoryDelete.Text = "Reset";
            this.btnResetInventoryDelete.UseVisualStyleBackColor = true;
            this.btnResetInventoryDelete.Click += new System.EventHandler(this.btnResetInventoryDelete_Click);
            // 
            // btnInventoryDeleteGo
            // 
            this.btnInventoryDeleteGo.Location = new System.Drawing.Point(212, 11);
            this.btnInventoryDeleteGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryDeleteGo.Name = "btnInventoryDeleteGo";
            this.btnInventoryDeleteGo.Size = new System.Drawing.Size(116, 50);
            this.btnInventoryDeleteGo.TabIndex = 1;
            this.btnInventoryDeleteGo.Text = "Delete";
            this.btnInventoryDeleteGo.UseVisualStyleBackColor = true;
            this.btnInventoryDeleteGo.Click += new System.EventHandler(this.btnInventoryDeleteGo_Click);
            // 
            // txtIDInventoryDelete
            // 
            this.txtIDInventoryDelete.Location = new System.Drawing.Point(99, 67);
            this.txtIDInventoryDelete.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDInventoryDelete.Name = "txtIDInventoryDelete";
            this.txtIDInventoryDelete.Size = new System.Drawing.Size(49, 20);
            this.txtIDInventoryDelete.TabIndex = 0;
            this.txtIDInventoryDelete.Click += new System.EventHandler(this.txtIDInventoryDelete_Click);
            // 
            // lblInventoryDeleteTitle
            // 
            this.lblInventoryDeleteTitle.AutoSize = true;
            this.lblInventoryDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryDeleteTitle.Location = new System.Drawing.Point(9, 7);
            this.lblInventoryDeleteTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventoryDeleteTitle.Name = "lblInventoryDeleteTitle";
            this.lblInventoryDeleteTitle.Size = new System.Drawing.Size(139, 26);
            this.lblInventoryDeleteTitle.TabIndex = 32;
            this.lblInventoryDeleteTitle.Text = "Delete Fields";
            // 
            // lblInventoryDeleteID
            // 
            this.lblInventoryDeleteID.AutoSize = true;
            this.lblInventoryDeleteID.Location = new System.Drawing.Point(29, 70);
            this.lblInventoryDeleteID.Name = "lblInventoryDeleteID";
            this.lblInventoryDeleteID.Size = new System.Drawing.Size(65, 13);
            this.lblInventoryDeleteID.TabIndex = 49;
            this.lblInventoryDeleteID.Text = "Inventory ID";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(5, 113);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.TabIndex = 50;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // InventoryDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(339, 140);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblInventoryDeleteID);
            this.Controls.Add(this.btnReturnInventoryDelete);
            this.Controls.Add(this.btnResetInventoryDelete);
            this.Controls.Add(this.btnInventoryDeleteGo);
            this.Controls.Add(this.txtIDInventoryDelete);
            this.Controls.Add(this.lblInventoryDeleteTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryDelete";
            this.Text = "Delete Inventory Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnInventoryDelete;
        private System.Windows.Forms.Button btnResetInventoryDelete;
        private System.Windows.Forms.Button btnInventoryDeleteGo;
        private System.Windows.Forms.TextBox txtIDInventoryDelete;
        private System.Windows.Forms.Label lblInventoryDeleteTitle;
        private System.Windows.Forms.Label lblInventoryDeleteID;
        private System.Windows.Forms.Button btnHelp;
    }
}