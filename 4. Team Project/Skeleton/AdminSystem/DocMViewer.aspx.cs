using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;                                                                                                                         

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create new instance of clsDoc
        clsDoc aDoc = new clsDoc();
        // get the data from the session objedct 
        aDoc = (clsDoc)Session["aDoc"];
        // display the doc firstname 
        Response.Write(aDoc.dId);
        Response.Write(aDoc.dFirstName);
        Response.Write(aDoc.dLastName);
        Response.Write(aDoc.dAddress);
        Response.Write(aDoc.dEmail);
        Response.Write(aDoc.dPhoneNumber);
        Response.Write(aDoc.dAvailability);
    }
}