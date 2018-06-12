using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class WypelnienieLosowe : IDataFiller
	{
		string[] firstnames = new string[] { "Jan", "Stanisław", "Andrzej", "Józef", "Tadeusz" };
		string[] lastnames = new string[] { "Michalski", "Nowak", "Kowalski ", "Wiśniewski", "Dąbrowski " };
		string[] type = new string[] { "Fantasy", "Horror", "Dramat", "Mlodziezowe", "Sensacja" };
		string[] title = new string[] { "title1", "title2", "title3", "title4", "title5" };
		string[] authorFirstname = new string[] { "authorFirstname1", "authorFirstname2", "authorFirstname3", "authorFirstname4", "authorFirstname5" };
		string[] authorLastname = new string[] { "authorLastname1", "authorLastname2", "authorLastname3", "authorLastname4", "authorLastname5" };

		Random rnd = new Random();
		public void Fill(DataContext context)
		{
			for (int i = 0; i < 100; i++)
			{
				context.readrs.Add(new Reader(firstnames[rnd.Next(0, 5)], lastnames[rnd.Next(0, 5)]));
				context.writers.Add(new Writer(authorFirstname[rnd.Next(0, 5)], authorLastname[rnd.Next(0, 5)]));
				context.books.Add(i, new Book(title[rnd.Next(0, 5)], context.writers[i], rnd.Next(300, 400), i, type[rnd.Next(0,5)]));
			}
			for (int i = 0; i < 100; i++)
			{
				DateTime from = new DateTime(1999, 01, 01);
				DateTime to = new DateTime(1999, 01, 20);
				context.rents.Add(new Rent(from, context.readrs[rnd.Next(0,99)], context.books[i]));
			}
		}
	}
}
