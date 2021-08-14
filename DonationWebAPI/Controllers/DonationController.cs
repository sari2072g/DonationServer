using BLDonation;
using DalDonation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationProjectWebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        IDonationBL donationBL;

        public DonationController(IDonationBL donationBL)
        {
            this.donationBL = donationBL;
        }


        [HttpGet("getAllDonation")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<List<Donation>>> getAllDonation()
        {
            var res = await this.donationBL.getAllDonation();
            return res;
        }


        [HttpPost("insertDonation")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<bool>> insertDonation(Donation donationElement)
        {
            var res = await this.donationBL.insertDonation(donationElement);
            return res;
        }


        [HttpPost("updateDonation")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<bool>> updateDonation([FromBody] Donation donationElement)
        {
            var res = await this.donationBL.updateDonation(donationElement);
            return res;
        }


        [HttpPost("deleteDonation")]
        [EnableCors("CorsPolicy")]
        public async Task<ActionResult<bool>> deleteDonation([FromBody] Donation donationElement)
        {
            var res = await this.donationBL.deleteDonation(donationElement);
            return res;
        }
    }
}
