using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PRAD0173.Views;

namespace PRAD0173
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagosListView());
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPagoView());
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagosEliminarView());
        }

        private async void BtnModificar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagosEditView());
        }

        private async void BtnAcerca_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Universidad Cristiano Evangelica Nuevo Milenio","Estudiante: Daniel Emilio Martinez #Cuenta: 120450173","Nice");
        }

        private async void BtnSalir_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ups","No supe como programar el cerrar","Ni modo");
        }
    }
}
