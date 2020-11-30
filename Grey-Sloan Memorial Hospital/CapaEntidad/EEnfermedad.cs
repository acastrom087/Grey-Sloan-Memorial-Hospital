﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EEnfermedad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public EEnfermedad()
        {

        }

        public EEnfermedad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
