
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Qinweir.OrderMaterials
{
   
   public class CommonMaterial:AuditedAggregateRoot<int>
    {
         /// <summary>
         /// 订货门店
         /// </summary>
        public string OrderStore { get; set; }
        /// <summary>
        /// 订货时间
        /// </summary>
        public string OrderTime { get; set; }
     

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 材料清单表外键
        /// </summary>

        public virtual List<BillMaterials> BillMaterials { get; set; }
    }
}
