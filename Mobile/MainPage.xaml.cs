using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Se_connecter(object sender,EventArgs e)
        {

            TwitterService test = new TwitterService();
            this.cacherMessage();


            if (Connectivity.NetworkAccess != NetworkAccess.Internet) 
            {
                this.afficherMessage("pas de connexion internet");

            }

            else if (this.Identifiant.Text==null|| this.Identifiant.Text.Length<3 || string.IsNullOrEmpty(this.Identifiant.Text.ToString()))
            {
                this.afficherMessage("il faut au moins 3 caractères pour identifiant");
            }

            else if (this.MDP.Text == null || this.MDP.Text.Length < 6 || string.IsNullOrEmpty(this.MDP.Text.ToString()))
            {
                this.afficherMessage("il faut au moins 6 caractères pour le mot de passe");
            }

            else if (test.authenticate(this.Identifiant.Text,this.MDP.Text)==false)
            {
                this.afficherMessage("identifiant ou mot de passe incor");
            }

            else
            {
               await Navigation.PushAsync(new JeSuisConn());
            }
        }

        public void cacherMessage()
        {
            this.erreur.IsVisible = false;
        }

        public void afficherMessage(string message)
        {
            this.erreur.IsVisible = true;
            this.erreur.Text = message;
        }
    }

    
}
