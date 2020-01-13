namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TasksState")]
    public partial class TasksState
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        [StringLength(100)]
        public string TaskId { get; set; }


        [StringLength(100)]
        public string State { get; set; }
        

        [StringLength(100)]
        public string ApplyMan { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(100)]
        public string ApplyTime { get; set; }

        /// <summary>
        /// ���һ�δ���ʱ��
        /// </summary>
        [StringLength(100)]
        public string CurrentTime { get; set; }

        /// <summary>
        /// ��ǰ����ڵ�
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(500)]

        public string Title { get; set; }

        [StringLength(100)]
        public string FlowName { get; set; }
        public string FlowId { get; set; }
    }
}