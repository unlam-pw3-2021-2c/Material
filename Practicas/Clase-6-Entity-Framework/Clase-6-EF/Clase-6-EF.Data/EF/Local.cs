﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Clase_6_EF.Data.EF
{
    public partial class Local
    {
        public Local()
        {
            LocalPrenda = new HashSet<LocalPrendum>();
        }

        public int IdLocal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<LocalPrendum> LocalPrenda { get; set; }
    }
}
