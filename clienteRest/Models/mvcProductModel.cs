using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clienteRest.Models
{
    public class mvcProductModel
    {
        public decimal CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<decimal> EXISTENCIAS { get; set; }


    }
}