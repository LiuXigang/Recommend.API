using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recommend.API.Model
{
    public class ProjectRecommend
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 所属用户id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 来源用户id
        /// </summary>
        public int FromUserId { get; set; }
        /// <summary>
        /// 来源用户名
        /// </summary>
        public string FromUserName { get; set; }
        /// <summary>
        /// 头像地址
        /// </summary>
        public string FromUserAvatar { get; set; }

        public EnumRecommendType RecommednType { set; get; }

        public int ProjectId { get; set; }

        public string ProjectAvatar { get; set; }

        public string Company { get; set; }
        public string Introduction { get; set; }
        public string Tags { get; set; }

        public string FinStage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RecommendTime { get; set; }
    }
    public enum EnumRecommendType 
    {
        Platform = 1,
        Friend = 2,
        Foaf = 3
    }
}


