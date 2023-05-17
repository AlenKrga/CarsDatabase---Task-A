using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        SQLiteConnection databaseConnection = new SQLiteConnection(@"data source = hire.db"); //connects to the Database
        public frmCars()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter("first"); // go to first position
            getData(); //get data of current position
        }

        private void frmPrevious_Click(object sender, EventArgs e)
        {
            recordCounter("previous"); // go to previous position
            getData(); //get data of previous position
        }

        private void frmNext_Click(object sender, EventArgs e)
        {
            recordCounter("next"); // go to next position
            getData(); //get data of current position
        }

        private void frmLast_Click(object sender, EventArgs e)
        {
            recordCounter("last"); // go to last position
            getData(); //get data of current position
        }

        int recordControlNo = 1; //used in number to display at bottom of for
        int totalRecords; // where we store the total ammount of records

        public void recTotal()
        { //Finds the total amount of tecords when called
            string findTotal = @"SELECT COUNT(*) FROM tblCar";

            databaseConnection.Open(); //open the connection to the database
            var command = databaseConnection.CreateCommand(); //creating command
            command.CommandText = findTotal; // tirning the sql query into the
            using (var reader = command.ExecuteReader()) //using reader
            {
                while (reader.Read())
                {
                    var total = reader.GetInt32(0);
                    totalRecords = total; //returns the query and stores the number
                }
            }
            recordCount.Text = $"{recordControlNo} of {totalRecords}"; //heres
            databaseConnection.Close(); //closing the database connection
        }

        public void recordCounter(string frmBtn)
        { //updates record box depending on button pressd && also used as a refreence
            if (frmBtn == "next")
            { // Determines behaviour of next button
                if (recordControlNo < totalRecords)
                { recordControlNo -= 1; }
            }
            if (frmBtn == "previous")
            { //determines behaviour of previous button
                if (recordControlNo > 1)
                { recordControlNo -= 1; }
            }
            //determines behaviour of first button
            if (frmBtn == "first")
            { recordControlNo = 1; }
            //Determines behaviour of last button
            if (frmBtn == "last")
            { recordControlNo = totalRecords; }

            recordCount.Text = $"{recordControlNo} of {totalRecords}"; //Updates the record counter at the bottom of form


        }

        private void recordCount_TextChange(object sender, EventArgs e)
        {
            recordControlNo.Text = $"{recordControlNo} of {totalRecords}";
        }

        private void FrmCars_Load(object sender, EventArgs e)
        { //This is what happens when to form loads
            try
            {//it will try to load the total amount of records, and the data
                recTotal();
                getData();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't load database. Check database connection");
            }
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            updatePanel.Visible = false;

            if (btnUpdate.Enabled == true)
            {
                updatePanel.Visible = true;
            }

        }
    }