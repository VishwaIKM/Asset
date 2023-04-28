using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementVishwa.Model
{
    [Table("ASSET_TEMP_MAIN")]
    public class AssetTempModel
    {
        [Key]
        public int PRIMARY_KEY { get; set; }
        public string FK_SYS_ASSET_NUM_MAIN { get; set; }
        public string SYS_MODEL_NUM { get; set; }
        public string SYS_TYPE { get; set; }
        public string SYS_USR { get; set; }
        public string SYS_PRE_OS { get; set; }
        public string SYS_RUNING_OS { get; set; }
        public string SYS_CPU { get; set; }
        public string SYS_HDD { get; set; }
        public string SYS_RAM { get; set; }
        public string SOFT_OFFICE { get; set; }
        public string SOFT_VS { get; set; }
        public string SOFT_W_CAL { get; set; }
        public string SOFT_RDP { get; set; }
        public string SOFT_SQL { get; set; }
        public string SOFT_SQL_CAL { get; set; }
        public string SYS_DEPT { get; set; }
        public string SYS_WARRANTY_AMC { get; set; }
        public string SYS_EXPIRY { get; set; }
        public string SYS_LAST_UPDATED { get; set; }
        public string SYS_STATUS_INFO { get; set; }
        public string SYS_PURCHASE_VALUE { get; set; }
        public string SYS_PURCHASE_YEAR { get; set; }
        public string SYS_VALUE_PERIOD { get; set; }
        public string SYS_MIN_VALUE { get; set; }
        public string SYS_CURRENT_VALUE { get; set; }
        public string SYS_IP { get; set; }
        public string SYS_HOST { get; set; }
        public string SYS_DEPLOY { get; set; }
        public string SYS_USAGE { get; set; }
        public string REQUEST_USER { get; set; }
        public int IS_APPROVED { get; set; }
        public string APPROVED_BY { get; set; }
        public DateTime USR_UPDATE_TIME { get; set; }
        public DateTime ADMIN_UPDATE_TIME { get; set; }
        public string USR_EDIT_COLUMN { get; set; }
        public string SYS_SDD { get; set; }
    }
}
