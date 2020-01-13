using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    class PaqueteItem
    {
        public int Id { get; set; }

        [ForeignKey("Paquete")]
        public int IdPaquete{ get; set; }
    }
}
