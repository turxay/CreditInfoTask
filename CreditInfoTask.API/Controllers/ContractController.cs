using CreditInfoTask.BLL.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditinfoCandidateExamApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ContractController : ControllerBase
    {


        private readonly IContractService _service;

        public ContractController(IContractService contractService)
        {
            this._service = contractService;
        }

        [HttpGet]
        public IActionResult GetInfo()
        {

            _service.GetContractTotalInfo();

            return Ok(_service.GetContractTotalInfo()); 

        }
    }
}
