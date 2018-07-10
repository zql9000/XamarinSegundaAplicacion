using SegundaAplicacion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace SegundaAplicacion.ViewModel
{
    class ListaMensajesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Mensaje> ListaMensajes { get; set; }
        private string fechaDeHoy;
        public string FechaDeHoy {
            get
            {
                return fechaDeHoy;
            }
            set
            {
                fechaDeHoy = value;
                OnPropertyChanged("FechaDeHoy");
            }
        }

        private bool isBusy;
        public bool IsBusy {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task<bool> CargarMensajes()
        {
            IsBusy = true;

            await Task.Delay(50);

            FechaDeHoy = DateTime.Now.ToShortDateString();

            ListaMensajes = new ObservableCollection<Mensaje>();

            ListaMensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Alguien"
            });

            ListaMensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Yo"
            });

            ListaMensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Alguien"
            });

            ListaMensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = ""
            });

            ListaMensajes.Add(new Mensaje
            {
                Contenido = "Hola mundo",
                FechaHora = DateTime.Now,
                Remitente = "Yo"
            });

            OnPropertyChanged("ListaMensajes");

            IsBusy = false;

            return true;
        }
    }
}
