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

namespace videoRentalSystem
{
   
    public partial class Form1 : Form
    {
        //SqlConnection String
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|videoRental.mdf;Integrated Security=True");
        SqlCommand cmd;
        
        
       
        public Form1()
        {
            InitializeComponent();
           
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet3.movies' table. 
            this.moviesTableAdapter2.Fill(this.videoRentalDataSet3.movies);
            // TODO: This line of code loads data into the 'videoRentalDataSet3.customer' table. 
            this.customerTableAdapter2.Fill(this.videoRentalDataSet3.customer);
            
            // TODO: This line of code loads data into the 'videoRentalDataSet11.rentals' table. 
            this.rentalsTableAdapter.Fill(this.videoRentalDataSet11.rentals);
         
            // TODO: This line of code loads data into the 'videoRentalDataSet11.customer' table. 
            this.customerTableAdapter1.Fill(this.videoRentalDataSet11.customer);
            // TODO: This line of code loads data into the 'videoRentalDataSet.customer' table. 
            this.customerTableAdapter.Fill(this.videoRentalDataSet.customer);

        }
       
       
        //Adding Customer by click on add button in customer tab
        private void addCustomer_Click(object sender, EventArgs e)
        {
            //validation
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "")
            {
                //query for inserting data into customer table
                cmd = new SqlCommand("insert into customer(FirstName,LastName,Address,Phone) values(@first,@last,@add,@ph)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@first", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@last", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@add", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@ph",phoneTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //for displaying gridview after every transaction
        private void DisplayData()
        {
            // TODO: This line of code loads data into the 'videoRentalDataSet3.movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter2.Fill(this.videoRentalDataSet3.movies);
            // TODO: This line of code loads data into the 'videoRentalDataSet3.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.videoRentalDataSet3.customer);
            
            
            // TODO: This line of code loads data into the 'videoRentalDataSet11.rentals' table. You can move, or remove it, as needed.
            this.rentalsTableAdapter.Fill(this.videoRentalDataSet11.rentals);
           
            // TODO: This line of code loads data into the 'videoRentalDataSet11.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.videoRentalDataSet11.customer);
            // TODO: This line of code loads data into the 'videoRentalDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.videoRentalDataSet.customer);
        }

       
        //Clear Data  for customers tab after any transaction
        private void ClearData()
        {
            firstNameTextBox.Text="";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            phoneTextBox.Text = "";
            CusID.Text = "";
             
        }
        //Clear Data  for movies tab after any transaction
        private void ClearDataForMovies()
        {
            titleTextBox.Text = "";
            ratingTextBox.Text = "";
            genreTextBox.Text = "";
            yearDateTimePicker.Value = DateTime.Today;
            mid.Text = "";

        }
        //Clear Data  for rentals tab after any transaction
        private void ClearDataForRentals()
        {
            midrent.Text = "";
            cidrent.Text = "";
            dateReturnedDateTimePicker.Value = DateTime.Today;
            dateRentedDateTimePicker.Value = DateTime.Today;
            rmid.Text = "";
        }
        //for updating customer table
        private void cus_update_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "")
            {
                //customer table updation query
                cmd = new SqlCommand("update customer set FirstName=@first,LastName=@last,Address=@add,Phone=@phone where CusID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", CusID.Text);
                cmd.Parameters.AddWithValue("@first", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@last", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@add", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //for deleting customer
        private void cus_delete_Click(object sender, EventArgs e)
        {
            //if any row selected
            if (CusID.Text!="")
            {
                //delete the delected row query
                cmd = new SqlCommand("delete customer where CusID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", CusID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        //Adding Movie by click on add button in movie tab
        private void Add_movie_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && ratingTextBox.Text != "")
            {
                //current datetime
                DateTime now = DateTime.Today;
                //date picked
                DateTime picked = yearDateTimePicker.Value;
                //year difference for calculating rental cost
                int diffyear = now.Year-picked.Year;
                float cost = 5.0f;//cost intialisation
                if (diffyear > 5)//if release date is older than 5 years
                {
                    cost = 2.0f;
                }
                //inserting records into movies table
                cmd = new SqlCommand("insert into movies(Title,Rating,Year,RentalCost,Genre) values(@title,@rating,@year,@cost,@genre)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
                cmd.Parameters.AddWithValue("@rating",ratingTextBox.Text);
                cmd.Parameters.AddWithValue("@year", yearDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@cost",cost);
                cmd.Parameters.AddWithValue("@genre", genreTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearDataForMovies();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

       
        //update movie
        private void update_movie_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && ratingTextBox.Text != "")
            {
                //current datetime
                DateTime now = DateTime.Today;
                //date picked
                DateTime picked = yearDateTimePicker.Value;
                //year difference for calculating rental cost
                int diffyear = now.Year - picked.Year;
                float cost = 5.0f;//cost intialisation
                if (diffyear > 5)//if release date is older than 5 years
                {
                    cost = 2.0f;
                }
                //for updating movie query
                cmd = new SqlCommand("update movies set Title=@title,Rating=@rating,Year=@year,RentalCost=@cost,Genre=@genre where mid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", mid.Text);
                cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
                cmd.Parameters.AddWithValue("@rating", ratingTextBox.Text);
                cmd.Parameters.AddWithValue("@year", yearDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@genre", genreTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearDataForMovies();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //for delete the movie 
        private void delete_movie_Click(object sender, EventArgs e)
        {
            //if no row selected
            if (mid.Text != "")
            {
                //delete selected movie
                cmd = new SqlCommand("delete movies where mid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", mid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearDataForMovies();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

       //issue movie according customer Id and Movie Id
        private void issue_Click(object sender, EventArgs e)
        {
            if (midrent.Text != "" && cidrent.Text != "" )
            {
               //Add records in rentals
                cmd = new SqlCommand("insert into rentals(MID,CusID,DateRented,DateReturned) values(@mid,@cid,@rent,@return)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@mid", midrent.Text);
                cmd.Parameters.AddWithValue("@cid", cidrent.Text);
                cmd.Parameters.AddWithValue("@rent", dateRentedDateTimePicker.Value);
                cmd.Parameters.AddWithValue("@return", dateReturnedDateTimePicker.Value);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearDataForRentals();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //delete records in rentals
        private void m_return_Click(object sender, EventArgs e)
        {
            //if no row selected 
            if (rmid.Text != "")
            {
                //delete records in rentals
                cmd = new SqlCommand("delete rentals where rmid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", rmid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearDataForRentals();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
