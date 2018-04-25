using ClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
    public class ServerIP : DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_serverip";
        }

        public ServerIP(string connString)
        {
            this.connString = connString;
        }

        public override string GetViewName()
        {
            return "t_serverip";
        }
    }
}
