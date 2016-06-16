using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace RGear
{
   

    public class CParagaph:CSSObject 
    {
     
        public CParagaph(string text, HorizontalAlignment align, int fontsize, Color color)
        {
            
            TextAlign = align;
            Text = text;
            FontSize = fontsize;
            Color = color;
            _tag = "p";
            _BeginTag = "<p>";
            _EndTag = "</p>";
        }
  


        
    }
}
