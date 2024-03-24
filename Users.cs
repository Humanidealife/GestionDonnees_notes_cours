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

        //Création du constructeur personnalisé
        public Users(string utilisateur, string motDePasse)
        {
            Utilisateur = utilisateur;
            MotDePasse = motDePasse;
        }

        //Création du constructeur par défaut (obligatoire)
        //surtout pour le bouton d'ajout de données dans bindingNavigator
        public Users() { }
    }
}
