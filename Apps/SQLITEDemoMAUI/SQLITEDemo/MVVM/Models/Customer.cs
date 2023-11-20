using SQLite;
using SQLITEDemo.Abstractions;
using SQLiteNetExtensions.Attributes;

namespace SQLITEDemo.MVVM.Models
{
	[Table("Customers")]
     public class Customer : TableData
     {
          [Column("name"), Indexed, NotNull]
          public string Name { get; set; }
          [Unique]
          public string Phone { get; set; }
          public int Age { get; set; }
          [MaxLength(100)]
          public string Address { get; set; }
          [Ignore]
          public bool IsYoung =>
               Age > 50 ? true : false;

		#region 1 to 1

		//[ForeignKey(typeof(Passport))]
		//public int PassportId { get; set; }

		//[OneToOne(CascadeOperations = CascadeOperation.All)]
		//public Passport Passport { get; set; }

		#endregion

		#region 1 - n -->>> One Customer with Many Passaports

		//[ForeignKey(typeof(Passport))]
		//public int PassportId { get; set; }

		//[OneToMany(CascadeOperations = CascadeOperation.All)]
		//public List<Passport> Passport { get; set; }

		#endregion

		#region n - n -->>>

		//[ManyToMany(typeof(Passport), CascadeOperations = CascadeOperation.All)]
		//public List<Passport> Passport { get; set; }

		[ManyToMany(typeof(CustomerPassport), CascadeOperations = CascadeOperation.All)]
		public List<Passport> Passports { get; set; }

		#endregion


	}
}
