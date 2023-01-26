using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListBox();
        }
        public bool isValid()
        {
            /*if (IdTB.Text != "" && firstNameTB.Text != "" && lastNameTB.Text != "" && dateOfBirthTB.Text != "") return true;
            return false;*/
            return IdTB.Text != "" && firstNameTB.Text != "" && lastNameTB.Text != "" && dateOfBirthTB.Text != "";
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=MyDB;Integrated Security=True");
        public void LoadListBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Id,generalInformation from People", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "generalInformation";
            listBox1.ValueMember = "Id";
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO People VALUES (@Id,@firstName, @lastName, @dateOfBirth, @generalInformation)", conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(IdTB.Text));
                    cmd.Parameters.AddWithValue("@firstName", Helper.FirstLetterToUpperCase(firstNameTB.Text));
                    cmd.Parameters.AddWithValue("@lastName", Helper.FirstLetterToUpperCase(lastNameTB.Text));
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirthTB.Text);
                    cmd.Parameters.AddWithValue("@generalInformation", $"[{IdTB.Text}] {Helper.FirstLetterToUpperCase(firstNameTB.Text)} {Helper.FirstLetterToUpperCase(lastNameTB.Text)} {dateOfBirthTB.Text}");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                MessageBox.Show("You must fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE People SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, generalInformation = @generalInformation Where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(IdTB.Text));
                    cmd.Parameters.AddWithValue("@firstName", firstNameTB.Text);
                    cmd.Parameters.AddWithValue("@lastName", lastNameTB.Text);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirthTB.Text);
                    cmd.Parameters.AddWithValue("@generalInformation", $"[{IdTB.Text}] {firstNameTB.Text} {lastNameTB.Text} {dateOfBirthTB.Text}");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadListBox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                MessageBox.Show("You must fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                /*cmd.CommandText = "DELETE FROM People";*/
                cmd.CommandText = "DELETE FROM People WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", int.Parse(IdTB.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void clearDataBtn_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            dateOfBirthTB.Text = "";
            IdTB.Text = "";
        }

    }
}