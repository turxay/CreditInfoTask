using CreditInfoTask.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditInfoTask.BLL.Infrastructure
{
    public interface IContractService
    {

         List<GetContractDTO> GetContractTotalInfo();

    }
}
