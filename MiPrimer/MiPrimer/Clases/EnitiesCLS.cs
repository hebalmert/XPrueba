using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiPrimer.Clases
{
    public class EnitiesCLS : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<CategoriaCLS> _listaCategoria { get; set; }

        public List<CategoriaCLS> listaCategoria 
        {
            get { 
                return _listaCategoria;
            }
            set {
                if (this._listaCategoria != value)
                {
                    this._listaCategoria = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.listaCategoria)));
                }
            } 
        }
    }
}
