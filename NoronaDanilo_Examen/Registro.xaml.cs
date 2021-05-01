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
    public partial class Registro : ContentPage
    {
        public Registro(string Usuario, string Password)
        {
            InitializeComponent();

            string usuario = lblUsuario.Text;
            lblUsuario.Text = usuario + Usuario;
        }

        private void btnCalcularMensual_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double resultado;
            double total;
            try
            {
                double monto = Convert.ToDouble(txtMontoInicial.Text);
                if (monto <= 1800 && monto > 0)
                {
                    resultado = ((1800 - monto) / 3) + 90;
                    txtPagoMensual.Text = resultado.ToString();
                    total = (resultado * 3) + monto;
                    txtTotal.Text = total.ToString();

                    string mensaje1 = "elemento guardado con exito";
                    DisplayAlert("Mensaje de alerta", mensaje1, "Gracias");

                }
                else
                {
                    DisplayAlert("Alerta", "ERROR", "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", "ERROR" + ex.Message, "Gracias");
                throw;

            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string total = txtTotal.Text;
            string estado = lblUsuario.Text;

            await Navigation.PushAsync(new Resumen(nombre, total, estado));
        }
    }
}