using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace RGear
{
    public class Class1
    {
        List<DataColumn> lstCol = new List<DataColumn>();
        

        public string FormatDataTable(DataTable t,string name)
        {

            CTable xTable = new CTable(80,1,3);
            CTData xTData = new CTData(5,5,1);
            CTHeader xTHead = new CTHeader(5,5,1);
            CTRow xTRow = new CTRow();
            CHead xHead = new CHead(name);
            CBody xBody = new CBody();
            CHtmlDoc xHtml = new CHtmlDoc();
            StringBuilder s = new StringBuilder();
           
            //Begin head
          //  xHead.AddStyle(xTable.GenerateStyle());
          //  xHead.AddStyle(xTData.GenerateStyle());
          //  xHead.AddStyle(xTHead.GenerateStyle());
            xHtml.AddContent(xHead.GenerateTag());
            //End head

            //Begin & end table header
            xTRow = new CTRow();
            //xTRow.AddContent(xTHead.AddContent("ItemId"));
            //xTRow.AddContent(xTHead.AddContent("ItemName"));
            //xTRow.AddContent(xTHead.AddContent("ItemGroup"));
            //xTRow.AddContent(xTHead.AddContent("Sales price"));
            //xTRow.AddContent(xTHead.AddContent("Type"));
            //xTRow.AddContent(xTHead.AddContent("Unit"));
            //End row
            xTable.AddContent(xTRow.GenerateTag());
            //Begin row & create table data
            foreach (DataRow r in t.Rows)
            {
                xTRow = new CTRow();
                xTData = new CTData(5, 3, 1);
                xTData.AddContent(r[1].ToString());
                xTRow.AddContent(xTData.GenerateTag());
                xTData = new CTData(5, 3, 1);
                xTData.AddContent(r[2].ToString());
                xTRow.AddContent(xTData.GenerateTag()); xTData = new CTData(5, 3, 1);
                xTData.AddContent(r[3].ToString());
                xTRow.AddContent(xTData.GenerateTag()); xTData = new CTData(5, 3, 1);
                xTData.AddContent(r[4].ToString());
                xTRow.AddContent(xTData.GenerateTag());


                xTData = new CTData(5, 3, 1);
                xTData.AddContent(r["ItemTypeText"].ToString());
                xTRow.AddContent(xTData.GenerateTag());

                xTData = new CTData(5, 3, 1);
                xTData.AddContent(r["Unit"].ToString());
                xTRow.AddContent(xTData.GenerateTag());


             //   xTRow.AddTData(xTData.AddContent(r["ItemTypeText"].ToString()));
              //  xTRow.AddTData(xTData.AddContent(r["Unit"].ToString()));

                xTable.AddContent(xTRow.GenerateTag());//add row to table
            }

           // s.Append("</div>");
            //BEGIN BODY

           // xBody.AddBody(xBody.AppendHeading1(name + " report"));
            xBody.AddContent(xTable.GenerateTag());
            xBody.AddContent(xBody.CreateHR());
          //  xBody.AddBody(xBody.AppendHeading1("row count " + t.Rows.Count.ToString()));
            xHtml.AddContent(xBody.GenerateTag());
            //End body

            s.Append(xHtml.GenerateTag());

            return s.ToString();

        }
    
    }
}
