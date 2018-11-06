namespace TeamDevProject
{
    partial class OrdersMain
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
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.btnOrdersExit = new System.Windows.Forms.Button();
            this.btnOrdersReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDelete.Location = new System.Drawing.Point(74, 219);
            this.btnOrderDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(86, 36);
            this.btnOrderDelete.TabIndex = 10;
            this.btnOrderDelete.Text = "Delete";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAdd.Location = new System.Drawing.Point(18, 163);
            this.btnOrderAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(86, 36);
            this.btnOrderAdd.TabIndex = 9;
            this.btnOrderAdd.Text = "Add";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderSearch.Location = new System.Drawing.Point(152, 163);
            this.btnOrderSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(86, 36);
            this.btnOrderSearch.TabIndex = 8;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(11, 11);
            this.lblOrdersTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(113, 40);
            this.lblOrdersTitle.TabIndex = 6;
            this.lblOrdersTitle.Text = "Orders";
            // 
            // btnOrdersExit
            // 
            this.btnOrdersExit.Location = new System.Drawing.Point(112, 273);
            this.btnOrdersExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdersExit.Name = "btnOrdersExit";
            this.btnOrdersExit.Size = new System.Drawing.Size(63, 27);
            this.btnOrdersExit.TabIndex = 18;
            this.btnOrdersExit.Text = "Exit";
            this.btnOrdersExit.UseVisualStyleBackColor = true;
            this.btnOrdersExit.Click += new System.EventHandler(this.btnOrdersExit_Click);
            // 
            // btnOrdersReturn
            // 
            this.btnOrdersReturn.Location = new System.Drawing.Point(40, 273);
            this.btnOrdersReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdersReturn.Name = "btnOrdersReturn";
            this.btnOrdersReturn.Size = new System.Drawing.Size(63, 27);
            this.btnOrdersReturn.TabIndex = 19;
            this.btnOrdersReturn.Text = "Return";
            this.btnOrdersReturn.UseVisualStyleBackColor = true;
            this.btnOrdersReturn.Click += new System.EventHandler(this.btnOrdersReturn_Click);
            // 
            // OrdersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 446);
            this.Controls.Add(this.btnOrdersExit);
            this.Controls.Add(this.btnOrdersReturn);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.btnOrderSearch);
            this.Controls.Add(this.lblOrdersTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdersMain";
            this.Text = "OrdersMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Button btnOrdersExit;
        private System.Windows.Forms.Button btnOrdersReturn;
    }
}