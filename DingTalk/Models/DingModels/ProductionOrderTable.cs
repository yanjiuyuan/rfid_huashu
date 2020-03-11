
namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductionOrderTable")]
    public partial class ProductionOrderTable
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [StringLength(200)]
        public string TaskId { get; set; }

        /// <summary>
        /// 生产指令单:客户名称
        /// </summary>
        [StringLength(200)]
        public string Customer { get; set; }


        /// <summary>
        /// 生产指令单:合同名
        /// </summary>
        [StringLength(200)]
        public string ContractName { get; set; }

        /// <summary>
        /// 生产指令单:合同名编号
        /// </summary>
        [StringLength(200)]
        public string ContractNumber { get; set; }

        /// <summary>
        /// 生产指令单:运输要求
        /// </summary>
        [StringLength(300)]
        public string TransportationRequirements { get; set; }

        /// <summary>
        /// 生产指令单:其他设备
        /// </summary>
        [StringLength(300)]
        public string OtherRequipment { get; set; }

        /// <summary>
        /// 生产指令单:包装要求
        /// </summary>
        [StringLength(300)]
        public string PackingRequire { get; set; }

        /// <summary>
        /// 生产预投单：预投部门（申请人的部门）
        /// </summary>
        [StringLength(300)]
        public string ExpectDept { get; set; }

        /// <summary>
        /// 生产预投单：预投原由
        /// </summary>
        [StringLength(500)]
        public string ExpectResult { get; set; }

        /// <summary>
        /// 小批量试制预投报告：项目名
        /// </summary>
        [StringLength(500)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 小批量试制预投报告：项目编号
        /// </summary>
        [StringLength(500)]
        public string ProjectNumber { get; set; }

        /// <summary>
        /// 小批量试制预投报告：预投目的
        /// </summary>
        [StringLength(500)]
        public string ExpectPurpose { get; set; }

        [NotMapped]
        public List<ProductionOrderDetail> ProductionOrderDetails { get; set; }
    }
}



