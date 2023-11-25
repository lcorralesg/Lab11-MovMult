using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lab11
{
    public class Empleado : INotifyPropertyChanged
    {
        private decimal sueldo;
        private decimal gratificacion;
        private decimal descuento;

        public decimal Sueldo
        {
            get { return sueldo; }
            set
            {
                if (sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged(nameof(Sueldo));
                    OnPropertyChanged(nameof(SueldoNeto));
                    OnPropertyChanged(nameof(SueldoNetoFinal));
                    OnPropertyChanged(nameof(Impuesto));
                }
            }
        }

        public decimal Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged(nameof(Gratificacion));
                    OnPropertyChanged(nameof(SueldoNeto));
                    OnPropertyChanged(nameof(SueldoNetoFinal));
                    OnPropertyChanged(nameof(Impuesto));
                }
            }
        }

        public decimal Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged(nameof(Descuento));
                    OnPropertyChanged(nameof(SueldoNetoFinal));
                }
            }
        }

        public decimal SueldoNeto => Sueldo + Gratificacion;

        public decimal SueldoNetoFinal => Sueldo + Gratificacion - Descuento;

        public decimal Impuesto => Sueldo * 0.08m;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
