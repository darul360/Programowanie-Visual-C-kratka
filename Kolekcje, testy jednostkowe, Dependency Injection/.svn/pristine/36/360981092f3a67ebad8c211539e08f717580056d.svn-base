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
	public class DataServiceTests
	{
		public DataServiceTests()
		{
			dataRepository = new DataRepository(wypelnienieStalymi, dataContext);
			dataService = new DataService(dataRepository);
		}

		WypelnienieStalymi wypelnienieStalymi = new WypelnienieStalymi();
		DataContext dataContext = new DataContext();
		DataRepository dataRepository;
		DataService dataService;

		[TestMethod()]
		public void AddRentalTest()
		{
			Reader reader = new Reader("Maciej", "Cierpikowski");
			Writer writer = new Writer("AuthorFirstname", "AuthorLastname");
			Book book = new Book("title", writer, 300, 1, "Przygodowa");
			dataService.AddRental(reader, book);
			Assert.AreEqual(dataService.dataRepository.GetAllRents().Count(), 4);
		}

		[TestMethod()]
		public void BooksWithMorePagesTest()
		{
			Assert.AreEqual(dataService.BooksWithMorePages(401).Count(), 1);
		}

		[TestMethod()]
		public void BorrowReaderTest()
		{
			Assert.AreEqual(dataService.BorrowReader("Jan", "Kowalski").Count(), 1);
		}

		[TestMethod()]
		public void ChooseTypeTest()
		{
			Assert.AreEqual(dataService.ChooseType("Dramat").Count(), 2);
		}

		[TestMethod()]
		public void ReaderNeverBorrowedTest()
		{
			Assert.AreEqual(dataService.ReaderNeverBorrowed().Count(), 2);
		}

		[TestMethod()]
		public void DuringRentalTest()
		{
			Assert.AreEqual(dataService.DuringRental().Count(), 3);
		}

		[TestMethod()]
		public void RentalDateFindTest()
		{
			Writer writer = new Writer("AuthorFirstname", "AuthorLastname");
			Book book = new Book("Tytul", writer, 320, 4, "type");
			Reader reader = new Reader("firstname", "lastName");

			Writer writer1 = new Writer("AuthorFirstname", "AuthorLastname");
			Book book1 = new Book("Tytul1", writer1, 320, 5, "type1");
			Reader reader1 = new Reader("firstname1", "lastName1");

			DateTime from = new DateTime(2017, 01, 01);
			DateTime to = new DateTime(2017, 02, 01);
			DateTime to1 = new DateTime(2017, 06, 01);

			Rent rent = new Rent(from, reader, book);
			Rent rent1 = new Rent(from, reader1, book1);

			dataRepository.AddRent(rent);
			dataRepository.AddRent(rent1);

			dataRepository.ReturnRent(rent, to);
			dataRepository.ReturnRent(rent1, to1);

			DateTime from2 = new DateTime(2016, 01, 01);
			DateTime to2 = new DateTime(2017, 04, 01);
			Assert.AreEqual(dataService.RentalDateFind(from2, to2).Count(), 1 );
		}

        [TestMethod()]

        public void Test_IENUM()
        {
            Assert.AreEqual(dataService.ShowFun(1).ToString(), "Jan Kowalski");
        }

    }
}