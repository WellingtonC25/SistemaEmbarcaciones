﻿namespace Gestion_de_Embarcaciones.Models
{
    public class Zona
    {
        public int Id { get; set; }
        public int Descripcion { get; set; }
        public virtual List<Comandancia> Comandancias { get; set; }
        public virtual List<Puerto> Puertos { get; set; }
    }
}
