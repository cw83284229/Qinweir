
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;



namespace Qinweir.OrderMaterials

{ 
    public class BillMaterials:AuditedAggregateRoot<int>
    { 
        /// <summary>
        /// 材料类型
        /// </summary>
        public string MaterialsType { get; set; }
        /// <summary>
        /// 材料名称
        /// </summary>
        public string MaterialsName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string units { get; set; }
        /// <summary>
        /// 材料数量
        /// </summary>
        public long MateriralsCount { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal MateriralsPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        public int CommonMaterialId { get; set; }
        ///// <summary>
        ///// 增加类别可空外键
        ///// </summary>
        //[ForeignKey("CommonMaterialId")]
        //public virtual CommonMaterial CommonMaterial { get; set; }

      
    }
}
