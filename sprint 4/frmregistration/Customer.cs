using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;

namespace frmregistration
{
	class Customer
	{
		private string custname;
		//[DataMember]
		

		public string Custname
		{
			get
			{
				return custname;
			}

			set
			{
				custname = value;
			}
		}

	}
}
