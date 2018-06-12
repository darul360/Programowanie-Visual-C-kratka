using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class DataRepository
	{
		public IDataFiller dataFiller { get; set; }
	    public DataContext dataContext { get; set; }	
		public DataRepository(IDataFiller dataFiller, DataContext dataContext)
		{
			this.dataContext = dataContext; 
			this.dataFiller = dataFiller;
			dataFiller.Fill(dataContext); 
		}

		#region Writer
		public void AddWriter(Writer writer)
		{
			dataContext.writers.Add(writer);
		}
		public void DeleteWriter(Writer writer)
		{
			dataContext.writers.Remove(writer);
		}

		public List<Writer> GetAllWriters()
		{
			List<Writer> r = dataContext.writers.ToList();
			return r;
		}

		public void raportWriters()
		{
			for (int i = 0; i < dataContext.writers.Count; i++)
				Console.WriteLine(dataContext.writers[i].ToString());
		}

		#endregion

		#region BOOK

		public void AddBook(Book book)
		{
			dataContext.books.Add(book.id, book);
		}

        public void DeleteBook(Book book)
        {
            dataContext.books.Remove(book.id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return dataContext.books.Values;
        }
        public Dictionary<int, Book> GetAllBooks1()
        {
            return dataContext.books;
        }

        public Book GetBook(int numer)
        {
            if (numer <= dataContext.books.Count)
            {
                return dataContext.books[numer];
            }
            else
                throw new NotImplementedException();
        }
        public void raportBooks()
        {
            for (int i = 0; i < dataContext.books.Count; i++)
                Console.WriteLine(dataContext.books[i].ToString());
        }

        #endregion

        #region READER
        public void AddReader(Reader reader)
        {
            dataContext.readrs.Add(reader);
        }
        public void DeleteReader(Reader reader)
        {
            dataContext.readrs.Remove(reader);
        }

        public List<Reader> GetAllReaders()
        {
            List<Reader> r = dataContext.readrs.ToList();
            return r;
        }

        public void raportReaders()
        {
            for (int i = 0; i < dataContext.readrs.Count; i++)
                Console.WriteLine(dataContext.readrs[i].ToString());
        }



        #endregion

        #region RENT
        public void AddRent(Rent rent)
        {
            dataContext.rents.Add(rent);
        }


        public void DeleteRent(Rent rent)
        {
            dataContext.rents.Remove(rent);
        }

        public void ReturnRent(Rent rent, DateTime returnDate) 
        {
            DeleteRent(rent);
            rent.returnalDate = returnDate;
            dataContext.finished_rents.Add(rent);
        }

        public IEnumerable<Rent> GetAllRents()
        {
             return dataContext.rents;
        }

        public void raportRent()
        {
            for (int i = 0; i < dataContext.rents.Count; i++)
                Console.WriteLine(dataContext.rents[i].ToString());
        }
  
        #endregion

    }
}
