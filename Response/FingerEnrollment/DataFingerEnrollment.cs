using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginICAOClientSDK.Response.FingerEnrollment
{
    public class DataFingerEnrollment
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool finalResult { get; set; }
    }
}
