namespace Gestion_de_Embarcaciones.Models
{
    public class PaisConstructura
    {
        public int IdPais { get; set; }
        public int IdConstructura { get; set; }
        public virtual Constructora Constructora { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
