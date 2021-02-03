﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;
using WebAPI.DAC;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/TeamInfo")]
    public class TeamInfoController : ApiController
    {
        [Route("{Code}")]
        public IHttpActionResult GetTeamInfoForEmp(string Code)
        {
            ApiMessage<List<TeamInfoVO>> msg = new ApiMessage<List<TeamInfoVO>>();

            TeamInfoDAC uDac = new TeamInfoDAC();
            msg.Data = uDac.GetTeamInfoForEmp(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
