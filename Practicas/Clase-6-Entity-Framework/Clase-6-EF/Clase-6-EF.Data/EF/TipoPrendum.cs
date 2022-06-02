using System;
using System.Collections.Generic;

#nullable disable

namespace Clase_6_EF.Data.EF
{
    public partial class TipoPrendum
    {
        public TipoPrendum()
        {
            Prenda = new HashSet<Prendum>();
        }

        public int IdTipoPrenda { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Prendum> Prenda { get; set; }
    }
}
