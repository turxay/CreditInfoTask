using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfoTask.Domain.Entities
{
	public class Individual
	{
		[Key]
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string CustomerCode { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string NationalId { get; set; }
	}
}
