namespace Gestion_de_Embarcaciones.Models
{
    public class Rango
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Comandante> Comandante { get; set; }
    }
}