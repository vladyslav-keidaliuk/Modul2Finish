﻿namespace Modul2Finish.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}
