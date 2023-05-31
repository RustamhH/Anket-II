using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace Anket_II
{
    public partial class Form1 : Form
    {
        public static void Write<T>(string filePath, T values)
        {
            try
            {
                JsonSerializerOptions op = new JsonSerializerOptions();
                op.WriteIndented = true;
                File.WriteAllText(filePath, JsonSerializer.Serialize(values, op));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public static T Read<T>(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(text);
            }
            catch (FileNotFoundException fnf) { MessageBox.Show("File Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(T);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (NameBox.Text == "" || SurnameBox.Text == "" || FatherNameBox.Text == "" || CountryBox.Text == "" || CityBox.Text == "" || PhoneBox.Text == "") MessageBox.Show("Fill All Datas","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                if (GenderChoice.HasChildren)
                {
                    foreach (var item in GenderChoice.Controls)
                    {
                        if (item is RadioButton rb)
                        {
                            if (rb.Checked == true) gender = rb.Text;
                        }
                    }
                }
                Write($"{NameBox.Text}.json", new User(NameBox.Text, SurnameBox.Text, FatherNameBox.Text,
                    CountryBox.Text, CityBox.Text, PhoneBox.Text, dateTimePicker1.Value, gender));
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            User user = Read<User>($"{JsonTextBox.Text}.json");
            if (user != null)
            {
                NameBox.Text = user.Name;
                SurnameBox.Text = user.Surname;
                FatherNameBox.Text = user.FatherName;
                CountryBox.Text = user.Country;
                CityBox.Text = user.City;
                PhoneBox.Text = user.Phone;
                dateTimePicker1.Value = user.Birthday;
                if (user.Gender == "Male") MaleRadioButton.Checked = true;
                else FemaleRadioButton.Checked = true;
            }

        }
    }
}