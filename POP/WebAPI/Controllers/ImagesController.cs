using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.UI;
using VO;
using WebAPI.Liberary;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Images")]
    public class ImagesController : ApiController
    {
        [Route("Download/{IamgeName}")]
        public IHttpActionResult GetIamge(string IamgeName)
        {
            string ImagePase =  Url.Content("/Images/cowboy-2028626_12801.png");
            ApiMessage<string> msg = new ApiMessage<string>();

            msg.Data = ImagePase;
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("Upload/{Iamgepath}")]
        public IHttpActionResult GetUpload(byte[] Iamgepath)
        {
            CommonUtil.ByteToImage(Iamgepath).Save("/Images/cowboy.jpg");
            ApiMessage<bool> msg = new ApiMessage<bool>();

            msg.Data = false;
            msg.ResultCode = (msg.Data == true) ? "F" : "S";
            msg.ResultMessage = (msg.Data == true) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }

}
