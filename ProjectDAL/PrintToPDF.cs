//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.IO;
//using System.Web.UI.HtmlControls;

//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.html.simpleparser;

//namespace ProjectDAL
//{
//    public partial class _Default : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            grid.Visible = true;
//        }


//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            Response.ContentType = "application/pdf";
//            Response.AddHeader("content-disposition",
//            "attachment;filename=GridViewExport.pdf");
//            Response.Cache.SetCacheability(HttpCacheability.NoCache);
//            StringWriter sw = new StringWriter();
//            HtmlTextWriter hw = new HtmlTextWriter(sw);
//            GridView1.AllowPaging = false;
//            GridView1.DataBind();
//            GridView1.RenderControl(hw);
//            StringReader sr = new StringReader(sw.ToString());
//            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
//            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
//            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
//            pdfDoc.Open();
//            htmlparser.Parse(sr);
//            pdfDoc.Close();
//            Response.Write(pdfDoc);
//            Response.End();
//        }
//    }
//}
