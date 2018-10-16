namespace TeamDevProject
{
    partial class CustomersAdd
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
            this.lblCustomerAddTitle = new System.Windows.Forms.Label();
            this.cbxFNameOnCustomerAdd = new System.Windows.Forms.CheckBox();
            this.cbxLNameOnCustomerAdd = new System.Windows.Forms.CheckBox();
            this.txtLNameCustomerAdd = new System.Windows.Forms.TextBox();
            this.txtFNameCustomerAdd = new System.Windows.Forms.TextBox();
            this.cbxLNameNullCustomerAdd = new System.Windows.Forms.CheckBox();
            this.cbxFNameNullCustomerAdd = new System.Windows.Forms.CheckBox();
            this.btnExitCustomerAdd = new System.Windows.Forms.Button();
            this.btnReturnCustomerAdd = new System.Windows.Forms.Button();
            this.btnResetCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerAddGo = new System.Windows.Forms.Button();
            this.cbxEMailOnCustomerAdd = new System.Windows.Forms.CheckBox();
            this.txtEMailCustomerAdd = new System.Windows.Forms.TextBox();
            this.cbxEMailNullCustomerAdd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCustomerAddTitle
            // 
            this.lblCustomerAddTitle.AutoSize = true;
            this.lblCustomerAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerAddTitle.Name = "lblCustomerAddTitle";
            this.lblCustomerAddTitle.Size = new System.Drawing.Size(150, 32);
            this.lblCustomerAddTitle.TabIndex = 0;
            this.lblCustomerAddTitle.Text = "Add Fields";
            // 
            // cbxFNameOnCustomerAdd
            // 
            this.cbxFNameOnCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFNameOnCustomerAdd.AutoSize = true;
            this.cbxFNameOnCustomerAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxFNameOnCustomerAdd.Location = new System.Drawing.Point(18, 57);
            this.cbxFNameOnCustomerAdd.Name = "cbxFNameOnCustomerAdd";
            this.cbxFNameOnCustomerAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxFNameOnCustomerAdd.Size = new System.Drawing.Size(98, 21);
            this.cbxFNameOnCustomerAdd.TabIndex = 2;
            this.cbxFNameOnCustomerAdd.Text = "First Name";
            this.cbxFNameOnCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxFNameOnCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxFNameOnCustomerAdd_CheckedChanged);
            // 
            // cbxLNameOnCustomerAdd
            // 
            this.cbxLNameOnCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLNameOnCustomerAdd.AutoSize = true;
            this.cbxLNameOnCustomerAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxLNameOnCustomerAdd.Location = new System.Drawing.Point(18, 95);
            this.cbxLNameOnCustomerAdd.Name = "cbxLNameOnCustomerAdd";
            this.cbxLNameOnCustomerAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxLNameOnCustomerAdd.Size = new System.Drawing.Size(98, 21);
            this.cbxLNameOnCustomerAdd.TabIndex = 5;
            this.cbxLNameOnCustomerAdd.Text = "Last Name";
            this.cbxLNameOnCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxLNameOnCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxLNameOnCustomerAdd_CheckedChanged);
            // 
            // txtLNameCustomerAdd
            // 
            this.txtLNameCustomerAdd.Enabled = false;
            this.txtLNameCustomerAdd.Location = new System.Drawing.Point(122, 95);
            this.txtLNameCustomerAdd.Name = "txtLNameCustomerAdd";
            this.txtLNameCustomerAdd.Size = new System.Drawing.Size(135, 22);
            this.txtLNameCustomerAdd.TabIndex = 8;
            // 
            // txtFNameCustomerAdd
            // 
            this.txtFNameCustomerAdd.Enabled = false;
            this.txtFNameCustomerAdd.Location = new System.Drawing.Point(122, 56);
            this.txtFNameCustomerAdd.Name = "txtFNameCustomerAdd";
            this.txtFNameCustomerAdd.Size = new System.Drawing.Size(135, 22);
            this.txtFNameCustomerAdd.TabIndex = 9;
            // 
            // cbxLNameNullCustomerAdd
            // 
            this.cbxLNameNullCustomerAdd.Enabled = false;
            this.cbxLNameNullCustomerAdd.Location = new System.Drawing.Point(263, 95);
            this.cbxLNameNullCustomerAdd.Name = "cbxLNameNullCustomerAdd";
            this.cbxLNameNullCustomerAdd.Size = new System.Drawing.Size(98, 21);
            this.cbxLNameNullCustomerAdd.TabIndex = 12;
            this.cbxLNameNullCustomerAdd.Text = "Null";
            this.cbxLNameNullCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxLNameNullCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxLNameNullCustomerAdd_CheckedChanged);
            // 
            // cbxFNameNullCustomerAdd
            // 
            this.cbxFNameNullCustomerAdd.Enabled = false;
            this.cbxFNameNullCustomerAdd.Location = new System.Drawing.Point(263, 56);
            this.cbxFNameNullCustomerAdd.Name = "cbxFNameNullCustomerAdd";
            this.cbxFNameNullCustomerAdd.Size = new System.Drawing.Size(98, 21);
            this.cbxFNameNullCustomerAdd.TabIndex = 13;
            this.cbxFNameNullCustomerAdd.Text = "Null";
            this.cbxFNameNullCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxFNameNullCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxFNameNullCustomerAdd_CheckedChanged);
            // 
            // btnExitCustomerAdd
            // 
            this.btnExitCustomerAdd.Location = new System.Drawing.Point(416, 173);
            this.btnExitCustomerAdd.Name = "btnExitCustomerAdd";
            this.btnExitCustomerAdd.Size = new System.Drawing.Size(154, 39);
            this.btnExitCustomerAdd.TabIndex = 14;
            this.btnExitCustomerAdd.Text = "Exit";
            this.btnExitCustomerAdd.UseVisualStyleBackColor = true;
            this.btnExitCustomerAdd.Click += new System.EventHandler(this.btnExitCustomerAdd_Click);
            // 
            // btnReturnCustomerAdd
            // 
            this.btnReturnCustomerAdd.Location = new System.Drawing.Point(416, 128);
            this.btnReturnCustomerAdd.Name = "btnReturnCustomerAdd";
            this.btnReturnCustomerAdd.Size = new System.Drawing.Size(154, 39);
            this.btnReturnCustomerAdd.TabIndex = 15;
            this.btnReturnCustomerAdd.Text = "Return";
            this.btnReturnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnReturnCustomerAdd.Click += new System.EventHandler(this.btnReturnCustomerAdd_Click);
            // 
            // btnResetCustomerAdd
            // 
            this.btnResetCustomerAdd.Location = new System.Drawing.Point(416, 83);
            this.btnResetCustomerAdd.Name = "btnResetCustomerAdd";
            this.btnResetCustomerAdd.Size = new System.Drawing.Size(154, 39);
            this.btnResetCustomerAdd.TabIndex = 16;
            this.btnResetCustomerAdd.Text = "Reset";
            this.btnResetCustomerAdd.UseVisualStyleBackColor = true;
            this.btnResetCustomerAdd.Click += new System.EventHandler(this.btnResetCustomerAdd_Click);
            // 
            // btnCustomerAddGo
            // 
            this.btnCustomerAddGo.Location = new System.Drawing.Point(416, 15);
            this.btnCustomerAddGo.Name = "btnCustomerAddGo";
            this.btnCustomerAddGo.Size = new System.Drawing.Size(154, 62);
            this.btnCustomerAddGo.TabIndex = 17;
            this.btnCustomerAddGo.Text = "Add";
            this.btnCustomerAddGo.UseVisualStyleBackColor = true;
            // 
            // cbxEMailOnCustomerAdd
            // 
            this.cbxEMailOnCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEMailOnCustomerAdd.AutoSize = true;
            this.cbxEMailOnCustomerAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxEMailOnCustomerAdd.Location = new System.Drawing.Point(52, 137);
            this.cbxEMailOnCustomerAdd.Name = "cbxEMailOnCustomerAdd";
            this.cbxEMailOnCustomerAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxEMailOnCustomerAdd.Size = new System.Drawing.Size(64, 21);
            this.cbxEMailOnCustomerAdd.TabIndex = 4;
            this.cbxEMailOnCustomerAdd.Text = "EMail";
            this.cbxEMailOnCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxEMailOnCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxEMailOnCustomerAdd_CheckedChanged);
            // 
            // txtEMailCustomerAdd
            // 
            this.txtEMailCustomerAdd.Enabled = false;
            this.txtEMailCustomerAdd.Location = new System.Drawing.Point(122, 136);
            this.txtEMailCustomerAdd.Name = "txtEMailCustomerAdd";
            this.txtEMailCustomerAdd.Size = new System.Drawing.Size(135, 22);
            this.txtEMailCustomerAdd.TabIndex = 7;
            // 
            // cbxEMailNullCustomerAdd
            // 
            this.cbxEMailNullCustomerAdd.Enabled = false;
            this.cbxEMailNullCustomerAdd.Location = new System.Drawing.Point(263, 136);
            this.cbxEMailNullCustomerAdd.Name = "cbxEMailNullCustomerAdd";
            this.cbxEMailNullCustomerAdd.Size = new System.Drawing.Size(98, 21);
            this.cbxEMailNullCustomerAdd.TabIndex = 11;
            this.cbxEMailNullCustomerAdd.Text = "Null";
            this.cbxEMailNullCustomerAdd.UseVisualStyleBackColor = true;
            this.cbxEMailNullCustomerAdd.CheckedChanged += new System.EventHandler(this.cbxEMailNullCustomerAdd_CheckedChanged);
            // 
            // CustomersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 228);
            this.Controls.Add(this.btnExitCustomerAdd);
            this.Controls.Add(this.btnReturnCustomerAdd);
            this.Controls.Add(this.btnResetCustomerAdd);
            this.Controls.Add(this.btnCustomerAddGo);
            this.Controls.Add(this.cbxEMailNullCustomerAdd);
            this.Controls.Add(this.cbxLNameNullCustomerAdd);
            this.Controls.Add(this.cbxFNameNullCustomerAdd);
            this.Controls.Add(this.txtEMailCustomerAdd);
            this.Controls.Add(this.txtLNameCustomerAdd);
            this.Controls.Add(this.txtFNameCustomerAdd);
            this.Controls.Add(this.cbxEMailOnCustomerAdd);
            this.Controls.Add(this.cbxLNameOnCustomerAdd);
            this.Controls.Add(this.cbxFNameOnCustomerAdd);
            this.Controls.Add(this.lblCustomerAddTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomersAdd";
            this.Text = "CustomersAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerAddTitle;
        private System.Windows.Forms.CheckBox cbxFNameOnCustomerAdd;
        private System.Windows.Forms.CheckBox cbxLNameOnCustomerAdd;
        private System.Windows.Forms.TextBox txtLNameCustomerAdd;
        private System.Windows.Forms.TextBox txtFNameCustomerAdd;
        private System.Windows.Forms.CheckBox cbxLNameNullCustomerAdd;
        private System.Windows.Forms.CheckBox cbxFNameNullCustomerAdd;
        private System.Windows.Forms.Button btnExitCustomerAdd;
        private System.Windows.Forms.Button btnReturnCustomerAdd;
        private System.Windows.Forms.Button btnResetCustomerAdd;
        private System.Windows.Forms.Button btnCustomerAddGo;
        private System.Windows.Forms.CheckBox cbxEMailOnCustomerAdd;
        private System.Windows.Forms.TextBox txtEMailCustomerAdd;
        private System.Windows.Forms.CheckBox cbxEMailNullCustomerAdd;
    }
}