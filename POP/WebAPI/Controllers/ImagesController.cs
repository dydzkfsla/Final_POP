using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using VO;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Images")]
    public class ImagesController : ApiController
    {
        [Route("Images/{IamgeName}")]
        public IHttpActionResult GetIamge(string IamgeName)
        {
            string ImagePase =  Url.Content("/Images/cowboy-2028626_12801.png");
            ApiMessage<string> msg = new ApiMessage<string>();

            msg.Data = ImagePase;
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
