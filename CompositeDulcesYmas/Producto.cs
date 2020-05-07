using CompositeDulcesYmas.Base;
using System;
using System.Collections.Generic;

namespace CompositeDulcesYmas
{
    public abstract class Producto : Entity<int>
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public double CostoUnitario { get; set; }
        public List<Fabricacion> Fabricaciones { get; set; }
        protected Producto(string nombre, double cantidad)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Fabricaciones = new List<Fabricacion>();
        }
        protected Producto(string nombre, double cantidad, double costo)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.CostoUnitario = costo;
        }
        protected Producto(string nombre)
        {
            this.Nombre = nombre;
        }
        protected Producto()
        {
            this.Fabricaciones = new List<Fabricacion>();
        }
        public abstract double GetCosto();
    }
}
