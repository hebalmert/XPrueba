using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiPrimer.Clases
{
    public class UsuarioCLS : INotifyPropertyChanged
    {
        private string _nombreusuario { get; set; }

        private string _contra { get; set; }


        public string nombreusuario 
        {
            get => _nombreusuario;
            set {
                if (this._nombreusuario != value)
                { 
                    this._nombreusuario = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.nombreusuario)));
                }
            }
        }

        public string contra 
        {
            get => _contra;
            set
            {
                if (this._contra != value)
                {
                    this._contra = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.nombreusuario)));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}


