﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;//Libreria
namespace BASEDEDATOS.Clase
{
    class Contactos
    {
       [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Correo} - {Telefono}";
        }
    }
}
