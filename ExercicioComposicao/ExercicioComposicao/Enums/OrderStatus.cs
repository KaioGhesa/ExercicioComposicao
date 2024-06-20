using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExercicioComposicao.Enums;

namespace ExercicioComposicao.Enums
{
     enum OrderStatus :int
    {   
        PendingPayment,
        Processing,
        Shipped,
        Delivered
 
    }
}
