namespace Gestion_de_Embarcaciones.Models
{
    public class ComandanteComandancia
    {
        public int IdComandancia { get; set; }
        public int IdComandante { get; set; }
        public virtual Comandancia Comandancia { get; set; }
        public virtual Comandante Comandante { get; set; }
    }
}
