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
	[Table("Contract",Schema = "dbo")]
	public class Contract
	{
		[Key]
        public int ContractId { get; set; }
        public string ContractCode { get; set; }	
	}
}
