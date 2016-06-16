using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
    public class CTHeader : CSSObject
    {
      
        public CTHeader(int width, int padding, int border)
        {
            _tag = "th";
            _EndTag = "</th>";
            _BeginTag = "<th>";

            Width = width;
            Padding = padding;
            Border = border;
        }
        //public string AddContent(string _s)
        //{
      
        //    _text.Append(_s);
            
        //    return _text.ToString();
        //}
     
    }
}
