using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace RGear
{
   

    public class CSummary:CSSObject 
    {

        public CSummary()
        {

            _tag = "summary";
            _BeginTag = "<summary>";
            _EndTag = "</summary>";
        }



        
    }
}
