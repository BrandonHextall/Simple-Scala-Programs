using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

 
    // variable to store the primary key with page level scope
    Int32 recordId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the record to be processed
        recordId = Convert.ToInt32(Session["recordId"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        // creaee a new instance of the collection class 
        clsMedicalRecordCollection medicalRecords = new clsMedicalRecordCollection();

        // find the record to be deleted
        medicalRecords.ThisMedicalRecord.Find(recordId);

        // delete the record
        medicalRecords.Delete();

        // redirect back to the main page
        Response.Redirect("MedRecList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("MedRecList.aspx");

    }
}