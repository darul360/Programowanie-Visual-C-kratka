using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class WypelnienieStalymi : IDataFiller
	{
		public void Fill(DataContext context)
		{
			Writer writer1 = new Writer("Henryk", "Sienkiewicz");
			Writer writer2 = new Writer("Adam", "Mickiewicz");
			
			Book book1 = new Book("W pustyni i w puszczy", writer1 , 340, 1, "Przygodowa");
			Book book2 = new Book("Quo vadis", writer1, 401, 2, "Dramat");
			Book book3 = new Book("Pan Tadeusz", writer2, 510, 3, "Dramat");

			Reader reader1 = new Reader("Jan", "Kowalski");
			Reader reader2 = new Reader("Michal", "Nowak");
			Reader reader3 = new Reader("Anna", "Wesola");
			Reader reader4 = new Reader("Jan", "Michalski");
			//	DateTime from = DateTime.Now;
			DateTime from = new DateTime(2017, 01, 01);
			Rent rent1 = new Rent(from, reader1, book1);
			Rent rent2 = new Rent(from, reader2, book1);
			Rent rent3 = new Rent(from, reader2, book2);

			context.writers.Add(writer1);
			context.writers.Add(writer2);

			context.books.Add(1, book1);
			context.books.Add(2, book2);
			context.books.Add(3, book3);

			context.readrs.Add(reader1);
			context.readrs.Add(reader2);
			context.readrs.Add(reader3);
			context.readrs.Add(reader4);

			context.rents.Add(rent1);
			context.rents.Add(rent2);
			context.rents.Add(rent3);

		}
	}
}
