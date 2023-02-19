using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SecretSanta_RFL
{
    public partial class mainForm : Form
    {
        string connString = "";
        private int nrParticipants;
        public mainForm()
        {
            nrParticipants = 0;
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ruscu\source\repos\Project_SecretSanta_RFL\Project_SecretSanta_RFL\Participants.mdf;Integrated Security=True";
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            listBoxParticipants.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Participants";
                listBoxParticipants.Controls.Clear();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string linie = r[1] + "       " + r[2] + "       " + r[3];
                    listBoxParticipants.Items.Add(linie);
                }
                r.Close();
                conn.Close();
            }
            buttonEdit.Enabled = false;
        }

        private void ClearDB()
        {
            SqlConnection connection = new SqlConnection(connString);

            string sqlStatement = "DELETE FROM Participants";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Randomize Algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public List<Participant> Generate()
        {
            List<Participant> person1 = new List<Participant>();
            List<Participant> person2 = new List<Participant>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Participants";
                SqlDataReader r = cmd.ExecuteReader();
                /*
                 * r[0] - id
                 * r[1] - nume
                 * r[2] - email
                 * r[3] - cadou
                 */
                while (r.Read())
                {
                    person1.Add(new Participant(r[1].ToString(), r[2].ToString(), r[3].ToString()));
                    person2.Add(new Participant(r[1].ToString(), r[2].ToString(), r[3].ToString()));
                }
                foreach (Participant student in person1)
                {
                    Random random = new Random();
                    int index = random.Next(person2.Count);
                    int tries = 0;
                    while (person2[index].nume == student.nume && tries < 100)
                    {
                        index = random.Next(person2.Count);
                        tries++;
                    }
                    if (tries >= 100)
                        return null;
                    student.toGift = person2[index];
                    person2.RemoveAt(index);
                }
            }
            return person1;
        }


        public class SmtpSettings
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public class SmtpMailer
        {
            public bool Send(SmtpSettings settings, string from, string to, string subject, string body)
            {
                // TODO: Validate arguments
                try
                {
                    using (var mail = new MailMessage())
                    {
                        mail.From = new MailAddress(from);
                        mail.To.Add(to);
                        mail.Subject = subject;
                        mail.Body = body;
                        mail.ReplyToList.Add(new MailAddress(from));

                        var smtp = new SmtpClient(settings.Host, settings.Port);
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(settings.Username, settings.Password);
                        smtp.Timeout = 60000; // 60 seconds
                        smtp.EnableSsl = true; // Outlook.com and Gmail require SSL
                        smtp.Send(mail);

                        // email was accepted by the SMTP server
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // TODO: Log the exception message
                    return false;
                }
            }
        }

        public void SendMail(string EmailAdress, string personName, string personGift)
        {
            var settings = new SmtpSettings()
            {
                Host = "smtp-mail.outlook.com",
                Port = 587,
                Username = "ruscutamoscraciun@outlook.com",
                Password = "MosCraciun.123"
            };

            var smtpMailer = new SmtpMailer();

            smtpMailer.Send(settings, "ruscutamoscraciun@outlook.com", EmailAdress, "Secret Santa", "You have to choose a present for " + personName + ". He'd rather receive " + personGift);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //ClearDB();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            nrParticipants++;
            Form addForm = new RegistrationForm(connString, this);
            addForm.Show();
        }

        /*
            private void buttonGenerate_Click(object sender, EventArgs e)
        {
            List<Participant> participants = null;
            while (participants == null)
            {
                participants = Generate();
            }
            
            listBoxParticipants.Items.Clear();
            foreach (Participant participant in participants)
            {
                listBoxParticipants.Items.Add(participant.Pereche());
            }
        }
        */

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            nrParticipants--;
            string person = listBoxParticipants.SelectedItem.ToString();
            string[] properties = person.Split(' ');
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Parameters.Add("@name", properties[0]);
                cmd.CommandText = "DELETE FROM Participants WHERE Full_Name=@name";
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            this.Display();

        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form addForm = new EditRegistration(connString, this, listBoxParticipants.SelectedItem.ToString());
            addForm.Show();
        }

        private void listBoxParticipants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxParticipants.SelectedItem != null)
            {
                string[] participant = listBoxParticipants.SelectedItem.ToString().Split(' ');
                buttonEdit.Enabled = true;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            List<Participant> participants = null;
            while (participants == null)
            {
                participants = Generate();
            }
            /*foreach (Participant participant in participants)
            {
                SendMail(participant.toGift.email, participant.toGift.nume, participant.toGift.cadou);
            }*/
            SendMail("ruscutaf07@yahoo.com", "nucont", "nucont");
            MessageBox.Show("The list was generated and sent!");


        }

        private void listBoxParticipants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
