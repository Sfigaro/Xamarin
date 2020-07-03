using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mobile
{
    class TwitterService : ITwitterService
    {
        public bool authenticate(string id, string mdp)
        {
            if (id.Equals("cedric") && mdp.Equals("aaaaaa"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweet> getTweets()
        {
            List <Tweet> tweets = new List<Tweet>();

            Tweet tweet1 = new Tweet() { identifiant = "1", date_de_creation = "21/11/1995", identifiant_utilisateur = "start.jpg", nom_utilisateur = "Figaro", pseudo_utilisateur = "Optimus", texte = "je suis Optimus prime" };
            Tweet tweet2 = new Tweet() { identifiant = "2", date_de_creation = "12/05/2020", identifiant_utilisateur = "op.jpg", nom_utilisateur = "Vlondixis", pseudo_utilisateur = "Kaminis", texte = "La galaxis" };
            Tweet tweet3 = new Tweet() { identifiant = "3", date_de_creation = "03/07/2020", identifiant_utilisateur = "f.jpg", nom_utilisateur = "Aldersone", pseudo_utilisateur = "fociete", texte = "Mr.Robot" };
            tweets.Add(tweet1);
            tweets.Add(tweet2);
            tweets.Add(tweet3);
            return tweets;
        }
    }
}
