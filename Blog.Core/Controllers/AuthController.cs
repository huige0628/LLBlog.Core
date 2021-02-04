using Blog.Core.AuthHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Core.Controllers
{
    /// <summary>
    /// 认证控制器
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// 获取认证token
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetJwtStr(string name, string pass)
        {
            string jwtStr;
            bool suc;

            // 获取用户的角色名，请暂时忽略其内部是如何获取的，可以直接用 var userRole="Admin"; 来代替更好理解。
            //var userRole = await _sysUserInfoServices.GetUserRoleNameStr(name, pass);
            if (true)
            {
                // 将用户id和角色名，作为单独的自定义变量封装进 token 字符串中。
                JwtTokenModel tokenModel = new JwtTokenModel { Uid = 1, Role = "Admin" };
                jwtStr = JwtHelper.IssueJwt(tokenModel);//登录，获取到一定规则的 Token 令牌
                suc = true;
            }
            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}
