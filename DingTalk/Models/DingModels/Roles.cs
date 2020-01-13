namespace DingTalk.Models.DingModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        /// <summary>
        /// ��ɫ��
        /// </summary>
        [StringLength(200)]
        public string RoleName { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        [StringLength(200)]
        public string CreateMan { get; set; }

        /// <summary>
        /// ������Id
        /// </summary>
        [StringLength(200)]
        public string CreateManId { get; set; }
       
        /// <summary>
        /// ����ʱ��
        /// </summary>
        [StringLength(200)]
        public string CreateTime { get; set; }
        
        /// <summary>
        /// ӵ��Ȩ�޵���
        /// </summary>
        [StringLength(200)]
        public string UserName { get; set; }

        /// <summary>
        /// ӵ��Ȩ�޵��˵�Id
        /// </summary>
        [StringLength(200)]
        public string UserId { get; set; }

        /// <summary>
        /// �Ƿ�����
        /// </summary>
        public bool? IsEnable { get; set; }

        /// <summary>
        /// ��ɫId����
        /// </summary>
        public int? RoleId { get; set; }
    }
}
