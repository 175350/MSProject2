using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class DALAdministrator
    {
        public static DataSet select(String strwhere)
        {
            string sql = "select * from AdministratorInfo";
            if (strwhere != "")
            {
                sql += " where " + strwhere;
            }
            return DBUtinity.SQLHelp.Query(sql);
        }
        public static bool add(Model.Administrator yh)
        {
            string sql = "insert into AdministratorInfo values('" + yh.用户名 + "','" + yh.密码 + "','"+yh.身份+"')";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
        public static bool modify(Model.Administrator xg)   /*修改*/
        {
            string sql = "update AdministratorInfo set 用户名='"+xg.用户名+"',密码='" + xg.密码 + "' where 身份='"+xg.身份+"'";
            return DBUtinity.SQLHelp.Sqlexcute(sql);
        }
    }
}
