using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Tests
{
	[TestClass()]
	public class DataRepositoryTests
	{
		public DataRepositoryTests()
		{
			dataRepository = new DataRepository(wypelnienieStalymi, dataContext);
		}

		WypelnienieStalymi wypelnienieStalymi = new WypelnienieStalymi();
		DataContext dataContext = new DataContext();
		DataRepository dataRepository;
		
		#region WriterTest
		[TestMethod()]
		public void AddWriterTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			dataRepository.AddWriter(writer);
			Assert.AreEqual(dataContext.writers[2], writer);

		}

		[TestMethod()]
		public void DeleteWriterTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			dataRepository.AddWriter(writer);
			Assert.AreEqual(dataContext.writers.Count(), 3);
			dataRepository.DeleteWriter(writer);
			Assert.AreEqual(dataContext.writers.Count(), 2);
		}

		[TestMethod()]
		public void GetAllWritersTest()
		{
			Assert.AreEqual(dataRepository.GetAllWriters().Count(), 2);
		}
		#endregion

		#region BookTest
		[TestMethod()]
		public void AddBookTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			dataRepository.AddBook(book);
			Assert.AreEqual(dataContext.books[4], book);
		}

		[TestMethod()]
		public void DeleteBookTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			dataRepository.AddBook(book);
			Assert.AreEqual(dataContext.books.Count(), 4);
			dataRepository.DeleteBook(book);
			Assert.AreEqual(dataContext.books.Count(), 3);
		}

		[TestMethod()]
		public void GetAllBooksTest()
		{
			Assert.AreEqual(dataRepository.GetAllBooks().Count(), 3);
		}

		[TestMethod()]
		public void GetAllBooks1Test()
		{
			Assert.AreEqual(dataRepository.GetAllBooks1().Count(), 3);
		}

		[TestMethod()]
		public void GetBookTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			dataRepository.AddBook(book);
			Assert.AreEqual(dataRepository.GetBook(4), book);
		}
		#endregion

		#region ReaderTest 
		[TestMethod()]
		public void AddReaderTest()
		{
			Reader reader = new Reader("firstname", "lastName");
			dataRepository.AddReader(reader);
			Assert.AreEqual(dataContext.readrs[4], reader);

		}

		[TestMethod()]
		public void DeleteReaderTest()
		{
			Reader reader = new Reader("firstname", "lastName");
			dataRepository.AddReader(reader);
			Assert.AreEqual(dataContext.readrs.Count(), 5);
			dataRepository.DeleteReader(reader);
			Assert.AreEqual(dataContext.readrs.Count(), 4);
		}

		[TestMethod()]
		public void GetAllReadersTest()
		{
			Assert.AreEqual(dataRepository.GetAllReaders().Count(), 4);
		}
		#endregion

		#region RentTest 
		[TestMethod()]
		public void AddRentTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			Reader reader = new Reader("firstname", "lastName");
			DateTime from = new DateTime(2017, 01, 01);
			Rent rent = new Rent(from, reader, book);
			dataRepository.AddRent(rent);
			Assert.AreEqual(dataContext.rents[3], rent);
		}

		[TestMethod()]
		public void DeleteRentTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			Reader reader = new Reader("firstname", "lastName");
			DateTime from = new DateTime(2017, 01, 01);
			Rent rent = new Rent(from, reader, book);
			dataRepository.AddRent(rent);
			Assert.AreEqual(dataContext.rents.Count(), 4);
			dataRepository.DeleteRent(rent);
			Assert.AreEqual(dataContext.rents.Count(), 3);
		}

		[TestMethod()]
		public void ReturnRentTest()
		{
			Writer writer = new Writer("authorFirstname", "authorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			Reader reader = new Reader("firstname", "lastName");
			DateTime from = new DateTime(2017, 01, 01);
			DateTime to = DateTime.Now;
			Rent rent = new Rent(from, reader, book);
			dataRepository.AddRent(rent);
			dataRepository.ReturnRent(rent, to);
			Assert.AreEqual(dataContext.finished_rents[0], rent);
		}

		[TestMethod()]
		public void GetAllRentsTest()
		{
			Assert.AreEqual(dataContext.rents.Count(), 3);
		}
		#endregion
	}
}