using ClassLibrary.DB;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
    public class UserInfo : DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_userinfo";
        }

        public UserInfo(string connString)
        {
            this.connString = connString;
        }

        public override string GetViewName()
        {
            return "v_userinfo";
        }
    }
}
