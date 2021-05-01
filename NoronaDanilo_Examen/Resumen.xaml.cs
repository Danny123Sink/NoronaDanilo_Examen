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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string total, string estado)
        {
            InitializeComponent();


            lblUsuario.Text = estado;
            lblNombre.Text = nombre;
            lblTotal.Text = total;
        }
    }
}