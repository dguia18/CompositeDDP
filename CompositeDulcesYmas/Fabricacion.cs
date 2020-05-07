using CompositeDulcesYmas.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDulcesYmas
{
    public class Fabricacion : Entity<int>
    {
        public double Cantidad { get; set; }
        public double Costo { get; set; }
        public List<FabricacionDetalle> FabricacionDetalles { get; set; }
        public Fabricacion()
        {
            this.FabricacionDetalles = new List<FabricacionDetalle>();
        }
        public void AgregarMateriaPrima(Producto materiaPrima)
        {
            this.FabricacionDetalles.Add(new FabricacionDetalle(materiaPrima, this));
        }
    }
}
