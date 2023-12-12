using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Core.Entities
{
    [Table("MenuEleman")]
    public class MenuEleman
    {
        [Key]
        [Column(Order = 0)]
        public int MenuID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ElemanID { get; set; }


        public virtual Menu Menu{ get; set; }

        public virtual Eleman Eleman{ get; set; }
    }
}
