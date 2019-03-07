using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{


    public class ProductoAvituallamiento: INotifyPropertyChanged, ICloneable
    {
        private Producto producto;
        public Producto Producto {
            get { return producto; }
            set {
                this.producto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Producto"));
            }
            }

        private int cantidad;
        public int Cantidad {
            get { return cantidad; }
            set{
                this.cantidad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Cantidad"));
            }
        }


        public ProductoAvituallamiento(Producto p, int cantidad)
        {
            this.Producto = p;
            this.Cantidad = cantidad;

        }

        public ProductoAvituallamiento() { }


        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
           return this.MemberwiseClone();
        }
    }
}
