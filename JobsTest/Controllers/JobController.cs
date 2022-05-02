using JobHiring.Models;
using JobHiring.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UserTestApi.Controllers
{
    [EnableCors()]
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            List<JobModel> jobs = new List<JobModel>();
            return Ok(jobs);
        }

        [HttpGet]
        public IActionResult Get(int month, int year)
        {
            JobModel jobs = _jobService.GetJobModel(month, year);

            return Ok(jobs);

            //test
            //return BadRequest("jobs were not found");
        }

    }
}
