using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Qinweir.OrderMaterial
{
   public class OrderMaterialDTO
    {


        public int Id { get; set; }
        /// <summary>
        /// 订货门店
        /// </summary>
        [DisplayName("订货门店")]
        public string OrderStore { get; set; }
        /// <summary>
        /// 订货时间
        /// </summary>
        [DisplayName("订货时间")]
        public string OrderTime { get; set; }
        /// <summary>
        /// 材料类型
        /// </summary> 
        [DisplayName("订货类型")]
        public string MaterialsType { get; set; }
        /// <summary>
        /// 材料名称
        /// </summary>
        [DisplayName("材料名称")]
        public string MaterialsName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [DisplayName("单位")]
        public string units { get; set; }
        /// <summary>
        /// 材料数量
        /// </summary>
        [DisplayName("订货数量")]
        public long MateriralsCount { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        [DisplayName("订货价格")]
        public decimal MateriralsPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        public string Remark { get; set; }





    }
}
