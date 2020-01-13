namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlowSort")]
    public partial class FlowSort
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        /// <summary>
        /// ���̴�����
        /// </summary>
        [StringLength(300)]
        public string SORT_NAME { get; set; }

        /// <summary>
        /// ����Id
        /// </summary>
        [StringLength(300)]
        public string DEPT_ID { get; set; }

        /// <summary>
        /// ���ڵ�Id (Ԥ��)
        /// </summary>
        [StringLength(300)]
        public string SORT_PARENT { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string CreateTime { get; set; }

        /// <summary>
        /// ����״̬
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public int? IsEnable { get; set; }
        
        /// <summary>
        /// ����
        /// </summary>
        public int OrderBY { get; set; }

        /// <summary>
        /// �ӽڵ�Id
        /// </summary>
        [StringLength(200)]
        public string Sort_ID { get; set; }

        /// <summary>
        /// ӵ��Ȩ�޵��û���
        /// </summary>
        [StringLength(500)]
        public string ApplyMan { get; set; }
        /// <summary>
        /// ӵ��Ȩ�޵��û�Id
        /// </summary>
        [StringLength(500)]
        public string ApplyManId { get; set; }

        [NotMapped]
        public List<Flows> flows { get; set; }
    }
}
