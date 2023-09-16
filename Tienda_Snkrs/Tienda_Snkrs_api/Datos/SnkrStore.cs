using Tienda_Snkrs_api.Models.Dto;

namespace Tienda_Snkrs_api.Datos
{
    public static class SnkrStore
    {
        public static List<SnkrDto> listaSnkr = new List<SnkrDto>
        {
            new SnkrDto{Id= 1, Nombre = "Nike Dunk Low Retro",Talla="8.5",Url="https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/917676dc-96b6-40f8-9a1f-da3917ca6967/dunk-low-retro-mens-shoes-76KnBL.png",Descripcion = "Created for the hardwood but taken to the streets, the basketball icon returns with classic details and throwback hoops flair. Channeling '80s vibes, its padded, low-cut collar lets you take your game anywhere—in comfort.", Precio=120000},
            new SnkrDto{Id= 2, Nombre = "AJKO 1",Talla="8.5",Url="https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco,u_126ab356-44d8-4a06-89b4-fcdcc8df0245,c_scale,fl_relative,w_1.0,h_1.0,fl_layer_apply/2accb0bc-df03-4248-8bad-136062d43084/ajko-1-mens-shoes-GNcCR9.png",Descripcion = "We all know rubbernecking is a bad look—but when your kicks are this good, can you blame 'em? It's no surprise everyone wants to see the AJKO, a reimagining of Jordan's first hit shoe that leverages a mix of materials for a whole new vibe.", Precio=110000}

        };
    }
}
