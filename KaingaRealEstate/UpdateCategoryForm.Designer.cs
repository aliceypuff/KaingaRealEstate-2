
namespace KaingaRealEstate
{
    partial class UpdateCategoryForm
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
            this.components = new System.ComponentModel.Container();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPleaseSelectAnOption = new System.Windows.Forms.Label();
            this.errorProviderDetails = new System.Windows.Forms.ErrorProvider(this.components);
            this.kaingaRealEstateDataSet = new KaingaRealEstate.KaingaRealEstateDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtSuburbName = new System.Windows.Forms.TextBox();
            this.txtSuburbID = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblCatDesc = new System.Windows.Forms.Label();
            this.lblSuburbID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateSuburb = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(164, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 19);
            this.label11.TabIndex = 189;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(183, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 19);
            this.label9.TabIndex = 188;
            this.label9.Text = "*Cannot be left blank";
            // 
            // lblPleaseSelectAnOption
            // 
            this.lblPleaseSelectAnOption.AutoSize = true;
            this.lblPleaseSelectAnOption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelectAnOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPleaseSelectAnOption.Location = new System.Drawing.Point(183, 77);
            this.lblPleaseSelectAnOption.Name = "lblPleaseSelectAnOption";
            this.lblPleaseSelectAnOption.Size = new System.Drawing.Size(165, 19);
            this.lblPleaseSelectAnOption.TabIndex = 187;
            this.lblPleaseSelectAnOption.Text = "Please select a category";
            // 
            // errorProviderDetails
            // 
            this.errorProviderDetails.ContainerControl = this;
            // 
            // kaingaRealEstateDataSet
            // 
            this.kaingaRealEstateDataSet.DataSetName = "KaingaRealEstateDataSet";
            this.kaingaRealEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(164, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 19);
            this.label12.TabIndex = 190;
            this.label12.Text = "*";
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostcode.Location = new System.Drawing.Point(186, 248);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(42, 27);
            this.txtPostcode.TabIndex = 186;
            // 
            // txtSuburbName
            // 
            this.txtSuburbName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSuburbName.Location = new System.Drawing.Point(187, 200);
            this.txtSuburbName.Name = "txtSuburbName";
            this.txtSuburbName.Size = new System.Drawing.Size(246, 27);
            this.txtSuburbName.TabIndex = 185;
            // 
            // txtSuburbID
            // 
            this.txtSuburbID.Location = new System.Drawing.Point(186, 152);
            this.txtSuburbID.Name = "txtSuburbID";
            this.txtSuburbID.ReadOnly = true;
            this.txtSuburbID.Size = new System.Drawing.Size(79, 27);
            this.txtSuburbID.TabIndex = 184;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(186, 104);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(473, 27);
            this.cboCategory.TabIndex = 183;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboSuburb_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(120, 251);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(47, 19);
            this.lblLevel.TabIndex = 182;
            this.lblLevel.Text = "Level:";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCatDesc
            // 
            this.lblCatDesc.AutoSize = true;
            this.lblCatDesc.Location = new System.Drawing.Point(18, 203);
            this.lblCatDesc.Name = "lblCatDesc";
            this.lblCatDesc.Size = new System.Drawing.Size(149, 19);
            this.lblCatDesc.TabIndex = 181;
            this.lblCatDesc.Text = "Category Description:";
            this.lblCatDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSuburbID
            // 
            this.lblSuburbID.AutoSize = true;
            this.lblSuburbID.Location = new System.Drawing.Point(92, 155);
            this.lblSuburbID.Name = "lblSuburbID";
            this.lblSuburbID.Size = new System.Drawing.Size(75, 19);
            this.lblSuburbID.TabIndex = 180;
            this.lblSuburbID.Text = "Suburb ID:";
            this.lblSuburbID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(96, 107);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(71, 19);
            this.lblCategory.TabIndex = 179;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(325, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 48);
            this.btnReturn.TabIndex = 178;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateSuburb
            // 
            this.btnUpdateSuburb.Location = new System.Drawing.Point(50, 343);
            this.btnUpdateSuburb.Name = "btnUpdateSuburb";
            this.btnUpdateSuburb.Size = new System.Drawing.Size(196, 48);
            this.btnUpdateSuburb.TabIndex = 177;
            this.btnUpdateSuburb.Text = "Update Suburb";
            this.btnUpdateSuburb.UseVisualStyleBackColor = true;
            this.btnUpdateSuburb.Click += new System.EventHandler(this.btnUpdateSuburb_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(190, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 29);
            this.lblTitle.TabIndex = 176;
            this.lblTitle.Text = "Update Category";
            // 
            // UpdateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 413);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPleaseSelectAnOption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtSuburbName);
            this.Controls.Add(this.txtSuburbID);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblCatDesc);
            this.Controls.Add(this.lblSuburbID);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateSuburb);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateCategoryForm";
            this.Text = "Update Categories";
            this.Load += new System.EventHandler(this.UpdateCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaingaRealEstateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPleaseSelectAnOption;
        private System.Windows.Forms.ErrorProvider errorProviderDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtSuburbName;
        private System.Windows.Forms.TextBox txtSuburbID;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblCatDesc;
        private System.Windows.Forms.Label lblSuburbID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateSuburb;
        private System.Windows.Forms.Label lblTitle;
        private KaingaRealEstateDataSet kaingaRealEstateDataSet;
    }
}