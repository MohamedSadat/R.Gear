using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace RGear
{
 
    public class CHeading : CSSObject
    {
        public CHeading()
        {
        }
        public CHeading(string text, HorizontalAlignment align, int fontsize, Color color)
        {
            _sbStyle = new StringBuilder();
          //  _style.Append("style=");
            TextAlign = align;
            Text = text;
            FontSize = fontsize;
            Color = color;
            _tag = "h1";
            _BeginTag = "<h1>";
            _EndTag = "</h1>";
        }
    }
}
