using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Assignment1upload : System.Web.UI.Page

   

{
    public readonly int result;

    public Assignment1upload()
    {

        DateTime date1 = new DateTime(2017, 12, 16, 12, 0, 0);
        DateTime now = DateTime.Now;
        // DateTime date1 = new DateTime(2009, 8, 1, 0, 0, 0);
        //DateTime date2 = new DateTime(2009, 8, 1, 12, 0, 0);
        int result = DateTime.Compare(date1, now);
        
    }
     
    



    protected void Button1_Click(object sender, EventArgs e)
    {

        {
            try
            {

                if (this.FileUpload1.HasFile)
                {

                    if (result < 0)
                    {


                        this.FileUpload1.SaveAs("D:\\grading\\A course\\" + this.FileUpload1.FileName);
                        Response.Redirect("Successupload.aspx");
                    }

                    else {
                        this.FileUpload1.SaveAs("D:\\grading\\B course\\" + this.FileUpload1.FileName);
                        Response.Redirect("Successupload.aspx");
                    }

                    
                }
             

            }

            catch (Exception ex)
            {


            }
        }
    }
}