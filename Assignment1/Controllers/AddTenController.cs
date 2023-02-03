using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    //  api/addten/10
    public class AddTenController : ApiController
    {
        /// <summary>
        ///     add 10 to the entered number 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> 
        ///     is will show the sum of enter number
        /// </returns>
        /// <example>
        ///    GET:  api/AddTen/10 --> 20
        /// </example>
        ///     GET api/AddTen/{id}
        public int Get(int id)
        {
            
            return id + 10 ;
        }
    }
}
