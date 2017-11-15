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

            //using (var content = new XJDAO.XJ_Entities())
            //{
            //    var buildings = from b in content.B_BUILDING
            //                    select new { b.id, b.building_code, b.building_name, b.project_code, b.type, b.create_date, b.remark };
            //    context.Response.Write(JSONHelper.ToJson(buildings));
            //}
            object obj = XJBLL.BLL.Project.getItems();
            context.Response.Write(JSONHelper.ToJson(obj));
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