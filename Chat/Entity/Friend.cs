using Chat.Public;
using ClassLibrary.DB;
using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entity
{
    public class Friend : DBSqlBase
    {
        public override string GetTableName()
        {
            return "t_friends";
        }

        public override string GetViewName()
        {
            return "v_friend";
        }
        public Friend(string connString)
        {
            this.connString = connString;
        }

        public JsonData GetFriendList(string account)
        {
            JsonData friendList = new JsonData();
            friendList.SetJsonType(JsonType.Array);
            Group group = new Group(PublicTool.GetAppConfig("mySqlConn"));
            JsonData groupData = group.ExecuteSimpleQuery("Owner='" + account + "'");
            foreach (JsonData ob in groupData)
            {
                JsonData listItem = new JsonData();
                listItem["group"] = ob;
                JsonData sort = new JsonData();
                sort["field"] = "OnLineState";
                sort["type"] = "desc";
                listItem["friends"] = this.ExecuteSimpleQueryWithSort("Account='" + account + "' and GroupID='" + ob["ID"].ToString() + "'", sort);
                friendList.Add(listItem);
            }
            return friendList;
        }
    }
}
