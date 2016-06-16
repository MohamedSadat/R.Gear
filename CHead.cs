using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RGear
{
  public  class CHead
    {
        public readonly string _EndTag = "</head>";
        public readonly string _BeginTag = "<head>";
        public readonly string _BeginStyle = "<style>";
        public readonly string _EndStyle = "</style>";
      
      private readonly string _beginTitle = "<title>";
      private readonly string _endTitle = "</title>";
      public  string _Meta = "<meta charset=\"UTF-8\" />"; //html5 standard
      
      private string _title = "";
      private string _style="";
      private   StringBuilder s = new StringBuilder();
      
      public CHead()
      {
          s.Append(_BeginTag);
          s.Append(_BeginStyle);

      }
      public CHead(string title)
      {
          Title = title;
          s.Append(_BeginTag);
          s.Append(_BeginStyle);
      }

      public string Title { get { return _beginTitle+_title+ _endTitle; } set { _title = value; } }
      public string Meta { get { return _Meta; } set { _Meta = value; } }
    
      public string Style {
          get { return  _style; } 
          set { _style = value; }
      }
      public void AddTitle(string title)
      {
          Title = title;
          //s.Append(title);
      }
      public void AddStyle(string style)
      {
          s.Append(style);

      }
      public void AddMeta(string meta)
      {
          Meta = meta;

      }

      public string GenerateTag()
      {
        //  s.Append(Title);
          s.Append(_EndStyle);
          s.Append(Title);
          s.Append(Meta);
          s.Append(_EndTag);
          return s.ToString();
      }
    }
}
