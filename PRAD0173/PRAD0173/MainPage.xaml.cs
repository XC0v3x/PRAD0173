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

        private void BtnAgregar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnAcerca_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}
