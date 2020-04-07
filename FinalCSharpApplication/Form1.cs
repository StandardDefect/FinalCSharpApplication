using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Hooks in SQL functions such as writers, readers, etc.

namespace FinalCSharpApplication
{
    public partial class Form1 : Form
    {
        //Establishes Global SQL rules and information
        string connectionString = "Data Source=essql1.walton.uark.edu;" + "Initial Catalog=ISYS4283S2024;" + "User ID=ISYS4283S2024;password=HC23dcv$"; //SQL Server information and credentials
        string SQL = null; //Query string variable
        SqlConnection connection; //Lines 19-21 create aliases for SQL classes.
        SqlCommand command;
        SqlDataReader dataReader;
 
        public Form1()
        {
            try
            {
                InitializeComponent(); //Launches Form.
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Error Window
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Student Dropdown
                connection = new SqlConnection(connectionString); //Establishes connection settings
                SQL = "SELECT Student_ID FROM Student"; //SQL query string
                connection.Open(); //Connects to database
                command = new SqlCommand(SQL, connection); //Generates an SQL Query in the specified database
                dataReader = command.ExecuteReader(); //Executes query
                while (dataReader.Read())
                {
                    cboxStudent.Items.Add(dataReader[0].ToString()); //Populates dropdown
                }
                dataReader.Close(); //Ends querying
                command.Dispose(); //Deletes query
                connection.Close(); //Exits database
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        private void cboxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxStudent.SelectedIndex > -1) //Prevents the code inside the if statement from running when the combo box is cleared, since doing so creates a NullReferenceException error
            {
                try
                {
                    lboxCourse.Items.Clear(); //Clears the course list of any preexisting courses.
                    
                    //Course List

                    connection = new SqlConnection(connectionString);
                    SQL = "SELECT Course_ID FROM Course";
                    connection.Open();
                    command = new SqlCommand(SQL, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        lboxCourse.Items.Add(dataReader[0].ToString()); //Populates list box
                    }
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();

                    //Data Grid View
                    var sql2 = "SELECT * FROM Registration WHERE Student_ID =  '" + cboxStudent.SelectedItem.ToString() + "'"; //Second SQL query 
                    var dataadapter = new SqlDataAdapter(sql2, connection);
                    var ds = new DataSet(); //establishes ds as a DataSet
                    dataadapter.Fill(ds); //Fills ds using SQL
                    dgvRegistration.DataSource = ds.Tables[0]; //Sets the contents of dgvRegistration equal to the first and only table stored in ds

                    //Display Student Information
                    connection = new SqlConnection(connectionString);
                    SQL = "SELECT Last_Name, First_Name, DOB, Sex, Major FROM Student WHERE Student_ID = '" + cboxStudent.SelectedItem.ToString() + "'";
                    connection.Open();
                    command = new SqlCommand(SQL, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        textLastName.Text = dataReader[0].ToString(); //Lines 98-102 populate student info text boxes.
                        textFirstName.Text = dataReader[1].ToString();
                        textDateofBirth.Text = dataReader[2].ToString();
                        textSex.Text = dataReader[3].ToString();
                        textMajor.Text = dataReader[4].ToString();
                    }
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { } //Nothing happens if the combo box is empty.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit(); //Exits Application
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lboxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Course Information
                connection = new SqlConnection(connectionString);
                SQL = "SELECT Course_Name, Credit_Hours, College, Offered_Online FROM Course WHERE Course_ID = '" + lboxCourse.SelectedItem.ToString() + "'";
                connection.Open();
                command = new SqlCommand(SQL, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textCourseName.Text = dataReader[0].ToString(); //Lines 140-143 populate course info text boxes.
                    textCreditHours.Text = dataReader[1].ToString();
                    textCollege.Text = dataReader[2].ToString();
                    textOnline.Text = dataReader[3].ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Registration Info

                textSection.Text = dgvRegistration.CurrentRow.Cells[5].Value.ToString(); //Sets the text in the text box equal to the relevant attribute value of the selected row.
                textStartDate.Text = dgvRegistration.CurrentRow.Cells[3].Value.ToString();
                textEndDate.Text = dgvRegistration.CurrentRow.Cells[4].Value.ToString();
                textClassSize.Text = dgvRegistration.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Inserts new rows into the Registration table in the SQL Server

                int answer; //establishes a new variable that returns the resultant number of rows affected by the query.

                SQL = "INSERT INTO Registration VALUES (@Course_ID,@Student_ID,@Start_Date,@End_Date,@Section,@Class_Size)";
                connection.Open();
                command = new SqlCommand(SQL, connection);

                command.Parameters.AddWithValue("@Student_ID", cboxStudent.SelectedItem.ToString()); //Lines 184-189 establish that the scalar value specified in Line 180 and the first parameter in parethesis are equal to the value of the second parameter.
                command.Parameters.AddWithValue("@Course_ID", lboxCourse.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Start_Date", textStartDate.Text);
                command.Parameters.AddWithValue("@End_Date", textEndDate.Text);
                command.Parameters.AddWithValue("@Section", textSection.Text);
                command.Parameters.AddWithValue("@Class_Size", textClassSize.Text);

                answer = command.ExecuteNonQuery(); //Returns result of the query to C# to keep the application from breaking.

                command.Dispose();
                connection.Close();

                MessageBox.Show(answer + " rows have been entered into the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); //Success Message
                FormClear(); //Refresh Code
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Updates the registration *currently selected* in the table.

                int answer;
                string reg = dgvRegistration.CurrentRow.Cells[0].Value.ToString(); //Establishes string variable reg that is equal to the Registration_ID of the selected row in the data grid.

                SQL = "UPDATE Registration SET Start_Date = @Start_Date, End_Date = @End_Date, Section = @Section, Class_Size = @Class_Size WHERE Registration_ID = @Reg";
                connection.Open();
                command = new SqlCommand(SQL, connection);

                command.Parameters.AddWithValue("@Reg", reg); //Makes reg the operative part of the WHERE clause of the SQL statement.
                command.Parameters.AddWithValue("@Start_Date", textStartDate.Text);
                command.Parameters.AddWithValue("@End_Date", textEndDate.Text);
                command.Parameters.AddWithValue("@Section", textSection.Text);
                command.Parameters.AddWithValue("@Class_Size", textClassSize.Text);

                answer = command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                MessageBox.Show(answer + " rows have been updated in the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); //Success Message
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Deletes the registration *currently selected* in the table.

                int answer;
                string reg = dgvRegistration.CurrentRow.Cells[0].Value.ToString();

                SQL = "DELETE FROM Registration WHERE Registration_ID = @Reg";
                connection.Open();
                command = new SqlCommand(SQL, connection);

                command.Parameters.AddWithValue("@Reg", reg);

                answer = command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();

                MessageBox.Show(answer + " rows have been deleted from the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); //Success Message
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormClear(); //Refresh Code
        }
        private void FormClear()
        {
            try
            {
                //Refreshes information in the application.
                cboxStudent.SelectedIndex = -1;
                lboxCourse.Items.Clear();
                dgvRegistration.DataSource = null;
                textFirstName.Text = "";
                textLastName.Text = "";
                textSex.Text = "";
                textMajor.Text = "";
                textDateofBirth.Text = "";
                textCourseName.Text = "";
                textCreditHours.Text = "";
                textCollege.Text = "";
                textOnline.Text = "";
                textSection.Text = "";
                textStartDate.Text = "";
                textEndDate.Text = "";
                textTime.Text = "";
                textClassSize.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred:" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

