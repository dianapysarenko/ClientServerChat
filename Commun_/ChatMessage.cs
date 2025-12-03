using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commun
{
    public class ChatMessage
    {
        // Un numero unique dinnée par le serveur.
        public int Id {  get; set; }

        //Le Contenu du Message.
        public string Message { get; set; }

        //L'Alias de l'emetteur
        public string Alias { get; set; }

        public ChatMessage() { }
    }
}