using SegundaAplicacion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SegundaAplicacion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var mensajes = new List<Mensaje>();

            mensajes.Add(new Mensaje {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Alguien"
            });

            mensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Yo"
            });

            mensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Alguien"
            });

            mensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = ""
            });

            mensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Yo"
            });

            lstMensajes.ItemsSource = mensajes;
        }

        private void lstMensajes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var mensaje = (Mensaje)e.SelectedItem;

            DisplayAlert("Mensaje", mensaje.Contenido, "Aceptar");
        }
    }
}
