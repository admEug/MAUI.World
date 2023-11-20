using SQLITEDemo.Abstractions;
using SQLiteNetExtensions.Attributes;

namespace SQLITEDemo.MVVM.Models
{
	public class Passport : TableData
     {
        public DateTime ExpirationDate { get; set; }

		#region 1 to 1
		// 1 to 1 --> No need for additional code in Passport class
		#endregion

		#region 1 - n -->>> One Customer with Many Passaports

		//[ForeignKey(typeof(Customer))]
		//public int CustomerId { get; set; }

		#endregion

		#region n - n -->>> 
		//[ManyToMany(typeof(Customer))]
		//public int CustomerId { get; set; }

		[ManyToMany(typeof(CustomerPassport), CascadeOperations = CascadeOperation.All)]
		public List<Passport> Customers { get; set; }

		#endregion


	}
}
