﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreditInfoTask.Domain.Entities
{
	public class GuaranteeAmount
	{
			
        public int SubjectRoleId { get; set; }
        public string Value { get; set; }
		public string Currency { get; set; }
	}	
}
