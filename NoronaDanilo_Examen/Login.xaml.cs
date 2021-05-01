using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoronaDanilo_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void BtnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Usuario = txtUsusario.Text;
                string Password = txtPass.Text;

                if (Usuario == "estudiante2021" && Password == "uisrael2021")
                {
                    await Navigation.PushAsync(new Registro(Usuario, Password));
                }

                else
                {
                    string mensaje1 = " Dato Incorrecto";
                    DisplayAlert("Mensaje de alerta", mensaje1, "Gracias");
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ok");

                throw;
            }
        }
  }
}