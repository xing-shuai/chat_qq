using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class ComboxItem
    {
        private string _Text;
        private string _Value;
        public ComboxItem(string sText, string sValue)
        {
            this._Text = sText;
            this._Value = sValue;
        }

        public string Text
        {
            get
            {
                return _Text;
            }
        }

        public string Value
        {
            get
            {
                return _Value;
            }
        }

        public override string ToString()
        {
            return this.Text;
        }
    }
}
