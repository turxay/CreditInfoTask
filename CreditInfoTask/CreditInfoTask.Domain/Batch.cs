using CreditInfoTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditinfoCandidateExamBLL.Models
{
	public class Batch
	{
		public List<Contract> Contract { get; set; }
		public string Ci { get; set; }
		public string Xsi { get; set; }
		public string SchemaLocation { get; set; }
	}
}
