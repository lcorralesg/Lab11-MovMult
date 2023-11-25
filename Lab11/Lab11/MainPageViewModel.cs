using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class MainPageViewModel
    {
        public Empleado Empleado { get; set; }
        public MainPageViewModel()
        {
            Empleado = new Empleado();
        }
    }
}
