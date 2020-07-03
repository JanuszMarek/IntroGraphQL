using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.Entities
{
    public class Book
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        [ForeignKey(nameof(Author))]
        public long AuthorId { get; set; }
        public Author Author { get; set; }

        public DateTime ReleaseDate { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }
    }
}
