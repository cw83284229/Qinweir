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
        /// 材料类型
        /// </summary>
        public string MaterialsType { get; set; }
        /// <summary>
        /// 材料名称
        /// </summary>
        public string MaterialsName { get; set; }
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

    }
}
