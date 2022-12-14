namespace Gestion_de_Embarcaciones.Models
{
    public class Constructora
    {
        public int Id { get; set; }
        public string RNC { get; set; }
        public string Descripcion { get; set; }
        public int IdCiudad { get; set; }
        public string Direccion { get; set; }
        public long Telefono1 { get; set; }
        public long Telefono2 { get; set; }
        public long Celular { get; set; }
        public string Email { get; set; }
        public virtual List<CiudadConstructora> CiudadConstructoras{ get; set; }
        public virtual List<PaisConstructura> PaisConstructuras { get; set; }
    }
}
