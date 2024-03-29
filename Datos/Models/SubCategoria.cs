﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class SubCategoria
    {
        public int Id { get; set; }
        public int Id_Categoria { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria categorias { get; set; }
    }
}
