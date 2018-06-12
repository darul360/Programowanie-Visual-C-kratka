using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Book
	{
		public string title { get; set; }
		public Writer writer { get; set; }
		public int numberPages { get; set; }
		public int id { get; }
		public string type { get; set; }

        public Book booker { get; set; }


        public Book(string title, Writer writer, int numberPages, int id, string type)
		{
			this.writer = writer;
			this.title = title;
			this.numberPages = numberPages;
			this.id = id;
			this.type = type; 
		}

		public override string ToString()
		{
			string outstream = writer.ToString() + ", tytul:  " + title + ", numer strony: " + numberPages + ", gatunek: " + type + " " + id;
			return outstream; 
		}
		 ~Book() { }
	}
}
