﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RSSReader.Models
{
    public class Feed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Uri { get; set; }
        
        [ValidateNever]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int FeedCategoryId { get; set; }
        [ForeignKey("FeedCategoryId")]
        public FeedCategory FeedCategory { get; set; }
    }
}
