using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
 public   class CBody:CSSObject
    {
 
        public CBody()
        {
            _tag = "body";
            _BeginTag = "<body>";
            _EndTag = "</body>";

        }
     

        public string CreateHR()
        {
            return "<hr />"; //html5 standard
        }
    }

}
