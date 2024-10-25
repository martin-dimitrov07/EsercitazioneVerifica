using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneVerifica
{
    internal class Contatto
    {
        public string nome;
        public string telefono;

        private Contatto(string Nome, string Telefono) 
        {
            this.nome = Nome;
            this.telefono = Telefono;
        }

        public static Contatto CreaContatto(string Nome, string Telefono)
        {
            if (Nome != "" && Telefono != "")
                return new Contatto(Nome, Telefono);
            else
                return null;
        }

        public static void ModificaContatto(Contatto c,string Nome, string Telefono)
        {
            if (Nome == "" && Telefono != "")
                c.telefono = Telefono;
            else if (Telefono == "" && Nome != "")
                c.nome = Nome;
            else if(Nome != "" && Telefono != "")
            {
                c.nome = Nome;
                c.telefono = Telefono;
            }   
        }

        public static void EliminaContatto(List<Contatto> contatti, string Nome, string Telefono)
        {
            foreach (Contatto contatto in contatti)
            {
                if (contatto.nome == Nome && contatto.telefono == Telefono)
                {
                    contatti.Remove(contatto);
                    break;
                }
            }
        }

    }
}
