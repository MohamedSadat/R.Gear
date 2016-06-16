using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace RGear
{
    public enum tTextAlign { left, right, center };
    public enum tFloat { right, left };

    // Summary:
    //     Specifies how border atyle
    //     to an element of the control.
    public enum tBorderStyle { dotted, dashed, solid, Double, groov, ridge, inset, outset, none, hodden };

    public struct sBorder
    {
        public int _width;
        public Color _color;
        public tBorderStyle _boredrStyle;
    }
    
    public abstract class CSSObject
    {
        protected string _tag = "";
        protected StringBuilder _sbStyle=new StringBuilder();
        protected StringBuilder _sbTags=new StringBuilder();

        protected Color _color;
        protected Color _backColor;
        protected Color _BorderColor = Color.Black;
        protected HorizontalAlignment _textAlign = HorizontalAlignment.Left;
        protected int _fontSize = 100;
        protected  string _EndTag = "</>";
        protected  string _BeginTag = "<>";
        protected string _href = "";
        protected string _src = "";
        protected tFloat _float;
        protected tFloat _clear;
        
        protected StringBuilder _text=new StringBuilder();
        protected tBorderStyle _borderStyle = tBorderStyle.none;
        protected int _borderWidth = 5;
        protected int _margin = 0;
        protected int _padding = 0;
        protected sBorder _sborder;
        protected int borderspace=0;
        protected int _width = 10;
        protected int _height = 10;

        protected int _border = 3;
        protected bool _borderCollapse=false;
        protected bool _direction;

     //   protected Hashtable _htTags=new Hashtable();

        #region "Properties"
        public virtual HorizontalAlignment TextAlign
        {
            set
            {
                _textAlign = value;
                _sbStyle.Append("text-align:");
                _sbStyle.Append(_textAlign);
                _sbStyle.Append(";");

            }
            get { return _textAlign; }
        }
        //public virtual HorizontalAlignment VerticalAlign
        //{
        //    set
        //    {
        //        _textAlign = value;
        //        _sbStyle.Append("vertical-align:");
        //        _sbStyle.Append(_textAlign);
        //        _sbStyle.Append(";");

        //    }
        //    get { return _textAlign; }
        //}
        public virtual Color Color
        {
            set
            {
                _color = value;

                _sbStyle.Append("color:");
                _sbStyle.Append(_color.Name);
                _sbStyle.Append(";");
              //  _htTags.Add("color",Color.Name);

            }
            get { return _color; }
        }
        public Color BackGroundColor
        {
            set
            {
                _backColor = value;


                _sbStyle.Append("background-color:");
                _sbStyle.Append(_backColor.Name);
                _sbStyle.Append(";");
              //  _htTags.Add("background-color", _backColor.Name);

            }
            get { return _backColor; }
        }
      
        #region "Border"
        public tBorderStyle BorderStyle
        {
            set
            {
                _borderStyle = value;


                _sbStyle.Append("border-style:");
                switch (_borderStyle)
                {
                    case tBorderStyle.solid:
                        _sbStyle.Append("solid");
                    //    _htTags.Add("border-style", "solid");

                        break;
                }
                
                _sbStyle.Append(";");

            }
            get { return _borderStyle; }
        }
        public int BorderWidth
        {
            set
            {
                _borderWidth = value;


                _sbStyle.Append("border-width:");
                _sbStyle.Append(_borderWidth);
                _sbStyle.Append("px;");
                //border-width: 2px 10px 4px 20px;
              //  _htTags.Add("border-width", _borderWidth);

            }
            get { return _borderWidth; }
        }

        public Color BorderColor
        {
            set
            {
                _BorderColor = value;

                _sbStyle.Append("border-color:");
                _sbStyle.Append(_BorderColor.Name);
                _sbStyle.Append(";");
              //  _htTags.Add("border-color", _BorderColor.Name);


            }
            get { return _BorderColor; }
        }

        public int BorderSpacing { get { return borderspace; } set { borderspace = value;  } }
        public virtual int Border { get { return _border; } set { _border = value; } }
        public bool BordaerCollapse
        {
            set
            {
                _borderCollapse = value;
                if (_borderCollapse == true)
                {
                    _sbStyle.Append("border-collapse:");
                    _sbStyle.Append("collapse");
                    _sbStyle.Append(";");
                  //  _htTags.Add("border-collapse", "collapse");
                    
                }

            }
            get { return _borderCollapse; }
        }
        #endregion
        public virtual string Text
        {
            set { _text.Append(value); }
            get { return _text.ToString(); }
        }
        public virtual string Tag
        {
            set { _tag = value; }
            get { return _tag; }
        }
        public int Margin
        {
            set
            {
                _margin = value;

                _sbStyle.Append("margin:");
                _sbStyle.Append(_margin);
                _sbStyle.Append("px;");
              //  _htTags.Add("margin", _margin);


            }
            get { return _margin; }
        }
        public int Padding
        {
            set
            {
                _padding = value;

                _sbStyle.Append("padding:");
                _sbStyle.Append(_padding);
                _sbStyle.Append("px;");
               // _htTags.Add("padding", _padding);

            }
            get { return _padding; }
        }
    
        public int FontSize
        {
            set
            {
                _fontSize = value;
                _sbStyle.Append("font-size:");
                _sbStyle.Append(_fontSize);
                _sbStyle.Append("%;");
             //   _htTags.Add("font-size", _fontSize);


            }
            get { return _fontSize; }
        }
        
        public virtual int Width
        { 
            get { 
            return _width;

        } 
            set { _width = value;
            _sbStyle.Append("width:");
            _sbStyle.Append(_width);
            _sbStyle.Append("px;");
           // _htTags.Add("width", _width);

            } }
        public virtual int Height
        {
            get
            {
                return _height;

            }
            set
            {
                _height = value;
                _sbStyle.Append("height:");
                _sbStyle.Append(_height);
                _sbStyle.Append("px;");
              //  _htTags.Add("height", _height);

            }
        }
   
        public virtual bool Direction
        {
            get
            {
                return _direction;

            }
            set
            {
                _direction = value;
                if (_direction == true)
                {
                    _sbStyle.Append("direction:");
                    _sbStyle.Append("rtl");
                    _sbStyle.Append(";");
                  //  _htTags.Add("direction", "rtl");

                }
            }
        }
        public string  HRef
        {
            get
            {
                return _href;

            }
            set
            {
                _href = value;
                    _sbStyle.Append("href:");
                    _sbStyle.Append(_href);
                    _sbStyle.Append(";");
         
            }
        }
        public string SRC
        {
            get
            {
                return _src;

            }
            set
            {
                _src = value;
                _sbStyle.Append("src:");
                _sbStyle.Append(_src);
                _sbStyle.Append(";");

            }
        }
        public tFloat Float
        {
            get
            {
                return _float;

            }
            set
            {
                _float = value;
                _sbStyle.Append("float:");
                if(_float==tFloat.left)
                _sbStyle.Append("left");
                else
                    _sbStyle.Append("right");

                _sbStyle.Append(";");

            }
        }
        public tFloat Clear
        {
            get
            {
                return _clear;

            }
            set
            {
                _clear = value;
                _sbStyle.Append("clear:");
                if (_clear == tFloat.left)
                    _sbStyle.Append("left");
                else
                    _sbStyle.Append("right");

                _sbStyle.Append(";");

            }
        }
#endregion
            #region "Functions"

            public virtual void AddContent(string data)
            {
                _text.Append(data);
            }
            public virtual void ReplaceContent(string data)
            {
                ClearContent();
                _text.Append(data);
            }
         public virtual void ClearContent()
            {
                
                _text=new StringBuilder();
            }
         public virtual string GenerateStyle()
         {
             
             return _sbStyle.ToString();
         }
            public virtual string GenerateTag()
            {
                // _sbTags = new StringBuilder();
                _sbTags.Append("<");
                _sbTags.Append(_tag);

                _sbTags.Append(" style=");
                _sbTags.Append(_sbStyle.ToString());
                _sbTags.Append(">");
                _sbTags.Append(_text.ToString());
                _sbTags.Append(_EndTag);

                return _sbTags.ToString();
            }
            //public Hashtable Tags
            //{
            //    get { return _htTags; }  
            //}
#endregion
    }

}
