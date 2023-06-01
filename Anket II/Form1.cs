using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace Anket_II
{
    public partial class Form1 : Form
    {
        private List<User> UsersClass { get; set; } = new();
        
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

        private void AddUser(User user)
        {
            if (SearchUserById(IdBox.Text) == null)
            {
                Users.Items.Add(NameBox.Text);
                UsersClass.Add(user);
            }
            else MessageBox.Show("This User is Already Signed , Try [SaveChanges] button.", "Invalid Sign", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private User SearchUserByName(string name)
        {
            if (name == null) return null;
            foreach (var item in UsersClass)
            {
                if (item.Name == name) return item;
            }
            return null;
        }
        private User SearchUserById(string id)
        {
            if (id == null) return null;
            foreach (var item in UsersClass)
            {
                if (item.Id.ToString() == id) return item;
            }
            return null;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Write("Users.json", UsersClass);
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            List<User> users = Read<List<User>>($"Users.json");
            if (users != null)
            {
                UsersClass = users;
                foreach (var item in UsersClass)
                {
                    Users.Items.Add(item.Name);
                }
                LoadButton.Enabled = false;
            }

        }
        private void AddButton_Click(object sender,EventArgs e)
        {
            if (NameBox.Text == "" || SurnameBox.Text == "" || PhoneBox.Text == "" || EmailBox.Text=="") MessageBox.Show("Fill All Datas");
            else
            {
                try
                {
                    User user = new(NameBox.Text, SurnameBox.Text, PhoneBox.Text, dateTimePicker1.Value, EmailBox.Text);
                    AddUser(user);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
        }
        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Users.SelectedItem!=null)
            {
                User user = SearchUserByName(Users.SelectedItem.ToString());
                if (user != null)
                {
                    IdBox.Text = user.Id.ToString();
                    NameBox.Text = user.Name;
                    SurnameBox.Text = user.Surname;
                    EmailBox.Text = user.Email;
                    PhoneBox.Text = user.Phone;
                    dateTimePicker1.Value = user.Birthday;
                }
            }
            
        }
        private void SaveChangesButton_Click(object sender,EventArgs e)
        {
            string a = "";
            User user = SearchUserById(IdBox.Text);
            if (user!=null)
            {
                string temp = user.Name;
                user.Name=NameBox.Text;
                user.Surname=SurnameBox.Text;
                user.Email=EmailBox.Text;
                user.Phone = PhoneBox.Text;
                user.Birthday = dateTimePicker1.Value;
                Users.Items.Clear();
                foreach (var item in UsersClass)
                {
                    Users.Items.Add(item.Name);
                }
            }
        }
        
    }
}