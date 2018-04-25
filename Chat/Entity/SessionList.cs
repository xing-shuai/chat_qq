using ClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
    public class SessionList : DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_sessionlist";
        }

        public SessionList(string connString)
        {
            this.connString = connString;
        }

        public override string GetViewName()
        {
            return "v_sessionlist";
        }

    }
}
