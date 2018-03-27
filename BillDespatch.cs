﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MANUUFinance
{
    public partial class frmBillDespatch : Form
    {
        bool retrievedForUpdate;
        bool queryMode;
        DateTime today = DateTime.Today;

        public frmBillDespatch()
        {
            InitializeComponent();
        }

        private void frmBillDespatch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet1.BillDtl' table. You can move, or remove it, as needed.
            this.billDtlTableAdapter.Fill(this.financeDataSet1.BillDtl);
            // TODO: This line of code loads data into the 'financeDataSet.BillDtl' table. You can move, or remove it, as needed.
            this.billDtlTableAdapter.Fill(this.financeDataSet.BillDtl);
            // TODO: This line of code loads data into the 'financeDataSet.BillMstView' table. You can move, or remove it, as needed.
            this.billMstViewTableAdapter.Fill(this.financeDataSet.BillMstView);

            txtPKBillID.Text = "0";
            txtBillDate.Text = today.ToString("dd/MM/yyyy");
            retrievedForUpdate = false;
            queryMode = false;
            PrepareDeptCombo();
            PrepareBillTypeCombo();
            PrepareBillStatusCombo();
        }

        //DML Region Starts here
        #region

        //Prepare Department Combo
        private void PrepareDeptCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKDEPID, DEPNAME FROM [Finance].[dbo].[DEPT] Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboDept.DisplayMember = "ListItemDesc"; // will display Name property
                comboDept.ValueMember = "ListItemID"; // will select Value property
                comboDept.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Prepare Bill Type Combo
        private void PrepareBillTypeCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] WHERE GEMID = 2 Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBillType.DisplayMember = "ListItemDesc"; // will display Name property
                comboBillType.ValueMember = "ListItemID"; // will select Value property
                comboBillType.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Prepare Bill Type Combo
        private void PrepareEmployeesCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKEMPID, EMPFNAME + ' ' + ISNULL(EMPMNAME,'') + ' ' + ISNULL(EMPLNAME,'') + ' (' + EMPIDCardNo + ')' FROM [Finance].[dbo].[EMP] WHERE FKEmpPostDeptID = " + comboDept.SelectedValue + " Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Prepare Students Combo
        private void PrepareStudentsCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSTUID, StuFname + ' ' + ISNULL(StuMname,'') + ' ' + ISNULL(StuLname,'') + ' (' + EnrollmentNo + ')' FROM [Finance].[dbo].[Student] WHERE FkStuDeptID = " + comboDept.SelectedValue + " Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Prepare Suppliers Combo
        private void PrepareSuppliersCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSUPID, SUPPLIERNAME FROM [Finance].[dbo].[SUPPLIER] Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Prepare Bill Status Combo
        private void PrepareBillStatusCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] WHERE GEMID = 3 Order by 2";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBillStatus.DisplayMember = "ListItemDesc"; // will display Name property
                comboBillStatus.ValueMember = "ListItemID"; // will select Value property
                comboBillStatus.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Add Account Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //If Form Controls are validated proceed to add record
            if (validateRecord())
            {
                //Check if we are not Updating Record
                if (!retrievedForUpdate)
                {

                    //Connection String
                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                    //Instantiate SQL Connection
                    SqlConnection objSqlConnection = new SqlConnection(cs);
                    //Get Value for BillNumber
                    string sqlCommand = "Select Count(PKBillID) FROM [dbo].[BillMst] where year(BillCreatedOn) = " + today.ToString("yyyy");
                    SqlCommand objsqlCommand = new SqlCommand(sqlCommand, objSqlConnection);

                    //Prepare for record addition

                    SqlCommand objSqlCmd = new SqlCommand("BillAddorEdit", objSqlConnection);
                    objSqlCmd.CommandType = CommandType.StoredProcedure;
                    SetCommandParameters(ref objSqlCmd);
                    try
                    {
                        objSqlConnection.Open();
                        if (txtPKBillID.Text == "0")
                        {
                            txtBillNumber.Text = today.ToString("yyyy") + "/" +
                                                 Convert.ToString((Convert.ToInt32(objsqlCommand.ExecuteScalar()) + 1)).PadLeft(5, '0');
                            objSqlCmd.Parameters.AddWithValue("@BillNumber", txtBillNumber.Text);
                            //objSqlCmd.Parameters.AddWithValue("@PKBillId",  0);
                            txtPKBillID.Text = Convert.ToString(objSqlCmd.ExecuteScalar());                            
                         }
                        
                        //Add Bill Detail Record 
                        if (Convert.ToInt32(comboAccountName.SelectedValue) >= 0 && txtPKBillID.Text != "0")
                        {
                            SqlCommand objSqlBillDtlCmd = new SqlCommand("BillDtlAddorEdit", objSqlConnection);
                            objSqlBillDtlCmd.CommandType = CommandType.StoredProcedure;

                            objSqlBillDtlCmd.Parameters.Clear();
                            objSqlBillDtlCmd.Parameters.AddWithValue("@PKBillDtlID", 0);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@FKBillID", txtPKBillID.Text);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@FKACID", Convert.ToInt32(comboAccountName.SelectedValue));
                            objSqlBillDtlCmd.Parameters.AddWithValue("@Amount", txtBillAmount.Text);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@BillDtlUpdatedOn", today);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@BillDtlUpdatedBy", "User");

                            objSqlBillDtlCmd.ExecuteScalar();

                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ClearBillDtl();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_BillMst"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else if (ex.Message.Contains("Unique_BillNumber"))
                        {
                            MessageBox.Show("Bill Number already exists.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.billMstViewTableAdapter.Fill(this.financeDataSet.BillMstView);
                }
            }

        }

        //Clear BillDtl Block
        private void ClearBillDtl()
        {
            comboAccountName.SelectedValue = 0;
            txtSL1Name.Text = "";
            txtSL2Name.Text = "";
            txtSL3Name.Text = "";
            txtBillAmount.Text = "";
            txtAccountBalance.Text = "";
        }

        //Update Record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //If Form Controls are validated proceed to add record
            if (validateRecord())
            {
                //Check if we are not Updating Record
                if (retrievedForUpdate)
                {
                    //Connection String
                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                    //Instantiate SQL Connection
                    SqlConnection objSqlConnection = new SqlConnection(cs);
                    //Prepare Update String

                    string updateCommand = "Update [dbo].[BillMst] set BillNarration = @BillNarration, FKDepID = @FKDepID, " +
                                           "FKEmpID = @FKEmpID, FKStuID = @FKStuID, FKSupID = @FKSupID, FKBillStatus = @FKBillStatus, " +
                                            "FKBillType = @FKBillType, BillUpdatedOn=@BillUpdatedOn where PKBillID = @PKBillID";
                    SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                    objUpdateCommand.Parameters.AddWithValue("@BillUpdatedOn", today);
                    objUpdateCommand.Parameters.AddWithValue("@PKBillID", txtPKBillID.Text);

                    SetCommandParameters(ref objUpdateCommand);

                    try
                    {
                        objSqlConnection.Open();
                        objUpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_BillMst"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.billMstViewTableAdapter.Fill(this.financeDataSet.BillMstView);
                }

            }

        }

        //Delete Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diagResult;
            diagResult = MessageBox.Show("Do you want to delete Record?", "Record Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diagResult == DialogResult.Yes)
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                //Prepare Delete String
                string deleteCommand = "Delete from Finance.dbo.BillMst where PKBillID= @PKBillID;";
                SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                objDeleteCommand.Parameters.AddWithValue("@PKBillID", txtPKBillID.Text);

                try
                {
                    objSqlConnection.Open();
                    objDeleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTemplate();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured: " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
                this.billMstViewTableAdapter.Fill(this.financeDataSet.BillMstView);
            }
        }

        private void SetCommandParameters(ref SqlCommand objSqlCommand)
        {
            objSqlCommand.Parameters.AddWithValue("@PKBillId", 0); // Convert.ToInt32(txtPKBillID.Text));
            objSqlCommand.Parameters.AddWithValue("@BillNarration", txtBillNarration.Text);
            objSqlCommand.Parameters.AddWithValue("@FKDepID", comboDept.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@FKBillType", comboBillType.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@FKBillStatus", comboBillStatus.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@BillUpdatedOn", today);
            objSqlCommand.Parameters.AddWithValue("@BillUpdatedBy", "User");


            //If Bill Type is of Employee (11); Assign Beneficiery Combo Value to Employee column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 11)
            {
                objSqlCommand.Parameters.AddWithValue("@FKEmpID", comboBeneficiery.SelectedValue);
                objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);

            }
            else //If Bill Type is of Medical (3); Assign Beneficiery Combo Value to ............column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 3)
            {
                objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);
            }
            else //If Bill Type is of Student (4); Assign Beneficiery Combo Value to Student column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 4)
            {
                objSqlCommand.Parameters.AddWithValue("@FKStuID", comboBeneficiery.SelectedValue);
                objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);

            }
            else //If Bill Type is of Employee (4); Assign Beneficiery Combo Value to Supplier column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 12)
            {
                objSqlCommand.Parameters.AddWithValue("@FKSupID", comboBeneficiery.SelectedValue);
                objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
            }

        }

        #endregion



        //Supporting Methods
        #region

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Prepare appropriate LOV, if BillType gets Changed
        private void comboBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareBeneficiaryCombo();
        }

        //Prepare Beneficiary Combo
        private void PrepareBeneficiaryCombo()
        {
            //Prepare Medical Combo
            if (Convert.ToInt32(comboBillType.SelectedValue) == 3)
            {
                //PrepareEmployeeCombo();
            }
            //Prepare Student Combo
            else if (Convert.ToInt32(comboBillType.SelectedValue) == 4)
            {
                PrepareStudentsCombo();
            }
            //Prepare Employee Combo
            else if (Convert.ToInt32(comboBillType.SelectedValue) == 11)
            {
                PrepareEmployeesCombo();
            }
            else if (Convert.ToInt32(comboBillType.SelectedValue) == 12)
            {
                PrepareSuppliersCombo();
            }
        }

        //Validate Controls
        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (Convert.ToString(comboDept.SelectedValue) == "0")
            {
                validationMessage = "Please Select Department\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBillType.SelectedValue) == "0")
            {
                validationMessage += "Please Select Bill Type.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBeneficiery.SelectedValue) == "0")
            {
                validationMessage += "Please Select Beneficiery.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBillStatus.SelectedValue) != "5")
            {
                validationMessage += "Bill Status can only be 'Send to Accounts' at this Stage.\n";
                validationResult = false;
            }
            if (txtBillNarration.Text.Length <= 0)
            {
                validationMessage += "Please provide some narration for Bill.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboAccountName.SelectedValue) == "0")
            {
                validationMessage += "Please select Account Name.\n";
                validationResult = false;
            }
            if (txtBillAmount.Text.Length <= 0)
            {
                validationMessage += "Please provide vakue for amount.\n";
                validationResult = false;
            }

            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Bill Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        //Clear Controls
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Clear Template Method
        private void ClearTemplate()
        {
            comboDept.SelectedValue = 0;
            comboBillType.SelectedValue = 0;
            comboBeneficiery.SelectedValue = 0;
            comboBillStatus.SelectedValue = 0;
            txtBillNarration.Text = "";
            retrievedForUpdate = false;
            queryMode = false;
            billMstViewBindingSource.Filter = "";
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVbillMstView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPKBillID.Text = comboACID.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtBillNumber.Text = comboACID.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtBillNarration.Text = comboACID.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                comboDept.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                comboBillType.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[10].FormattedValue.ToString());
                comboBeneficiery.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                comboBillStatus.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
                txtBillDate.Text = comboACID.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();// "dd/MM/yyyy");

                retrievedForUpdate = true;
                LockKeys();
            }
        }

        //Set Locks on Keys
        private void LockKeys()
        {
            ////comboFY.Enabled = false;
            //comboDept.Enabled = false;
            //comboSL1.Enabled = false;
            //comboSL2.Enabled = false;
            ////comboSL3.Enabled = false;
        }

        //Initialize Beneficiary LOV, if Department is Changed
        private void comboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareBeneficiaryCombo();
            PrepareAccountNameCombo();
        }

        private void PrepareAccountNameCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKACID, AccountName + ' (' +  SL3Code + ')' FROM [Finance].[dbo].[BudgetWithAccounts] WHERE PKDEPID = " + comboDept.SelectedValue + " Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboAccountName.DisplayMember = "ListItemDesc"; // will display Name property
                comboAccountName.ValueMember = "ListItemID"; // will select Value property
                comboAccountName.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Execute Form Query
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //If Query Record Mode == false Enter Query Mode
            if (queryMode == false)
            {
                //Disable Coomand Buttons
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                //Rename Query to Get Records
                btnQuery.Text = "Get Records";

                //Set Query Mode to True
                queryMode = true;

            }
            //Else Apply Filter on DGV and Show record
            else
            {
                StringBuilder SearchStatement = new StringBuilder();

                SearchStatement.Clear();
                if (Convert.ToInt32(comboDept.SelectedValue) > 0)
                {
                    SearchStatement.Append("FKDepID = " + Convert.ToInt32(comboDept.SelectedValue));
                }
                if (Convert.ToInt32(comboBillType.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("FKBillType = " + Convert.ToInt32(comboBillType.SelectedValue));
                }

                if (Convert.ToInt32(comboBeneficiery.SelectedValue) > 0)
                    {
                        if (SearchStatement.Length > 0)
                        {
                            SearchStatement.Append(" and ");
                        }
                        //If Bill Type is of Employee (11); Assign Beneficiery Combo Value to Employee column
                        if (Convert.ToInt32(comboBillType.SelectedValue) == 11)
                        {
                            SearchStatement.Append("FKEmpID = " + Convert.ToInt32(comboBeneficiery.SelectedValue));
                        }
                        else //If Bill Type is of Medical (3); Assign Beneficiery Combo Value to ............column
                        if (Convert.ToInt32(comboBillType.SelectedValue) == 3)
                        {
                        }
                        else //If Bill Type is of Student (4); Assign Beneficiery Combo Value to Student column
                        if (Convert.ToInt32(comboBillType.SelectedValue) == 4)
                        {
                            SearchStatement.Append("FKStuID = " + Convert.ToInt32(comboBeneficiery.SelectedValue));
                        }
                        else //If Bill Type is of Employee (4); Assign Beneficiery Combo Value to Supplier column
                        if (Convert.ToInt32(comboBillType.SelectedValue) == 12)
                        {
                            SearchStatement.Append("FKSupID = " + Convert.ToInt32(comboBeneficiery.SelectedValue));
                        }
                }
                if (Convert.ToInt32(comboBillStatus.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("FKBillStatus = " + Convert.ToInt32(comboBillStatus.SelectedValue));
                }
                if (Convert.ToInt32(txtBillNarration.Text.Length) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("[BillNarration] like '%" + txtBillNarration.Text + "%'");
                }
                try
                    {
                    if (SearchStatement.ToString().Length > 0)
                    {
                        billMstViewBindingSource.Filter = SearchStatement.ToString();
                    }
                    else
                        MessageBox.Show("Nothing to Query. Please select/set values for query in the form", "Query paramters not set", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Set QueryMode to False and Restore Button Caption to Query 
                    queryMode = false;
                    btnQuery.Text = "Query";
                    //Enable Coomand Buttons
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void comboAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Get Value for BillNumber
            string sqlCommand = "Select SL1Name, SL2Name, SL3Name FROM [dbo].[BudgetWithAccounts] where PKACID = @PKACID" ;
            SqlCommand objsqlCommand = new SqlCommand(sqlCommand, objSqlConnection);

            try
            {
                objSqlConnection.Open();
                objsqlCommand.Parameters.AddWithValue("@PKACID", comboAccountName.SelectedValue);
                SqlDataReader objDataReader = objsqlCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    txtSL1Name.Text = Convert.ToString(objDataReader[0]);
                    txtSL2Name.Text = Convert.ToString(objDataReader[1]);
                    txtSL3Name.Text = Convert.ToString(objDataReader[2]);
                }
            }
            catch (SqlException ex)
            {
                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
            //Refresh DGV 
            //this.billMstViewTableAdapter.Fill(this.financeDataSet.BillMstView);
        }
    }

}


        #endregion

        //private void DGVBillDtl_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (this.DGVBillDtl.CurrentCell.ColumnIndex == 1)
        //    {
        //        //Get AccountName Combo Object
        //        e.CellStyle.BackColor = Color.Aquamarine;
        //        MessageBox.Show("Here");

        //        accountNameCombo = e.Control as ComboBox;
        //        if (accountNameCombo != null)
        //        {
        //            //Avoid Attaching Multiple Event Handlers
        //            accountNameCombo.SelectedIndexChanged -= new EventHandler(accountNameCombo_SelectedIndexChanged);

        //            //Attach New Event Handler
        //            accountNameCombo.SelectedIndexChanged += accountNameCombo_SelectedIndexChanged;
        //        }
        //    }
        ////    else
        ////        accountNameCombo.SelectedIndexChanged -= new EventHandler(accountNameCombo_SelectedIndexChanged);
        //}

        //private void accountNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selected = (sender as ComboBox).SelectedIndex.ToString();
        //    MessageBox.Show("Here-2" + selected);

        //    //RadComboBoxElement combo = (RadComboBoxElement)sender;
        //    //int index = combo.SelectedIndex;
        //    if (selected == "-1")
        //    {
        //        (sender as ComboBox).BindingContext = new BindingContext();
        //    }

        //    DGVBillDtl.Rows[DGVBillDtl.CurrentCell.RowIndex].Cells[1].Value = selected;
        //    DGVBillDtl.Rows[DGVBillDtl.CurrentCell.RowIndex].Cells[2].Value = txtPKBillID.Text;

        //}

     



