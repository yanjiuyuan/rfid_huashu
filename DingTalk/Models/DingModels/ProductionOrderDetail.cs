
namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductionOrderDetail")]
    public partial class ProductionOrderDetail
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [StringLength(200)]
        public string TaskId { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        [StringLength(200)]
        public string CodeNumber { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [StringLength(300)]
        public string CodeName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [StringLength(300)]
        public string Standards { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 预计交货期
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 用途
        /// </summary>
        [StringLength(500)]
        public string Purpose { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(500)]
        public string Remark { get; set; }

        /// <summary>
        /// 生产批次号
        /// </summary>
        [StringLength(200)]
        public string ProductNumber { get; set; }

    }
}

