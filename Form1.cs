using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace CRUD_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListBox();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=MyDB;Integrated Security=True");
        public bool IsFilledInAllFields()
        {
            return IdTB.Text != "" && firstNameTB.Text != "" && lastNameTB.Text != "" && dateOfBirthTB.Text != "";
        }
        public bool IsValidDateOfBirth()
        {
            try
            {
                DateTime.ParseExact(dateOfBirthTB.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool isIdAlreadyExists()
        {
            if (int.TryParse(IdTB.Text, out int Id))
            {
                SqlCommand cmd = new SqlCommand("select * from People where Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
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
            if (IsFilledInAllFields() && !isIdAlreadyExists() && IsValidDateOfBirth())
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
                    LoadListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("You must fill in all fields with correct date format (YYYY/MM/DD) and unique ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IsFilledInAllFields() && isIdAlreadyExists() && IsValidDateOfBirth())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE People SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, generalInformation = @generalInformation Where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", int.Parse(IdTB.Text));
                    cmd.Parameters.AddWithValue("@firstName", Helper.FirstLetterToUpperCase(firstNameTB.Text));
                    cmd.Parameters.AddWithValue("@lastName", Helper.FirstLetterToUpperCase(lastNameTB.Text));
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirthTB.Text);
                    cmd.Parameters.AddWithValue("@generalInformation", $"[{IdTB.Text}] {Helper.FirstLetterToUpperCase(firstNameTB.Text)} {Helper.FirstLetterToUpperCase(lastNameTB.Text)} {dateOfBirthTB.Text}");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadListBox();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("You must fill in all fields with correct date format (YYYY/MM/DD) and unique ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)
            {
                try
                {
                    var selectedItem = listBox1.SelectedItem;
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM People WHERE Id = @Id";
                    if (int.TryParse(IdTB.Text, out int Id))
                    {
                        Id = int.Parse(IdTB.Text);
                        if (!isIdAlreadyExists())
                        {
                            MessageBox.Show("User with this ID does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else if (!int.TryParse(IdTB.Text, out Id))
                    {
                        Id = (int)((DataRowView)selectedItem)["Id"];
                    }
                    cmd.Parameters.AddWithValue("@Id", Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("No records to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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