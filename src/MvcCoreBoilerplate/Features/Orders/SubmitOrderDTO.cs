using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreBoilerplate.DTO
{
    public class SubmitOrderDTO
    {
        public decimal Total { get; set; }
        public string Description { get; set; }
    }
}
