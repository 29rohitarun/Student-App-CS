using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using MySqlX.XDevAPI.Relational;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace StudentApp
{ 
    public partial class MainForm : Form
    {
        // Global Variables
        string connectionString = "Server=localhost; Database=project4db; User=root; Password=NCSU4PCOM@2022!";
        MySqlConnection connection = null;
        DataTable dt = new DataTable();
        
        public MainForm()
        {
            InitializeComponent();
        }

        // Open DB Method
        public void OpenDB()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show("There was an error in establishing the connection: " + exception.Message);
            }
        }


        //Close DB Method
        public void CloseDB()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Open DB, run sql statement, instantiate data table,
                // load information to grid data, close db.
                OpenDB();
                StreamReader studentDataReader = new StreamReader("studentdata.txt");
                string currentLine;
                while ((currentLine = studentDataReader.ReadLine()) != null)
                {
                    currentLine = currentLine.Trim();
                    string[] data = currentLine.Split(',');

                    int stuId = int.Parse(data[0].Trim());
                    string stuName = data[1].Trim();
                    int score = int.Parse(data[2].Trim());
                    string sqlStatement = "insert into student(studentid, studentname, score) values (" + stuId + ",'" + stuName + "'," + score + ")";
                    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                CloseDB();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            { 
                OpenDB();
                // Input validation for fields being empty
                if ((txtName.Text == "" || txtName.Text == null) || (txtID.Text == "" || txtID.Text == null) || (txtScore.Text == "" || txtScore.Text == null))
                {
                    MessageBox.Show("Fill out all fields");
                    return;
                }
                string studentName = txtName.Text;
                int studentID, studentScore;
                int.TryParse(txtID.Text, out studentID);
                int.TryParse(txtScore.Text, out studentScore);

                string sqlStatement = "insert into student (studentid, studentname, score) values (" + studentID + ", '" + studentName + "', " + studentScore + ")";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added data to the table");
                CloseDB();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error adding data to the table" + exception.Message);
                
            }       
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDB();
                string sqlStatement = "select * from student";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);
                grdData.DataSource = dt;
                CloseDB();
            }
            catch (Exception exception)
            {
                MessageBox.Show("error displaying data" + exception.Message);
            }
        }

        private void tbControl_Click(object sender, EventArgs e)
        {
            try {
                OpenDB();
                string sqlStatement = "select * from student";
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                dt.Load(reader);
                grdData.DataSource = dt;
                CloseDB();
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["studentid"]);
                    string name = row["studentname"].ToString();
                    int score = Convert.ToInt32(row["score"]);
                    string grade;


                    // Conditional statements that assign grade to letter grade
                    if (score > 90)
                    {
                        grade = "A";
                    }
                    else if (score <= 89 && score >= 80)
                    {
                        grade = "B";
                    }
                    else if (score <= 79 && score >= 70)
                    {
                        grade = "C";
                    }
                    else if (score <= 69 && score >= 60)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }
                    lstGrade.Items.Add(string.Format("{0,20}{1,20}{2,20}", id, name, grade));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error in clicking tab" + exception.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try {
                StreamWriter writer = new StreamWriter("studentgrades.txt");
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["studentid"]);
                    string name = row["studentname"].ToString();
                    int score = Convert.ToInt32(row["score"]);
                    string grade;

                    // Conditional statements to assign grade to letter grade
                    if (score > 90)
                    {
                        grade = "A";
                    }
                    else if (score <= 89 && score >= 80)
                    {
                        grade = "B";
                    }
                    else if (score <= 79 && score >= 70)
                    {
                        grade = "C";
                    }
                    else if (score <= 69 && score >= 60)
                    {
                        grade = "D";
                    }
                    else
                    {
                        grade = "F";
                    }
                    
                    writer.WriteLine(id + "   " + name + "   " + grade + "    ");
                }
                writer.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error in exporting the data" + exception.Message);
            }
        }
    }
}
