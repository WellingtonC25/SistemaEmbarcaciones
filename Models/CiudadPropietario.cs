namespace Gestion_de_Embarcaciones.Models
{
    public class CiudadPropietario
    {
        public int IdCiudad { get; set; }
        public int IdPropietario { get; set; }
        public virtual Ciudad Ciudad { get; set; }
        public virtual Propietario Propietario { get; set; }
    }
}
