using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta1.Odev1.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int GenreId { get; set; }

        public int PageCount { get; set; }

        internal void ApplyTo(object rbook)
        {
            throw new NotImplementedException();
        }
    }
}
