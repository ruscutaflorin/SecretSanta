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
    public partial class RegistrationForm : Form
    {
        string connString;
        mainForm parent;
        public RegistrationForm(string connString, mainForm parent)
        {
            this.parent = parent;
            this.connString = connString;
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Gift = textBoxGift.Text.Trim();
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
                cmd.CommandText = "insert into Participa    nts (Full_Name,Email_Adress,Preferred_Gift) values (@Name,@Email,@Gift)";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            parent.Display();
            this.Close();
        }
    }
}
