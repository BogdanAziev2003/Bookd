using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryApp
{

    public partial class appForm : Form
    {
        Book[] books;
        Font lbFont;
        Font bFont;
        private  User user;
        public string userName;
        DB db = new DB();


        public appForm()
        {
            InitializeComponent();
            Init();
        }

        private void LoadFont()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("font.ttf");

            lbFont = new Font(custom_font.Families[0], 10);
            bFont = new Font(custom_font.Families[0], 11);

            nameTextBox.Font = lbFont;
            surNameTextBox.Font = lbFont;
            loginTextBox.Font = lbFont;
            reservRadio.Font = lbFont;
            tookRadio.Font = lbFont;

            topLabel.Font = bFont;
            nameLabel.Font = bFont;
            surnameLabel.Font = bFont;
            loginLabel.Font = bFont;
            reservBtn.Font = bFont;

            topLabel.ForeColor = Color.White;
            nameLabel.ForeColor = Color.White;
            surnameLabel.ForeColor = Color.White;
            loginLabel.ForeColor = Color.White;

            reservRadio.ForeColor = Color.White;
            tookRadio.ForeColor = Color.White;
            reservBtn.ForeColor = Color.FromArgb(243, 165, 5);


        }

        public void GetBooks() 
        {
            DataTable table = new DataTable();
            int amount;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `books` WHERE `reserved` = 0", db.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                amount = table.Rows.Count;
                Book[] books = new Book[amount];

                for (int i = 0; i < amount; i++)
                {
                    string[] str = {
                            Convert.ToString(table.Rows[i].ItemArray[0]),
                            Convert.ToString(table.Rows[i].ItemArray[1]),
                            Convert.ToString(table.Rows[i].ItemArray[2]),
                            Convert.ToString(table.Rows[i].ItemArray[3]),
                            Convert.ToString(table.Rows[i].ItemArray[4]),
                    };

                    books[i] = new Book(
                            Convert.ToInt32(table.Rows[i].ItemArray[0]),
                            Convert.ToString(table.Rows[i].ItemArray[1]),
                            Convert.ToString(table.Rows[i].ItemArray[2]),
                            Convert.ToInt32(table.Rows[i].ItemArray[3]),
                            Convert.ToString(table.Rows[i].ItemArray[4]),
                            Convert.ToBoolean(table.Rows[i].ItemArray[5]
                            ));
                    DG.Rows.Add(str);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FullData()
        {
            nameTextBox.Text = user.Name;
            surNameTextBox.Text = user.Surname;
            loginTextBox.Text = user.UserName;
            reservRadio.Checked = user.Reserv;
            tookRadio.Checked = user.Took;
        }
        public void Init()
        {
            DG.Rows.Clear();
            panel2.BackColor = Color.FromArgb(243, 165, 5);
            panel1.BackColor = Color.FromArgb(243, 165, 5);
            reservBtn.BackColor = Color.White;
            userName = GetUserName();
            SetUser(userName);
            FullData();
            LoadFont();
            GetBooks();
        }

        static public string GetUserName()
        {
            if (regForm.login == null)
            {
                return loginForm.login;
            }
            return regForm.login;
        }


        public void SetUser(string UserName) 
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = UserName;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            user = new User(
                (string)table.Rows[0].ItemArray[3],
                (string)table.Rows[0].ItemArray[4],
                (string)table.Rows[0].ItemArray[1],
                Convert.ToBoolean(table.Rows[0].ItemArray[5]),
                Convert.ToBoolean(table.Rows[0].ItemArray[6])
            );
        }

        private void reservBtn_Click(object sender, EventArgs e)
        {
            Form form = new reservForm();
            this.Hide();
            form.ShowDialog();
            Init();
            this.Show();

        }
    }
}
