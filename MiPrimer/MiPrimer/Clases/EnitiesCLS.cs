using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiPrimer.Clases
{
    public class EnitiesCLS : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Categoria
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

        //Producto
        public List<ProductoCLS> _listaProducto { get; set; }

        public List<ProductoCLS> listaProducto
        {
            get
            {
                return _listaProducto;
            }
            set
            {
                if (this._listaProducto != value)
                {
                    this._listaProducto = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.listaProducto)));
                }
            }
        }
    }
}
