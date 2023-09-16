namespace Tienda_Snkrs_api.Models
{
    public class Snkr
    {
         public int Id { get; set; }
        public string Nombre { get; set; }
        public string Talla { get; set; }
        public string Url { get; set; }

        public string Descripcion { get; set; }

        public decimal  Precio { get; set; }
    }
}
