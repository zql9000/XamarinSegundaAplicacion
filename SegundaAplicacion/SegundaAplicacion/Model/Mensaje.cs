using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SegundaAplicacion.Model
{
    public class Mensaje : INotifyPropertyChanged
    {
        public string Contenido { get; set; }
        public DateTime FechaHora { get; set; }
        public string Remitente { get; set; }

        public Command MostrarInfoCommand { get; set; }

        private bool debeMostrarInfo;
        public bool DebeMostrarInfo
        {
            get { return debeMostrarInfo; }
            set
            {
                debeMostrarInfo = value;
                OnPropertyChanged("DebeMostrarInfo");
            }
        }

        public Mensaje()
        {
            MostrarInfoCommand = new Command(MetodoMostrarInfo);
        }

        private void MetodoMostrarInfo()
        {
            DebeMostrarInfo = !DebeMostrarInfo;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
