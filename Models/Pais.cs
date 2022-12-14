namespace Gestion_de_Embarcaciones.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public  virtual List<Ciudad> Ciudades { get; set; }
        public virtual List<PaisConstructura> PaisConstructuras { get; set; }
        public virtual List<PaisPropietario> PaisPropietarios { get; set; }
        public virtual List<Comandancia> Comandancias { get; set; }
        public virtual List<Puerto> Puertos { get; set; }
    }
}
