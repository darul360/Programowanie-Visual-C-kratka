using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class DataService 
    {
        public DataRepository dataRepository { get; set; }
        public DataContext dataContext { get; set; }
        public DataService(DataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        public void AddRental(Reader reader, Book book)
        {
            DateTime from = DateTime.Now;
            Rent rent = new Rent(from, reader, book);
            dataRepository.AddRent(rent);
        }
        public Dictionary<int, Book> BooksWithMorePages(int iloscStron)
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            IEnumerable<Book> query = from book in dataRepository.dataContext.books.Values
                                      where book.numberPages > iloscStron
                                      select book;
            foreach (Book i in query)
            {
                books.Add(i.id, i);
            }
            return books;
        }
        public ObservableCollection<Rent> BorrowReader(string firstname, string lastname)
        {
            ObservableCollection<Rent> rents = new ObservableCollection<Rent>();
            IEnumerable<Rent> query = from rent in dataRepository.dataContext.rents
                                      where rent.reader.firstName == firstname && rent.reader.lastName == lastname
                                      select rent;

            foreach (Rent i in query)
            {
                rents.Add(i);
            }
            return rents;
        }
        public Dictionary<int, Book> ChooseType(string type)
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            IEnumerable<Book> query = from book in dataRepository.dataContext.books.Values
                                      where book.type == type
                                      select book;
            foreach (Book i in query)
            {
                books.Add(i.id, i);
            }
            return books;
        }
        public List<Reader> ReaderNeverBorrowed()
        {
            List<Reader> readers = new List<Reader>();

            var query = (from rent in dataRepository.dataContext.rents
                         select rent.reader).Distinct();
            foreach (Reader i in query)
            {
                readers.Add(i);
            }
            return readers;
        }
        public ObservableCollection<Rent> DuringRental()
        {
            ObservableCollection<Rent> rents = new ObservableCollection<Rent>();
            IEnumerable<Rent> query = from rent in dataRepository.dataContext.rents
                                      where rent.isReturned == false
                                      select rent;
            foreach (Rent i in query)
            {
                rents.Add(i);
            }
            return rents;
        }
        public IEnumerable<Rent> RentalDateFind(DateTime od, DateTime doo)
        {
            List<Rent> finished_rents = new List<Rent>();
            IEnumerable<Rent> query = from rent in dataRepository.dataContext.finished_rents
                                      where rent.returnalDate<= doo && rent.rentalDate>=od && doo>od && rent.returnalDate>rent.rentalDate
                                      select rent;
            foreach (Rent i in query)
            {
                yield return i;
            }
        }

        #region IENUM

        public String ShowFun(int num)
        {
            String fine;
            switch (num)
            {
                case 1:
                foreach (Reader value in reader_all())
                {
                        fine= value.ToString();
                   return fine;
            }

            break;

             case 2:
             foreach (Book value in book_all())
             {
                     fine=value.ToString();
                        return fine;
             }
                 break;
             case 3:
             foreach (Rent value in rent_all())
             {
                      fine=value.ToString();
                        return fine;
             }
                 break;
         }
            return null;
        }

        public  IEnumerable<Reader> reader_all()
        { 
           List<Reader> readers = new List<Reader>();

            var query = (from reader  in dataRepository.dataContext.readrs
                         select reader).Distinct();
            foreach (Reader value in query)
            {
                
                yield return value;
            }

        }



        public IEnumerable<Book> book_all()
        {
            return dataRepository.dataContext.books.Values;
        }


        public IEnumerable<Rent> rent_all()
        {
            ObservableCollection<Rent> rents = new ObservableCollection<Rent>();
            IEnumerable<Rent> query = from rent in dataRepository.dataContext.rents
                                      select rent;
            foreach (Rent i in query)
            {
                yield return i;
            }

        }

        #endregion



    }
}


