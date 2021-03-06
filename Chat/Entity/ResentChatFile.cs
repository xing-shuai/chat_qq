﻿using ClassLibrary.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
   public  class ResentChatFile: DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_resentchatfile";
        }

        public ResentChatFile(string connString)
        {
            this.connString = connString;
        }

        public override string GetViewName()
        {
            return "t_resentchatfile";
        }
    }
}
