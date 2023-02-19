using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SecretSanta_RFL
{
    public partial class EditRegistration : Form
    {
        string connString;
        mainForm parent;
        string position;
        string[] proprietati;
        public EditRegistration(string connString, mainForm parent, string position)
        {
            this.position = position;
            this.parent = parent;
            this.connString = connString;
            InitializeComponent();
        }

        private void EditRegistration_Load(object sender, EventArgs e)
        {
            proprietati = position.Split(new string[] {"       "}, StringSplitOptions.None);
            textBoxName.Text = proprietati[0];
            textBoxEmail.Text = proprietati[1];
            textBoxGift.Text = proprietati[2];
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Gift = textBoxGift.Text.Trim();
            string email = proprietati[1];

            if (Name == String.Empty)
            {
                MessageBox.Show("Nu ai introdus un nume");
                return;
            }
            if (Email == String.Empty)
            {
                MessageBox.Show("Nu ai introds un email");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Parameters.Add("@Name", Name);
                cmd.Parameters.Add("@Email", Email);
                cmd.Parameters.Add("@Gift", Gift);
                cmd.Parameters.Add("@mail", email);
                cmd.CommandText = "Update Participants SET Full_Name = @Name, Email_Adress = @Email, Preferred_Gift = @Gift WHERE Email_Adress = @mail";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            parent.Display();
            this.Close();
        }
    }
}
