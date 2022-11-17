﻿
namespace KaingaRealEstate
{
    partial class RemoveBuyerCategoryForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveBuyerCategory = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCategoriesAssigned = new System.Windows.Forms.Label();
            this.lblCreditStatus = new System.Windows.Forms.Label();
            this.cboBuyer = new System.Windows.Forms.ComboBox();
            this.txtBuyerID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCreditStatus = new System.Windows.Forms.TextBox();
            this.lstCategoriesAssigned = new System.Windows.Forms.ListBox();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(412, 469);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(231, 48);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemoveBuyerCategory
            // 
            this.btnRemoveBuyerCategory.Location = new System.Drawing.Point(69, 469);
            this.btnRemoveBuyerCategory.Name = "btnRemoveBuyerCategory";
            this.btnRemoveBuyerCategory.Size = new System.Drawing.Size(231, 48);
            this.btnRemoveBuyerCategory.TabIndex = 7;
            this.btnRemoveBuyerCategory.Text = "Remove Buyer Category";
            this.btnRemoveBuyerCategory.UseVisualStyleBackColor = true;
            this.btnRemoveBuyerCategory.Click += new System.EventHandler(this.btnRemoveBuyerCategory_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Remove Buyer Category";
            // 
            // lblBuyer
            // 
            this.lblBuyer.Location = new System.Drawing.Point(123, 106);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(63, 24);
            this.lblBuyer.TabIndex = 9;
            this.lblBuyer.Text = "Buyer:";
            this.lblBuyer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.Location = new System.Drawing.Point(101, 154);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(85, 24);
            this.lblBuyerID.TabIndex = 10;
            this.lblBuyerID.Text = "Buyer ID:";
            this.lblBuyerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(84, 202);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(81, 250);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategoriesAssigned
            // 
            this.lblCategoriesAssigned.Location = new System.Drawing.Point(4, 352);
            this.lblCategoriesAssigned.Name = "lblCategoriesAssigned";
            this.lblCategoriesAssigned.Size = new System.Drawing.Size(182, 24);
            this.lblCategoriesAssigned.TabIndex = 13;
            this.lblCategoriesAssigned.Text = "Categories Assigned:";
            this.lblCategoriesAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreditStatus
            // 
            this.lblCreditStatus.Location = new System.Drawing.Point(63, 298);
            this.lblCreditStatus.Name = "lblCreditStatus";
            this.lblCreditStatus.Size = new System.Drawing.Size(123, 24);
            this.lblCreditStatus.TabIndex = 14;
            this.lblCreditStatus.Text = "Credit Status:";
            this.lblCreditStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBuyer
            // 
            this.cboBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuyer.FormattingEnabled = true;
            this.cboBuyer.Location = new System.Drawing.Point(199, 103);
            this.cboBuyer.Name = "cboBuyer";
            this.cboBuyer.Size = new System.Drawing.Size(444, 32);
            this.cboBuyer.TabIndex = 15;
            this.cboBuyer.SelectedIndexChanged += new System.EventHandler(this.cboBuyer_SelectedIndexChanged);
            // 
            // txtBuyerID
            // 
            this.txtBuyerID.Location = new System.Drawing.Point(199, 151);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(79, 32);
            this.txtBuyerID.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(199, 199);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(272, 32);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(199, 247);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(272, 32);
            this.txtFirstName.TabIndex = 18;
            // 
            // txtCreditStatus
            // 
            this.txtCreditStatus.Location = new System.Drawing.Point(199, 295);
            this.txtCreditStatus.Name = "txtCreditStatus";
            this.txtCreditStatus.ReadOnly = true;
            this.txtCreditStatus.Size = new System.Drawing.Size(79, 32);
            this.txtCreditStatus.TabIndex = 19;
            // 
            // lstCategoriesAssigned
            // 
            this.lstCategoriesAssigned.FormattingEnabled = true;
            this.lstCategoriesAssigned.ItemHeight = 24;
            this.lstCategoriesAssigned.Location = new System.Drawing.Point(199, 352);
            this.lstCategoriesAssigned.Name = "lstCategoriesAssigned";
            this.lstCategoriesAssigned.Size = new System.Drawing.Size(474, 100);
            this.lstCategoriesAssigned.TabIndex = 20;
            this.lstCategoriesAssigned.SelectedIndexChanged += new System.EventHandler(this.lstCategoriesAssigned_SelectedIndexChanged);
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(195, 76);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(207, 24);
            this.lblPleaseSelectAnOption.TabIndex = 90;
            this.lblPleaseSelectAnOption.Text = "*Please select an option";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequired.Location = new System.Drawing.Point(179, 352);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(20, 24);
            this.lblRequired.TabIndex = 91;
            this.lblRequired.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(179, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "*";
            // 
            // RemoveBuyerCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.lstCategoriesAssigned);
            this.Controls.Add(this.txtCreditStatus);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBuyerID);
            this.Controls.Add(this.cboBuyer);
            this.Controls.Add(this.lblCreditStatus);
            this.Controls.Add(this.lblCategoriesAssigned);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblBuyerID);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBuyerCategory);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveBuyerCategoryForm";
            this.Text = "Remove Buyer Category";
            this.Load += new System.EventHandler(this.RemoveBuyerCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveBuyerCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCategoriesAssigned;
        private System.Windows.Forms.Label lblCreditStatus;
        private System.Windows.Forms.ComboBox cboBuyer;
        private System.Windows.Forms.TextBox txtBuyerID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCreditStatus;
        private System.Windows.Forms.ListBox lstCategoriesAssigned;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label label1;
    }
}