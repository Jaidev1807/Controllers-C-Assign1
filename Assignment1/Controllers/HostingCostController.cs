using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        ///     to get the total pricing from the number of days entered
        /// </summary>
        /// <param name="id">Days</param>
        /// <returns>
        ///     to return the output in which all the value like 
        ///     Fortnight , Price without HST ,HST and Total will be shown
        /// </returns>
        /// <example>
        ///     GET: api/HostingCost/28 --> 2 fortnights at $5.50/FN = $ 11 CAD
        ///                                 HST 13% = $ 1.43 CAD
        ///                                 Total = $ 12.43 CAD
        /// </example>
        /// 
        ///     GET: api/HostingCost/{id}
        public string[] GET(int id)
        {
            var fortnights = id / 14;
            var withoutHST = fortnights * 5.50;
            var HST = withoutHST * 0.13;
            var total = withoutHST + HST;

            /// I didnt knew hoe to return multiple string in one 
            /// get function and i google it and got the this answer
            /// from STACK OVERFLOW to return string array

            return new string[]
            {
                $"{fortnights} fortnights at $5.50/FN = $ {withoutHST}CAD",
                $"HST 13% = ${HST}CAD",
                $"Total = ${total}CAD"
            };
            
        }
    }
}
