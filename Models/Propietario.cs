﻿namespace Gestion_de_Embarcaciones.Models
{
    public class Propietario
    {
        public int Id { get; set; }
        public string Cedula_Pasaporte { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }
        public long Celular { get; set; }
        public virtual List<PaisPropietario> PaisPropietarios { get; set; }
        public virtual List<CiudadPropietario> CiudadPropietarios { get; set; }
        public int Zip { get; set; }

    }
}
