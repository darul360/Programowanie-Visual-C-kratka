using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Reader
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
        public Reader reader { get; set; }
		public Reader(string firstName, string lastName)
		{
			this.firstName = firstName;
			this.lastName = lastName;
		}
		~Reader() { }
		public override string ToString()
		{
			string outstream = firstName + ' ' + lastName;
			return outstream;
		}
	}
}
