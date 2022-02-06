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

	[Table("ContractData", Schema = "dbo")]
	public class ContractData
	{
		[Key]
		[Column("Id")]
		public int Id { get; set; }
		[Column("ContractId")]
        public int ConractId { get; set; }

		[Column("DateOfLastPayment")]
		public DateTime? DateOfLastPayment { get; set; }
		[Column("NextPaymentDate")]
		public DateTime? NextPaymentDate { get; set; }
		[Column("DateAccountOpened")]
		public DateTime? DateAccountOpened { get; set; }
		[Column("RealEndDate")]
		public DateTime? RealEndDate { get; set; }
	}
}
