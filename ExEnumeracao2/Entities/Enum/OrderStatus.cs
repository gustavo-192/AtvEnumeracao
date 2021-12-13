using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumeracao2.Entities.Enum
{
    //Status do pedido
    enum OrderStatus : int
    {
        //pagamento pendente
        Pending_Payament = 0,
        //processando
        Processing = 1,
        //enviado
        Shipped = 2,
        //entregue
        Delivered = 3
    }
}
