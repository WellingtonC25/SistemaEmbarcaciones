namespace Gestion_de_Embarcaciones.Models
{
    public class CiudadConstructora
    {

        public int IdCiudad { get; set; }
        public int IdConstructura { get; set; }
        public virtual Constructora Constructora { get; set; }
        public virtual Ciudad Ciudad { get; set; }
    }
}
