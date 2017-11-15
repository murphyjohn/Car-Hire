using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAttempt3
{
    public partial class frmSearch : Form
    {
        String strConnect = @"Data Source=JOHN\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";
        DataSet dataset = new DataSet();
        public frmSearch()
        {
            InitializeComponent();
            this.Text = "Task A Search - John Murphy " + DateTime.Now.ToShortDateString();

            
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            //populate cboField
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");

            //populate cboOperator
            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            dataset.Reset();
            String strField = cboField.Text.ToString();
            String strOperator = cboOperator.Text.ToString();
            String strValue = txtValue.Text;
            String strSearch = "" + strField + " " + strOperator + " " + "'" + strValue + "'";

            //19. The search should be run only if data exists in all three query criteria controls.
            if (strField.Trim() != "" && strOperator.Trim() !="" && strValue.Trim() != "")
            {
                try
                {
                    using (SqlConnection sqlConnect = new SqlConnection(strConnect))
                    {
                        sqlConnect.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnect;
                        cmd.CommandText = "SELECT * FROM tblCar WHERE " + strSearch;

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dataset);
                        dgvSearchResults.DataSource = dataset.Tables[0];
                        sqlConnect.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must include a value for each of the search criteria.");
            }
            
        }
    }
}
