namespace Project_SecretSanta_RFL
{
    partial class RegistrationForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelGift = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxGift = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(77, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Full Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(31, 89);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(97, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email Adress:";
            // 
            // labelGift
            // 
            this.labelGift.AutoSize = true;
            this.labelGift.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGift.Location = new System.Drawing.Point(31, 140);
            this.labelGift.Name = "labelGift";
            this.labelGift.Size = new System.Drawing.Size(106, 16);
            this.labelGift.TabIndex = 2;
            this.labelGift.Text = "Preferred Gift:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(142, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(143, 89);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(141, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxGift
            // 
            this.textBoxGift.Location = new System.Drawing.Point(143, 140);
            this.textBoxGift.Name = "textBoxGift";
            this.textBoxGift.Size = new System.Drawing.Size(141, 20);
            this.textBoxGift.TabIndex = 5;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(34, 195);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(250, 47);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "DONE";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 254);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxGift);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelGift);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADD NEW PARTICIPANT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelGift;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxGift;
        private System.Windows.Forms.Button buttonDone;
    }
}