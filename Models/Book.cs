using System;
namespace UrlRedirection.Models
{
	public class Book
	{
		public int? BookId { get; set; }

		public string? Author { get; set; }

        public override string ToString()
        {
            return $"Book Object - book ID : {BookId}, Author :{Author}";
        }


    }
}

