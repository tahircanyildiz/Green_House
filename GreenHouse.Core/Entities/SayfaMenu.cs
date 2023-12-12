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
    [Table("SayfaMenu")]
    public class SayfaMenu
    {
        [Key]
        [Column(Order = 0)]
        public int SayfaID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int MenuID { get; set; }

        public Sayfa Sayfa { get; set; }
        public Menu Menu { get; set; }

    }
}