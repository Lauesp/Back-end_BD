﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Back_end_BD.Models
{
    public class Profesores
    {
        [Key]

        public int Matricula { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }

        public int Edad { get; set; }
    }
}