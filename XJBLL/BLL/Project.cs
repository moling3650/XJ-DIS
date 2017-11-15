using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XJDAO;

namespace XJBLL.BLL
{
    public class Project
    {
        public static Object getItems() 
        {
            Object items;
            using (var content = new XJDAO.XJ_Entities())
            {
                items = from p in content.B_PROJECT.ToList<B_PROJECT>()
                        select new { p.id, p.project_code, p.project_name, p.pm, p.phone_no, p.province, p.city, p.create_date, p.remark };
            }
            return items;
        }
    }
}
