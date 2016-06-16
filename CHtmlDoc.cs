using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
    public class CHtmlDoc
    {
        public readonly string _EndTag = "</html>";
        public readonly string _BeginTag = "<html>";
        public readonly string _Declare = "<!DOCTYPE html>";
        private StringBuilder _sbTag = new StringBuilder();

        public CHtmlDoc()
        {
            _sbTag.Append(_Declare);
            _sbTag.Append(_BeginTag);
 
        }
        public void AddContent(string data)
        {
            _sbTag.Append(data);
        }
        public string GenerateTag()
        {
            _sbTag.Append(_EndTag);
            return _sbTag.ToString();
        }
    }
}
