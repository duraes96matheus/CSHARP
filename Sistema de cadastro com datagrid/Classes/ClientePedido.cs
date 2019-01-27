using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class ClientePedido
    {
        public int NumPedido { get; set; }
        public string NMClienteComprador{get; set;}
        public DateTime DTPedido{get; set;}
        public string NMVendedor{get; set;}
    }
}
