
using CreditInfoTask.DAL.Context;
using CreditInfoTask.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfoTask.BLL.Infrastructure
{
    public class ContractService : IContractService
    {

        private readonly AppDbContext _context;

        public ContractService(AppDbContext context)
        {
            _context = context;
        }
        public List<GetContractDTO> GetContractTotalInfo()
        {
            List<GetContractDTO> returnModel = new List<GetContractDTO>();

            var contractId = _context.Contracts.ToList();

            foreach (var item in contractId)
            {
                var contractDataId = _context.ContractDatas.FirstOrDefault(x=>x.ConractId==item.ContractId);

                var addedItem = new GetContractDTO()
                {
                    ContractId=item.ContractId,
                    ContractCode=item.ContractCode,
                    ContractData = _context.ContractDatas.FirstOrDefault(x => x.ConractId == item.ContractId),
                    Individual= _context.Individual.Where(x => x.ContractId == item.ContractId).ToList(),
                    SubjectRole= _context.SubjectRoles.Where(x => x.ContractId == item.ContractId).ToList()
                };
                returnModel.Add(addedItem);
            }

            return returnModel;

        }
    }
}
