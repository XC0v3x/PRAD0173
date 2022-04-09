using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAD0173.Controllers;
using PRAD0173.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRAD0173.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagosListView : ContentPage
    {
        int id = 0;
        string desc = "";
        double monto = 0;
        DateTime fecha;

        public PagosListView()
        {
            InitializeComponent();
        }

        private void ListaPagos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.PagosModel Pagos = (Models.PagosModel)e.CurrentSelection.FirstOrDefault();
            id = Pagos.ID;
            desc = Pagos.Descripcion.ToString();
            fecha = Pagos.FechaRegistro.Date;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ListaPagos.ItemsSource = await DataBase.ObtenerListaPagos();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var Pago = new PagosModel()
            {
                ID = id,
                Descripcion = desc,
                Monto = monto,
                FechaRegistro = fecha,
                
            };

            if (await DataBase.DelPago(Pago) > 0)
                await DisplayAlert("Alerta", "Registro Eliminado", "Ok");
            else
                await DisplayAlert("Alerta", "Ocurrio Un Error Al Intentar Eliminar el Registro", "Ok");
        }
    }
}