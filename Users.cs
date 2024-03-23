using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDonnees_notes_cours
{
    internal class Users
    {
        //Création des propriétés
        public string Utilisateur{ get; set; }
        public string MotDePasse { get; set; }

        //Création du constructeur
        public Users(string utilisateur, string motDePasse)
        {
            Utilisateur = utilisateur;
            MotDePasse = motDePasse;
        }
    }
}
