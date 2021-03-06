using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParcialUno.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JuegoUno : ContentPage
    {
        public JuegoUno()
        {
            InitializeComponent();
        }
        public void Calcular(Object sender, EventArgs e)
        {
            try
            {

                String numero = txtNumero.Text;
                String resultado = numero.Substring(0, numero.Length - 1);
                DisplayAlert("Te adivino", "Pensaste en el número: " + resultado, "Aceptar");
            }
            catch
            {
                DisplayAlert("Error", "El Numero ingresado no es válido", "Aceptar");
            }
        }
    }
}