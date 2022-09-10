﻿namespace CoreMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Page { get; set; }
        public DateTime RelaseDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
