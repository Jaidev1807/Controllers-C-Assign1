using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        ///     to apply 4 arithmetic operater
        /// </summary>
        /// <param name="x">value 1</param>
        /// <param name="y">value 2</param>
        /// <param name="z">value 3/param>
        /// <param name="w">value 4</param>
        /// <returns>
        ///     it will reture the value after entering all the four value in the equation
        /// </returns>
        /// <example>
        ///     GET: api/NumberMachine/12/10/11/9 --> 1332      
        /// </example>
        ///
        /// Get: api/NumberMachine/{x}/{y}/{z}/{w}

        [Route("api/NumberMachine/{x}/{y}/{z}/{w}")]
        [HttpGet]
        public int NumberMachine(int x ,int y ,int z , int w)
        {           
            return (z + 100) * x / (y - w);
        }

    }
}
