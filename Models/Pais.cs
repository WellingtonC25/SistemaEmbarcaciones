﻿namespace Gestion_de_Embarcaciones.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public  virtual List<Ciudad> Ciudades { get; set; }

    }
}
