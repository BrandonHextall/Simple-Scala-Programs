using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayMedicalRecords();
        }
    }

    void DisplayMedicalRecords()
    {
        try
        {
            clsMedicalRecordCollection MedicalRecords = new clsMedicalRecordCollection();
            if (MedicalRecords == null)
            {
                lblStatus.Text = "MedicalRecords is null";
                return;
            }

            var list = MedicalRecords.MedicalRecordList;
            if (list == null)
            {
                lblStatus.Text = "MedicalRecordList is null";
                return;
            }

            lblStatus.Text = $"List count = {list.Count}";
            lstMedicalRecordList.DataSource = list;
            lstMedicalRecordList.DataValueField = "recordId";   // must match public property
            lstMedicalRecordList.DataTextField = "AppNotes";    // must match public property
            lstMedicalRecordList.DataBind();
            lblStatus.Text += $"; Bound items = {lstMedicalRecordList.Items.Count}";
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Exception: " + ex.GetType().Name + " - " + ex.Message;
        }
    }
}