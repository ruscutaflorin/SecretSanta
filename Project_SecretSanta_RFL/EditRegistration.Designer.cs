namespace Project_SecretSanta_RFL
{
    partial class EditRegistration
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxGift = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelGift = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(33, 202);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(250, 47);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxGift
            // 
            this.textBoxGift.Location = new System.Drawing.Point(142, 147);
            this.textBoxGift.Name = "textBoxGift";
            this.textBoxGift.Size = new System.Drawing.Size(141, 20);
            this.textBoxGift.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(142, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(141, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelGift
            // 
            this.labelGift.AutoSize = true;
            this.labelGift.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGift.Location = new System.Drawing.Point(30, 147);
            this.labelGift.Name = "labelGift";
            this.labelGift.Size = new System.Drawing.Size(106, 16);
            this.labelGift.TabIndex = 9;
            this.labelGift.Text = "Preferred Gift:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(30, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(97, 16);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email Adress:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(30, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Full Name:";
            // 
            // EditRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 288);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxGift);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelGift);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "EditRegistration";
            this.Text = "EditRegistration";
            this.Load += new System.EventHandler(this.EditRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxGift;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGift;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
    }
}