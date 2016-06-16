using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RGear
{
    public abstract class CTableObject
    {
        //must inherit 
        protected int _border = 1;
        protected int _width = 1;
        protected int _padding = 1;
        protected int borderspace = 3;
        private StringBuilder _sbStyle = new StringBuilder();
        public CTableObject()
        {
        }
        public CTableObject(int width)
        {
            _width = width;
        }
        //can be redefined
        public virtual int Width { get { return _width; } set { _width = value; } }
      
        public int Heght { get; set; }
        public virtual int Border { get { return _border; } set { _border = value; } }

        //Cell padding specifies the space between the cell content and its borders.
        public int Padding { get { return _padding; } set { _padding = value; } }

        //Border spacing specifies the space between the cells.
        // 	If the table has collapsed borders, border-spacing has no effect.
        public int BorderSpacing { get { return borderspace; } set { borderspace = value; } }

        public int Name { get; set; }
        public int Caption { get; set; }
        public int ForeColor { get; set; }
        public int BackColor { get; set; }
        public int Font { get; set; }
      
        public int TextAlign { get; set; }
        public virtual string GenerateTag()
        {
            return "";
        }

    

    }
    public class CTable:CSSObject
    {
        private StringBuilder s = new StringBuilder();
     //   private StringBuilder _sbTag = new StringBuilder();

        //private string _tag = "table";
        //public readonly string _EndTag = "</table>";
        //public readonly string _BeginTag = "<table>";

        public CTable(int width,int border,int borderspace)
        {
             _tag = "table";
                _EndTag = "</table>";
              _BeginTag = "<table>";
            //_sbTag.Append(_BeginTag);

            Width = width;
           // Border = border;
            BorderSpacing = borderspace;
        }
      
     //   public List<CColumn> Columns { get; set; }
        //public override string GenerateStyle()
        //{
        //    s.Append(_tag);
        //    s.Append("{");
        //    s.Append("width:"); s.Append(Width.ToString());  s.Append("%;");
        //    s.Append("border-spacing:"); s.Append(BorderSpacing.ToString()); s.Append("px;");
        //    s.Append("border:"); s.Append(Border.ToString());  s.Append("px solid black;");
        //    s.Append("border-collapse: collapse;");
        //    s.Append("}");
            
        //    return s.ToString();
        //}
        //public void AddTRows(string data)
        //{
        //    _text.Append(data);
        //}
        //public override string GenerateTag()
        //{
        //    _sbTags.Append(_EndTag);
        //    return _sbTags.ToString();
        //}
    }
  


 
 
}
