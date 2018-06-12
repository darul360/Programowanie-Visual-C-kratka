using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Rent
	{
		public DateTime rentalDate { get; set; }
        public DateTime returnalDate { get; set; }
		public Reader reader { get; set; }
		public Book book { get; set; }
		public bool isReturned { get; set; }
		public Rent(DateTime rentalDate, Reader reader, Book book)
		{
			this.rentalDate = rentalDate;
			this.reader = reader;
			this.book = book;
            returnalDate = returnalDate;
			isReturned = false; 
		}

        public Rent(DateTime rentalDate,DateTime returnalDate, Reader reader, Book book)
        {
            this.rentalDate = rentalDate;
            this.returnalDate = returnalDate;
            this.reader = reader;
            this.book = book;

        }
		public override string ToString()
		{
			string outstream = "Data wypozyczenia: " + rentalDate.ToString() + "\nReader\n" + reader + "\nKsiazka\n" + book + "\nZwrot\n" + returnalDate.ToString();
			return outstream;
		}
	}
}
