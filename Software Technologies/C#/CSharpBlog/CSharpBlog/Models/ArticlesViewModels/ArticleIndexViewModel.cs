using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpBlog.Models.ArticlesViewModels
{
    public class ArticleIndexViewModel
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string AuthorFullName { get; set; }
    }
}
