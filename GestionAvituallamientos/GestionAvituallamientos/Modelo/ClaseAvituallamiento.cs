using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvituallamientos.Modelo
{
    public class ClaseAvituallamiento : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        public String NombreCarrera { get; set; }


        private double puntoKilometrico;
        public double PuntoKilometrico
        {
            get { return puntoKilometrico; }

            set
            {
                this.puntoKilometrico = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PuntoKilometrico"));
            }

        }


        private PersonaContacto personaContacto;
        public PersonaContacto PersonaContacto
        {
            get { return personaContacto; }

            set
            {
                this.personaContacto = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("PersonaContacto"));
            }
        }

        public ObservableCollection<ProductoAvituallamiento> MaterialDisponible { get; set; }


        public ClaseAvituallamiento()
        {
            MaterialDisponible = new ObservableCollection<ProductoAvituallamiento>();
            this.personaContacto = new PersonaContacto();
        }

        public ClaseAvituallamiento(String nombreCarrera, double pk, PersonaContacto p)
        {
            this.NombreCarrera = nombreCarrera;
            this.PuntoKilometrico = pk;
            this.PersonaContacto = p;
            MaterialDisponible = new ObservableCollection<ProductoAvituallamiento>();
        }


        public override string ToString()
        {
            return "Nombre carrera: " + NombreCarrera + ", punto kilométrico: " + PuntoKilometrico + ", persona de contacto: " + PersonaContacto.Nombre + ", teléfono: " + PersonaContacto.Telefono;
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
                if (columnName == "PuntoKilometrico")
                {
                    if (PuntoKilometrico == null || PuntoKilometrico == 0)
                    {
                        resultado = " El punto kilométrico debe estar rellenado";
                    }
                }
                return resultado;
            }
        }
    }
}
