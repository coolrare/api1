using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api1.Models;
using api1.Helpers;
using Microsoft.AspNetCore.Http;

namespace api1.Controllers
{
    [ApiController]
    [Produces("text/json")]
    public class MemberController : ControllerBase
    {
        private readonly JwtHelpers jwt;
        public MemberController(JwtHelpers jwt)
        {
            this.jwt = jwt;
        }

        [HttpPost("~/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public ActionResult<string> Login(LoginUser user)
        {
            if (CheckUser(user.Username, user.Password))
            {
                return Ok(jwt.GenerateToken(user.Username, expireMinutes: 15));
            }
            else
            {
                return BadRequest("您輸入的帳號或密碼錯誤");
            }
        }

        private bool CheckUser(string user, string pass)
        {
            return user == "will";
        }
    }
}