using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace backend.Models
{
    public class Articles
    {
        [Key]
        public int ArticleId { get; set; }

        public string ArticleName { get; set; }

        public string ArticleDescription { get; set; }

        public string ArticlePhotoFileName { get; set; }

        public DateTime ArticlesCreateDate { get; set; }
    }
}
