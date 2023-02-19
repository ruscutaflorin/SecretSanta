using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SecretSanta_RFL
{
    public class Participant
    {
        public string id;
        public string nume;
        public string email;
        public string cadou;
        public Participant toGift;

        public Participant(string nume, string email, string cadou)
        {
            //this.id = id;
            this.nume = nume;
            this.email = email;
            this.cadou = cadou;
        }

        public override string ToString()
        {
            return id + " " + nume + " " + email + " " + cadou;
        }

        public string Pereche()
        {
            return nume + " " + toGift.nume;
        }
    }
}
