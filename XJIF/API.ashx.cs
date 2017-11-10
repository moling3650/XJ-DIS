using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XJIF.Utils;

namespace XJIF
{
    /// <summary>
    /// API 的摘要说明
    /// </summary>
    public class API : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json;charset=utf-8";
            var strJson = new { message = "Hello World!" };
            context.Response.Write(JSONHelper.ToJson(strJson));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}