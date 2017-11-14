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
    public partial class frmCars : Form
    {
        String strConnection = @"Data Source=JOHN\SQLEXPRESS;Initial Catalog=Hire;Integrated Security=True;";
        int currentRow = 0;
        DataSet dataset = new DataSet();

        public frmCars()
        {
            InitializeComponent();
            this.Text = "Task A - John Murphy - " + DateTime.Now.ToShortDateString();
        }

        private void frmCars_load(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection sqlConnect = new SqlConnection(strConnection))
                {
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnect;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM tblCar";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); //the adapter takes in the command!
                    adapter.Fill(dataset);
                    displayThisRow();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void displayThisRow()
        {
            txtVehicleRegNo.Text = Convert.ToString(dataset.Tables[0].Rows[currentRow]["VehicleRegNo"]);
            txtMake.Text = Convert.ToString(dataset.Tables[0].Rows[currentRow]["Make"]);
            txtEngineSize.Text = Convert.ToString(dataset.Tables[0].Rows[currentRow]["EngineSize"]);
            //convert the dateregistered to a DATETIME, then use .toString("dd-MM-yyyy") for the format.
            txtDateRegistered.Text = Convert.ToDateTime(dataset.Tables[0].Rows[currentRow]["DateRegistered"]).ToString("dd-MM-yyyy");
            txtRentalPerDay.Text = "€" + Convert.ToString(dataset.Tables[0].Rows[currentRow]["RentalPerDay"]);
            chkAvailable.Checked = Convert.ToBoolean(dataset.Tables[0].Rows[currentRow]["Available"]);
            checkRecordCount();
        }

        private void checkRecordCount()
        {
            if(currentRow == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else if(currentRow >= dataset.Tables[0].Rows.Count - 1)
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            txtCurrentRecord.Text = "" + (currentRow + 1) + " of " + dataset.Tables[0].Rows.Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnect;
                    cmd.CommandText = "UPDATE tblCar SET VehicleRegNo = @VehicleRegNo, Make = @Make, EngineSize = @EngineSize," +
                        " DateRegistered = @DateRegistered, RentalPerDay = @RentalPerDay, Available = @Available " +
                        "WHERE VehicleRegNo = @OldVehicleRegNo";

                    cmd.Parameters.AddWithValue("@OldVehicleRegNo", SqlDbType.NVarChar).Value
                        = Convert.ToString(dataset.Tables[0].Rows[currentRow]["VehicleRegNo"]);
                    cmd.Parameters.AddWithValue("@VehicleRegNo", SqlDbType.NVarChar).Value = txtVehicleRegNo.Text;
                    cmd.Parameters.AddWithValue("@EngineSize", SqlDbType.NVarChar).Value = txtEngineSize.Text;
                    cmd.Parameters.AddWithValue("@Make", SqlDbType.NVarChar).Value = txtMake.Text;
                    cmd.Parameters.AddWithValue("@DateRegistered", SqlDbType.Date).Value = Convert.ToDateTime(txtDateRegistered.Text);
                    cmd.Parameters.AddWithValue("@RentalPerDay", SqlDbType.SmallMoney).Value = txtRentalPerDay.Text;
                    cmd.Parameters.AddWithValue("@Available", SqlDbType.Bit).Value = chkAvailable.Checked;

                    sqlConnect.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Vehicle details updated");
                }
                dataset.Reset();
                frmCars_load(null, null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnect = new SqlConnection(strConnection))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnect;
                    cmd.CommandText = "INSERT INTO tblCar(VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available) " +
                        "VALUES(@VehicleRegNo, @Make, @EngineSize, @DateRegistered, @RentalPerDay, @Available)";

                    cmd.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text);
                    cmd.Parameters.AddWithValue("@Make", txtMake.Text);
                    cmd.Parameters.AddWithValue("@EngineSize", txtEngineSize.Text);
                    cmd.Parameters.AddWithValue("@DateRegistered", Convert.ToDateTime(txtDateRegistered.Text));
                    cmd.Parameters.AddWithValue("@RentalPerDay", txtRentalPerDay.Text);
                    cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);

                    sqlConnect.Open();
                    cmd.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("New record added to database.");
                }
                dataset.Reset();
                frmCars_load(null, null);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(null, "Are you sure you want to delete this record", "WARNING!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlConnect = new SqlConnection(strConnection))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnect;
                        cmd.CommandText = "DELETE FROM tblCar WHERE VehicleRegNo = @VehicleRegNo";
                        cmd.Parameters.AddWithValue("@VehicleRegNo", txtVehicleRegNo.Text);
                        sqlConnect.Open();
                        cmd.ExecuteNonQuery();
                        sqlConnect.Close();
                        MessageBox.Show("Record deleted from database");
                    }
                    dataset.Reset();
                    currentRow = 0;
                    frmCars_load(null, null);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch();
            search.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actions Cancelled");
            dataset.Reset();
            frmCars_load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            displayThisRow();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentRow--;
            displayThisRow();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentRow++;
            displayThisRow();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentRow = dataset.Tables[0].Rows.Count - 1;
            displayThisRow();
        }
    }
}
