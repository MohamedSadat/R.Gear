using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
    public class CTRow : CSSObject
    {
        private StringBuilder _sbTag = new StringBuilder();

        public CTRow()
        {
            _tag = "tr";
            _EndTag = "</tr>";
            _BeginTag = "<tr>";
            _sbTag.Append(_BeginTag);

        }
        public CTRow(int width, int padding, int border)
        {
       _tag = "tr";
            _EndTag = "</tr>";
            _BeginTag = "<tr>";
            Width = width;
            Padding = padding;
            Border = border;
            _sbTag.Append(_BeginTag);

        }
      
    
    }
}
