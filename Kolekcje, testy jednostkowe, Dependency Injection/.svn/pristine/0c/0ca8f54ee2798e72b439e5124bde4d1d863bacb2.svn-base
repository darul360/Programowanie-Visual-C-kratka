using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class DataContext
    {


        public List<Reader> readrs { get; set; }
		public List<Writer> writers { get; set; }
		public Dictionary<int, Book> books { get; set; }
        public ObservableCollection<Rent> rents { get; set; }

        public List<Rent> finished_rents { get; set; }
       
		 public DataContext()
		{
			books = new Dictionary<int, Book>();
			readrs = new List<Reader>();
			writers = new List<Writer>();
			rents = new ObservableCollection<Rent>();
            finished_rents = new List<Rent>();
		}
		
	}
}
