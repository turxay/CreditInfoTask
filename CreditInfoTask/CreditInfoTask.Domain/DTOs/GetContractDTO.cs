using CreditInfoTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfoTask.Domain.DTOs
{
    public class GetContractDTO
    {
        public int ContractId { get; set; }
        public string ContractCode { get; set; }
        public ContractData ContractData { get; set; }
        public List<Individual> Individual { get; set; }
        public List<SubjectRole> SubjectRole { get; set; }

    }
}
