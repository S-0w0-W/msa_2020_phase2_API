using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace msa_2020_blog.Model
{
    [Table("post")]
    public partial class Post
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("content")]
        [StringLength(8000)]
        public string Content { get; set; }
        [Column("alias")]
        [StringLength(50)]
        public string Alias { get; set; }
        [Column("date_posted", TypeName = "date")]
        public DateTime? DatePosted { get; set; }
        [Column("likes")]
        public int? Likes { get; set; }
        [Column("dislikes")]
        public int? Dislikes { get; set; }
    }
}
