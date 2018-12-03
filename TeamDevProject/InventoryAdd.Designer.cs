namespace TeamDevProject
{
    partial class InventoryAdd
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
            this.btnReturnInventoryAdd = new System.Windows.Forms.Button();
            this.btnResetInventoryAdd = new System.Windows.Forms.Button();
            this.btnInventoryAddGo = new System.Windows.Forms.Button();
            this.txtPriceInventoryAdd = new System.Windows.Forms.TextBox();
            this.txtNameInventoryAdd = new System.Windows.Forms.TextBox();
            this.lblInventoryAddTitle = new System.Windows.Forms.Label();
            this.lblInventoryAddPrice = new System.Windows.Forms.Label();
            this.lblInventoryAddItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnInventoryAdd
            // 
            this.btnReturnInventoryAdd.Location = new System.Drawing.Point(312, 104);
            this.btnReturnInventoryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnInventoryAdd.Name = "btnReturnInventoryAdd";
            this.btnReturnInventoryAdd.Size = new System.Drawing.Size(116, 32);
            this.btnReturnInventoryAdd.TabIndex = 4;
            this.btnReturnInventoryAdd.Text = "Return";
            this.btnReturnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnReturnInventoryAdd.Click += new System.EventHandler(this.btnReturnInventoryAdd_Click);
            // 
            // btnResetInventoryAdd
            // 
            this.btnResetInventoryAdd.Location = new System.Drawing.Point(312, 67);
            this.btnResetInventoryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetInventoryAdd.Name = "btnResetInventoryAdd";
            this.btnResetInventoryAdd.Size = new System.Drawing.Size(116, 32);
            this.btnResetInventoryAdd.TabIndex = 3;
            this.btnResetInventoryAdd.Text = "Reset";
            this.btnResetInventoryAdd.UseVisualStyleBackColor = true;
            this.btnResetInventoryAdd.Click += new System.EventHandler(this.btnResetInventoryAdd_Click);
            // 
            // btnInventoryAddGo
            // 
            this.btnInventoryAddGo.Location = new System.Drawing.Point(312, 12);
            this.btnInventoryAddGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryAddGo.Name = "btnInventoryAddGo";
            this.btnInventoryAddGo.Size = new System.Drawing.Size(116, 50);
            this.btnInventoryAddGo.TabIndex = 2;
            this.btnInventoryAddGo.Text = "Add";
            this.btnInventoryAddGo.UseVisualStyleBackColor = true;
            this.btnInventoryAddGo.Click += new System.EventHandler(this.btnInventoryAddGo_Click);
            // 
            // txtPriceInventoryAdd
            // 
            this.txtPriceInventoryAdd.Location = new System.Drawing.Point(92, 77);
            this.txtPriceInventoryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPriceInventoryAdd.Name = "txtPriceInventoryAdd";
            this.txtPriceInventoryAdd.Size = new System.Drawing.Size(102, 20);
            this.txtPriceInventoryAdd.TabIndex = 1;
            // 
            // txtNameInventoryAdd
            // 
            this.txtNameInventoryAdd.Location = new System.Drawing.Point(92, 46);
            this.txtNameInventoryAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameInventoryAdd.Name = "txtNameInventoryAdd";
            this.txtNameInventoryAdd.Size = new System.Drawing.Size(102, 20);
            this.txtNameInventoryAdd.TabIndex = 0;
            // 
            // lblInventoryAddTitle
            // 
            this.lblInventoryAddTitle.AutoSize = true;
            this.lblInventoryAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryAddTitle.Location = new System.Drawing.Point(9, 7);
            this.lblInventoryAddTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventoryAddTitle.Name = "lblInventoryAddTitle";
            this.lblInventoryAddTitle.Size = new System.Drawing.Size(115, 26);
            this.lblInventoryAddTitle.TabIndex = 18;
            this.lblInventoryAddTitle.Text = "Add Fields";
            // 
            // lblInventoryAddPrice
            // 
            this.lblInventoryAddPrice.AutoSize = true;
            this.lblInventoryAddPrice.Location = new System.Drawing.Point(47, 80);
            this.lblInventoryAddPrice.Name = "lblInventoryAddPrice";
            this.lblInventoryAddPrice.Size = new System.Drawing.Size(31, 13);
            this.lblInventoryAddPrice.TabIndex = 32;
            this.lblInventoryAddPrice.Text = "Price";
            // 
            // lblInventoryAddItemName
            // 
            this.lblInventoryAddItemName.AutoSize = true;
            this.lblInventoryAddItemName.Location = new System.Drawing.Point(20, 49);
            this.lblInventoryAddItemName.Name = "lblInventoryAddItemName";
            this.lblInventoryAddItemName.Size = new System.Drawing.Size(58, 13);
            this.lblInventoryAddItemName.TabIndex = 33;
            this.lblInventoryAddItemName.Text = "Item Name";
            // 
            // InventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(468, 150);
            this.Controls.Add(this.lblInventoryAddPrice);
            this.Controls.Add(this.lblInventoryAddItemName);
            this.Controls.Add(this.btnReturnInventoryAdd);
            this.Controls.Add(this.btnResetInventoryAdd);
            this.Controls.Add(this.btnInventoryAddGo);
            this.Controls.Add(this.txtPriceInventoryAdd);
            this.Controls.Add(this.txtNameInventoryAdd);
            this.Controls.Add(this.lblInventoryAddTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryAdd";
            this.Text = "Add Inventory Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnInventoryAdd;
        private System.Windows.Forms.Button btnResetInventoryAdd;
        private System.Windows.Forms.Button btnInventoryAddGo;
        private System.Windows.Forms.TextBox txtPriceInventoryAdd;
        private System.Windows.Forms.TextBox txtNameInventoryAdd;
        private System.Windows.Forms.Label lblInventoryAddTitle;
        private System.Windows.Forms.Label lblInventoryAddPrice;
        private System.Windows.Forms.Label lblInventoryAddItemName;
    }
}