using ClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
    public class ChatRoomMember : DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_chatroommember";
        }

        public ChatRoomMember(string connString)
        {
            this.connString = connString;
        }

        public override string GetViewName()
        {
            return "v_chatroommember";
        }
    }
}
