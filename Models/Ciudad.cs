namespace Gestion_de_Embarcaciones.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual List<CiudadConstructora> CiudadConstructoras { get; set; }
        public virtual List<Comandancia> Comandancias { get; set; }
        public virtual List<Puerto> Puertos { get; set; }
        public virtual List<CiudadPropietario> CiudadPropietarios { get; set; }
    }
}
