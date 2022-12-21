namespace Gestion_de_Embarcaciones.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
