using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowsVM : INotifyPropertyChanged
    {
        private List<Superheroe> lista = Superheroe.GetSamples();

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Superheroe superheroeActual;
        public Superheroe SuperheroeActual {
            get { return superheroeActual; }
            set { superheroeActual = value; this.NotifyPropertyChanged("SuperheroeActual"); } 
        }
        public int contadorActual;
        public int ContadorActual
        {
            get { return contadorActual; }
            set { contadorActual = value; this.NotifyPropertyChanged("ContadorActual"); }
        }

        public int totalHeroes;
        public int TotalHeroes
        {
            get { return totalHeroes; }
            set { totalHeroes = value; this.NotifyPropertyChanged("TotalHeroes"); }
        }

        public MainWindowsVM()
        {
            SuperheroeActual = lista[0];
            ContadorActual = 1;
            TotalHeroes = lista.Count;
        }

        public void Avanzar()
        {
            if (ContadorActual < TotalHeroes) {
                ContadorActual++;
                SuperheroeActual = lista[ContadorActual - 1];
            }
        }

        public void Retroceder()
        {
            if (ContadorActual > 1)
            {
                ContadorActual--;
                SuperheroeActual = lista[ContadorActual - 1];
            }
        }
    }
}
