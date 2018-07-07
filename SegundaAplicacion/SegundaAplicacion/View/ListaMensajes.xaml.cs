using SegundaAplicacion.Model;
using SegundaAplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SegundaAplicacion.View
{
	public partial class ListaMensajes : ContentPage
	{
		public ListaMensajes ()
		{
			InitializeComponent ();

            //this.BindingContext = new ListaMensajesViewModel();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await ((ListaMensajesViewModel)BindingContext).CargarMensajes();
        }

        private void lstMensajes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var mensaje = (Mensaje)e.SelectedItem;

            DisplayAlert("Mensaje", mensaje.Contenido, "Aceptar");
        }
    }
}