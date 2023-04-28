using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementVishwa.Model
{
    [Table("MAX_PK_FIND")]
    public class KeyGeneratorModel
    {
        [Key]
        public string SYS_TYPE { get; set; }
        public string MAX_ALPHA { get; set; }
        public int MAX_SNO { get; set; }
        public int SYS_YEAR { get; set; }
    }
}
