using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {       
        /// <summary>
        ///     To post the string 
        /// </summary>
        /// <returns> 
        ///     it will returen "Hello World" when api is entered
        /// </returns>
        /// <example>
        ///     POST: api/Greeting --> Hello world
        /// </example>
        ///     api/Greeting
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        ///     to enter the id in api and get that in output strig 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns> 
        ///     it shows the output of the entered number 
        /// </returns>
        /// <example>
        ///     GET:  api/Greeting/10 --> Greeting to 10 people
        /// </example>
        ///     api/Greeting/{id}
        public string Get(int id)
        {
            return "Greeting to " + id + " people!";
        }
    }
}
