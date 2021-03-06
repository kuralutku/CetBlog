﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public virtual IList<Post> Posts { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250,MinimumLength =3)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<Comment> Comments { get; set; }
    }
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string UserFullName { get; set; }
        [Required]
        [StringLength(1000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public int? ParentCommentId { get; set; }
        [ForeignKey("ParentCommentId")]
        public Comment ParrentComment { get; set; }
    }
}