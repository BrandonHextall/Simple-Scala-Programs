using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    int PatientId;
    protected void Page_Load(object sender, EventArgs e)
    {
        PatientId = Convert.ToInt32(Session["PatientId"]);
        //get the number of the patient to be processed
        if (!IsPostBack)
        {
            if(PatientId != -1)
            {
                DisplayAddress();
            }
        }
    }

    void DisplayAddress()
    {
        clsPatientCollection aPatientCollection = new clsPatientCollection();
        aPatientCollection.ThisPatient.Find(PatientId);
        txtPatientId.Text = aPatientCollection.ThisPatient.PatientId.ToString();
        txtPName.Text = aPatientCollection.ThisPatient.PName;
        txtPEmail.Text = aPatientCollection.ThisPatient.PEmail;
        txtPDOB.Text = aPatientCollection.ThisPatient.PDOB.ToString();
        txtPHomeAdd.Text = aPatientCollection.ThisPatient.PHomeAdd;
        txtPMainDocId.Text = aPatientCollection.ThisPatient.PMainDocId.ToString();
        chkPAccessReq.Checked = aPatientCollection.ThisPatient.PAccessReq;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPatient
        clsPatient aPatient = new clsPatient();
        string patientId = txtPatientId.Text;
        string pName = txtPName.Text;
        string pEmail = txtPEmail.Text;
        string pDOB = txtPDOB.Text;
        string pHomeAdd = txtPHomeAdd.Text;
        string pMainDocId = txtPMainDocId.Text;
        string pAccessReq = chkPAccessReq.Text;
        //validate data
        string error = aPatient.Valid(pName, pEmail, pHomeAdd, pDOB, pMainDocId);
        
        if (error == "")
        {

            if (patientId != "") { aPatient.PatientId = Convert.ToInt32(patientId); }
            //capture the name 
            aPatient.PName = pName;
            //email
            aPatient.PEmail = pEmail;
            //dob
            aPatient.PDOB = Convert.ToDateTime(pDOB);
            //home address
            aPatient.PHomeAdd = pHomeAdd;
            //Main doctor id
            aPatient.PMainDocId = pMainDocId.Trim().Length != 0 ? Convert.ToInt32(pMainDocId) : (int?)null;
            aPatient.PAccessReq = chkPAccessReq.Checked;

            //collection instance 
            clsPatientCollection aPatientCollection = new clsPatientCollection();

            if (PatientId == -1)
            {
                aPatientCollection.ThisPatient = aPatient;
                aPatientCollection.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                aPatientCollection.ThisPatient.Find(PatientId);
                //set the ThisPatient property
                aPatientCollection.ThisPatient = aPatient;
                aPatientCollection.Update(); 
            }
                Response.Redirect("PatMList.aspx");
        }
        
        else
        {
            //display the error message
            lblError.Text = error;
        }
            //Access requirements
            aPatient.PAccessReq = chkPAccessReq.Checked;
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the patient class
        clsPatient aPatient = new clsPatient();
        //create a variable to store a pk
        Int32 patientId;
        //get pk enterered by user
        patientId = Convert.ToInt32(txtPatientId.Text);
        //find record
        Boolean found = aPatient.Find(patientId);
        //if found
        if (found)
        {
            //display the values of the properties in the form
            txtPName.Text = aPatient.PName;
            txtPEmail.Text = aPatient.PEmail;
            txtPDOB.Text = aPatient.PDOB.ToString();
            txtPHomeAdd.Text = aPatient.PHomeAdd;
            txtPMainDocId.Text = aPatient.PMainDocId.ToString();
            chkPAccessReq.Checked = aPatient.PAccessReq;
        }
    }

    
}