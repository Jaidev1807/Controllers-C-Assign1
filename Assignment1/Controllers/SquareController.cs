using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        ///     to squeate the entered number
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> 
        ///     it will reurn the square of entered number
        /// </returns>
        /// <example>
        ///     GET: api/Square/8 --> 64
        /// </example>
        /// 
        ///     GET: api/Square/{id}
        public int GET(int id)
        {
            return id * id;
        }
    }
}
