using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDulcesYmas
{
    public class FabricacionDetalle
    {
        private Producto materiaPrima;
        private Fabricacion fabricacion;
        private int materiaPrimaId;
        private int fabricacionId;
        private double cantidad;
        private double costo;
        public FabricacionDetalle(Producto materiaPrima, Fabricacion fabricacion)
        {
            this.materiaPrima = materiaPrima;
            this.fabricacion = fabricacion;
            this.fabricacionId = fabricacion.Id;
            this.materiaPrimaId = materiaPrima.Id;
            this.cantidad = materiaPrima.Cantidad;
            this.costo = materiaPrima.CostoUnitario;
        }
    }
}
