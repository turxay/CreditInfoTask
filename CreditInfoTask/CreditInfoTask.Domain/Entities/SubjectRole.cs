using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfoTask.Domain.Entities
{
	[Table("SubjectRole", Schema = "dbo")]
	public class SubjectRole
	{
		[Key]
		[Column("Id")]
        public int Id { get; set; }
		[Column("ContractId")]
		public int ContractId { get; set; }
		[Column("CustomerCode")]
		public string CustomerCode { get; set; }
		[Column("RoleOfCustomer")]
		public string RoleOfCustomer { get; set; }		
	}	
}
