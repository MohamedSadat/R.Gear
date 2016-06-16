using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
     public class CTData : CSSObject
    {
        //public readonly string _EndTag = "</td>";
        //public readonly string _BeginTag = "<td>";
        //private string _tag = "td";
        public CTData(int width, int padding, int border)
        {
            _tag = "td";
            _EndTag = "</td>";
            _BeginTag = "<td>";
            Width = width;
            Padding = padding;
            Border = border;

        }
        public void AddContent(string _s)
        {
            //StringBuilder s = new StringBuilder();
            //s.Append(_BeginTag);
            _text.Append(_s);
            //s.Append(_EndTag);
          //  return _text.ToString();
        }
        //public string GenerateStyle()
        //{
        //    StringBuilder s = new StringBuilder();
        //    s.Append(_tag);
        //    s.Append("{");
        //    s.Append("border:"); s.Append(Border.ToString()); s.Append("px solid black;");

        //    s.Append("border-collapse: collapse;");

        //    s.Append(" padding:"); s.Append(Padding.ToString()); s.Append("px;");

        //    s.Append("text-align: left;");
        //    s.Append("}");
        //    // s.Append("th{color: white;background-color: black;}");
        //    ;
        //    return s.ToString();
        //}
    }
}
