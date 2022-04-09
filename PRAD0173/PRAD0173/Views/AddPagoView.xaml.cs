using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRAD0173.Controllers;
using PRAD0173.Models;
using System.IO;
using Plugin.Media;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PRAD0173.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPagoView : ContentPage
    {
        //Objetos y variables a Utilizar
        Plugin.Media.Abstractions.MediaFile photo = null;
        public AddPagoView()
        {
            InitializeComponent();
        }

        //copia la foto al memory stream como bytes
        private Byte[] traeImagenByteArray()
        {
            if (photo != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    Stream stream = photo.GetStream();
                    stream.CopyTo(memory);
                    return memory.ToArray();
                }
            }
            return null;
        }

        private async void BtnAgregarCont_Clicked(object sender, EventArgs e)
        {
            if (TxtDesc.Text == null || TxtMonto.Text == null)
            {
                await DisplayAlert("Alerta","Hay Campos Vacios Porfavor Llenarlos","Ok");
            }
            else
            {
                var Pago = new PagosModel()
                {
                    Descripcion = TxtDesc.Text,
                    Monto = Convert.ToDouble(TxtMonto.Text),
                    FechaRegistro = TxtFecha.Date,
                    Foto = traeImagenByteArray()
                };

                if (await DataBase.AddPago(Pago) > 0)
                    await DisplayAlert("Alerta", "Registro Añadido", "Ok");
                else
                    await DisplayAlert("Alerta","Ocurrio Un Error Al Intentar Añadir el Registro","Ok");

                TxtDesc.Text = "";
                TxtMonto.Text = "";
            }
        }

        //Metodo para tomar la foto
        private async void BtnFoto_Clicked(object sender, EventArgs e)
        {
            photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "FotosApp",
                Name = "test.jpg",
                SaveToAlbum = true
            });

            if (photo != null)
            {
                Foto.Source = ImageSource.FromStream(() =>
                {
                    return photo.GetStream();
                });
            }
        }
    }
}