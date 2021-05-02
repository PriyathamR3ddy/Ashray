using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
    public class Login
    {   
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mobileNo")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}