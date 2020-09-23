using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MiddlePlatform.Models;

namespace MiddlePlatform.Controllers
{
    
    public class MiddlePlatformController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("MPAccess")]
        public bool MPAccess(int iIn)
        {
            if (iIn == 0)
                return false;
            else
                return true;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("MPAccess1")]
        public int MPAccess1(int iIn)
        {
           return iIn;
        }
    }
}
