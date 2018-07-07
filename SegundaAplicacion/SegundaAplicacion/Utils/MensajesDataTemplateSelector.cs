using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SegundaAplicacion.Model;

namespace SegundaAplicacion.Utils
{
    class MensajesDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MensajeMioTemplate { get; set; }
        public DataTemplate MensajeDeOtroTemplate { get; set; }
        public DataTemplate MensajeNadieTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var mensaje = (Mensaje)item;

            if (mensaje.Remitente.Equals("Yo"))
                return MensajeMioTemplate;
            else if (string.IsNullOrEmpty(mensaje.Remitente))
                return MensajeNadieTemplate;
            else
                return MensajeDeOtroTemplate;
        }
    }
}
