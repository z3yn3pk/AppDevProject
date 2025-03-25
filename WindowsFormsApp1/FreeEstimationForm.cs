using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using System.Xml;
using System.Globalization;
using System.Reflection.Emit;
using System.Resources;

namespace WindowsFormsApp1
{
    public partial class FreeEstimationForm : Form
    {
        private ResourceManager rm;
        private CultureInfo ci;

        public FreeEstimationForm()
        {
            InitializeComponent();
            rm = new ResourceManager("WindowsFormsApp1.Strings", typeof(FreeEstimationForm).Assembly);
            ci = CultureInfo.CurrentCulture;
            ApplyResources();
        }

        private void ApplyResources()
        {
            Title.Text = rm.GetString("Title", ci);
            Title2.Text = rm.GetString("SelectServices", ci);
            Title3.Text = rm.GetString("ApproximatePrice", ci);
            nameLabel.Text = rm.GetString("NameLabel", ci); // Assuming nameLabel is the label for nameBox
            emailLabel.Text = rm.GetString("EmailLabel", ci); // Assuming emailLabel is the label for emailBox
            numberLabel.Text = rm.GetString("PhoneLabel", ci); // Assuming numberLabel is the label for numberBox
            addressLabel.Text = rm.GetString("AddressLabel", ci); // Assuming addressLabel is the label for addressBox
            companyLabel.Text = rm.GetString("CompanyLabel", ci); // Assuming companyLabel is the label for companyNameBox
            questionLabel.Text = rm.GetString("WhereLabel", ci); // Assuming questionLabel is the label for questionBox
            notesLabel.Text = rm.GetString("NotesLabel", ci); // Assuming notesLabel is the label for notesBox
            sendMessageButton.Text = rm.GetString("SendMessageButton", ci);

            servicesList.Items[0] = rm.GetString("GeneralPressureWashing", ci);
            servicesList.Items[1] = rm.GetString("GraffitiRemoval", ci);
            servicesList.Items[2] = rm.GetString("TruckFleetCleaning", ci);
            servicesList.Items[3] = rm.GetString("GutterCleaningInstallation", ci);
            servicesList.Items[4] = rm.GetString("StainRemoval", ci);
            servicesList.Items[5] = rm.GetString("PaintStripping", ci);

        }

        private void enButton_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("en-US");
            ApplyResources();
        }

        private void frButton_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("fr-FR");
            ApplyResources();
        }

        private void FreeEstimationForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void servicesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void companyNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            // Getting the connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["PostgreSQLConnection"].ConnectionString;

            // 2. Get the selected services
            List<string> selectedServices = new List<string>();
            foreach (var item in servicesList.CheckedItems)
            {
                selectedServices.Add(item.ToString());
            }
            string services = string.Join(", ", selectedServices);

            // 3. Get the contact information
            string name = nameBox.Text;
            string email = emailBox.Text;
            string phoneNumber = numberBox.Text;
            string address = addressBox.Text;
            string companyName = companyNameBox.Text;
            string heardAbout = questionBox.Text;
            string notes = notesBox.Text;

            // Basic validation (you might want to add more robust validation)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your name and email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Insert data into the database
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO ServiceRequests (Name, Email, PhoneNumber, Address, CompanyName, HeardAbout, Notes, Services) " +
                                 "VALUES (@Name, @Email, @PhoneNumber, @Address, @CompanyName, @HeardAbout, @Notes, @Services)";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrEmpty(phoneNumber) ? (object)DBNull.Value : phoneNumber);
                        command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
                        command.Parameters.AddWithValue("@CompanyName", string.IsNullOrEmpty(companyName) ? (object)DBNull.Value : companyName);
                        command.Parameters.AddWithValue("@HeardAbout", string.IsNullOrEmpty(heardAbout) ? (object)DBNull.Value : heardAbout);
                        command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                        command.Parameters.AddWithValue("@Services", services);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your service request has been sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Optionally clear the form after successful submission
                            nameBox.Clear();
                            emailBox.Clear();
                            numberBox.Clear();
                            addressBox.Clear();
                            companyNameBox.Clear();
                            questionBox.Clear();
                            notesBox.Clear();
                            for (int i = 0; i < servicesList.Items.Count; i++)
                            {
                                servicesList.SetItemChecked(i, false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to send your service request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
