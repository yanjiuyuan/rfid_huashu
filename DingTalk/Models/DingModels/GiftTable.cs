namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiftTable")]
    public partial class GiftTable
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        [StringLength(30)]
        public string TaskId { get; set; }
        /// <summary>
        /// ��Ʒ���(Ԥ��) �������ȼ���Id
        /// </summary>
        [StringLength(500)]
        public string GiftNo { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        [StringLength(500)]
        public string GiftName { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        [StringLength(500)]
        public string GiftCount { get; set; }
    }
}
