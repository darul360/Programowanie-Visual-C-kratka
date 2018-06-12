using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Writer
	{
		public string authorfirstName { get; set; }
		public string authorlastName { get; set; }
		 public Writer(string authorfirstName, string authorlastname)
		{
			this.authorfirstName = authorfirstName;
			this.authorlastName = authorlastname; 
		}

		public override string ToString()
		{
			return  "Firstname: " + authorfirstName + ", lastname: " + authorlastName + "\n"; 
		
		}
	}
}
