using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{

    public class Producto : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {


        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
            }
        }

        private String tipoProducto;
        public String TipoProducto
        {
            get { return tipoProducto; }
            set
            {
                this.tipoProducto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("TipoProducto"));
            }
        }


        private double precio;
        public double Precio
        {
            get { return precio; }
            set
            {
                this.precio = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Precio"));
            }
        }


        public Producto(String nombre, String tipoProducto, double precio)
        {
            this.nombre = nombre;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
        }


        public Producto()
        {
        }


        public override string ToString()
        {
            return Nombre + " " + Precio;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string Error
        {
            get { return ""; }
        }

        public string this[string columnName]
        {
            get
            {
                string resultado = "";

                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(nombre))
                    {
                        resultado = "El nombre del produto no puede estar vacio";
                    }
                }

                    if (columnName == "TipoProducto")
                    {
                        if (string.IsNullOrEmpty(tipoProducto))
                        {
                            resultado = "El tipo tiene que estar seleccionado";
                        }
                    }

                    if (columnName == "Precio")
                    {
                        if (Precio == 0)
                        {
                            resultado = "Debes asignarle un precio al producto";
                        }
                    }
                 return resultado;
                }
               

            }
        }
    }

