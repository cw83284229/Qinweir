using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Qinweir.Application.Contracts
{ 

    public class UpdateCommonMaterialDTO
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

        public virtual List<UpdateBillMaterialsDTO> BillMaterials { get; set; }
    }
}
