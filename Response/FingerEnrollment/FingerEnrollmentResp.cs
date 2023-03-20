using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginICAOClientSDK.Response.FingerEnrollment
{
    public class FingerEnrollmentResp : BaseResponse
    {
        public DataFingerEnrollment data { get; set; }
    }
}
