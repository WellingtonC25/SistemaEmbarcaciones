namespace Gestion_de_Embarcaciones.Models
{
    public class PaisPropietario
    {
        public int IdPais { get; set; }
        public int IdPropietario { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Propietario Propietario { get; set; }
    }
}
