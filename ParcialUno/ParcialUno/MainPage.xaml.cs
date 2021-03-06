using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParcialUno
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
           
        async void JuegoUno(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.JuegoUno());
        }
        async void JuegoDos(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.JuegoDos());
        }
    }
}
