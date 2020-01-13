namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flows
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        /// <summary>
        /// ����Id
        /// </summary>
        public int? FlowId { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [StringLength(200)]
        public string FlowName { get; set; }

        /// <summary>
        /// ������(�ƶ���)
        /// </summary>
        [StringLength(200)]
        public string FlowNameMobile { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [StringLength(300)]
        public string CreateMan { get; set; }

        /// <summary>
        /// ������Id
        /// </summary>
        [StringLength(300)]
        public string CreateManId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(300)]
        public string ApplyTime { get; set; }

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

        /// <summary>
        /// ����״̬
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public int? IsEnable { get; set; }

        /// <summary>
        /// ���ڵ�Id
        /// </summary>
        public int? SORT_ID { get; set; }

        /// <summary>
        /// �Ƿ�֧���ֻ���������
        /// </summary>
        public bool? IsSupportMobile { get; set; }

        /// <summary>
        /// �ֻ�֪ͨ����·��
        /// </summary>
        [StringLength(200)]
        public string ApproveUrl { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int OrderBY { get; set; }

        /// <summary>
        /// -200px 300px 
        /// </summary>
        [StringLength(200)]
        public string Position { get; set; }

        /// <summary>
        /// ���Զ�ͼƬ·��
        /// </summary>
        [StringLength(200)]
        public string PcUrl { get; set; }

        /// <summary>
        /// �ֻ��˷���ҳ��·��
        /// </summary>
        [StringLength(200)]
        public string PhoneUrl { get; set; }

        /// <summary>
        /// �Ƿ�����(����Ϊ����ģ��)
        /// </summary>
        public bool? IsFlow { get; set; }

    }
}
