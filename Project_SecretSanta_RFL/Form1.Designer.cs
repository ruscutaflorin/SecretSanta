namespace Project_SecretSanta_RFL
{
    partial class mainForm
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
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 17;
            this.listBoxParticipants.Location = new System.Drawing.Point(12, 12);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.Size = new System.Drawing.Size(567, 276);
            this.listBoxParticipants.Sorted = true;
            this.listBoxParticipants.TabIndex = 0;
            this.listBoxParticipants.SelectedIndexChanged += new System.EventHandler(this.listBoxParticipants_SelectedIndexChanged);
            this.listBoxParticipants.SelectedValueChanged += new System.EventHandler(this.listBoxParticipants_SelectedValueChanged);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(163, 291);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(247, 28);
            this.labelMain.TabIndex = 1;
            this.labelMain.Text = "LIST OF PARTICIPANTS";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(654, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 69);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(654, 112);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 69);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(654, 202);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(99, 69);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "REMOVE";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(836, 224);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 65);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(816, 25);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(138, 171);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "GENERATE              AND                                SEND";
            this.buttonSend.UseCompatibleTextRendering = true;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(990, 320);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.listBoxParticipants);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretSanta by RFL";
            this.TransparencyKey = System.Drawing.Color.Salmon;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSend;
    }
}

