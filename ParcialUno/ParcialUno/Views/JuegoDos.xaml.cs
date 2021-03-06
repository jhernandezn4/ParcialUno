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
    public partial class JuegoDos : ContentPage
    {
        public JuegoDos()
        {
            InitializeComponent();
        }
        public void Calcular(Object sender, EventArgs e)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                numero = (numero - 365);
                string resultado = Convert.ToString(numero);
                string dia = resultado.Substring(0, 2);
                string mes = meses[Convert.ToInt32(resultado.Substring(2, 2))-1];

                DisplayAlert("Te adivino", "Tu cumpleaños es el "+dia+" de "+mes, "Aceptar");
            }
            catch
            {
                DisplayAlert("Error", "El Numero ingresado no es válido", "Aceptar");
            }
        }
    }
}