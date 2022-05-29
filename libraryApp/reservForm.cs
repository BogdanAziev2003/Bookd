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
    public partial class reservForm : Form
    {
        DB db = new DB();
        public string userName;
        Font btFont;
        Font lbFont;


        public reservForm()
        {
            InitializeComponent();
            userName = appForm.GetUserName();
            FormSets();
        }

        private void FormSets()
        {
            PrivateFontCollection custom_font = new PrivateFontCollection();
            custom_font.AddFontFile("font.ttf");
            this.BackColor = Color.White;

            btFont = new Font(custom_font.Families[0], 9);
            lbFont = new Font(custom_font.Families[0], 10);

            button.Font = btFont;
            button.ForeColor = Color.White;
            label.Font = lbFont;


            button.BackColor = Color.FromArgb(243, 165, 5);
        }

        private void button_Click(object sender, EventArgs e)
        {
            int id;
            try
            { 
                id = int.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("Error");
                return;
            }
            if (isReserv(userName)) 
            {
                MessageBox.Show("Вы уже зарезервировали книгу");
            }
            else 
            {
                ReservBook(id);
                this.Close();
            }
        }

        private bool isReserv(int id)
        {
            try
            {
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @uL", db.getConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return Convert.ToBoolean(table.Rows[0].ItemArray[5]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool isReserv(string login)
        {
            try
            {
                DataTable table = new DataTable();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return Convert.ToBoolean(table.Rows[0].ItemArray[5]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ReservBook(int id)
        {
            try
            {

                MySqlCommand command = new MySqlCommand("UPDATE `books` SET `reserved` = b'1' WHERE `id` = @ul;", db.getConnection());
                command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;


                MySqlCommand secCom = new MySqlCommand("UPDATE `users` SET `reserv` = b'1' WHERE `login` = @up;", db.getConnection());
                secCom.Parameters.Add("@up", MySqlDbType.VarChar).Value = userName;
                MySqlDataAdapter secAdapter = new MySqlDataAdapter();
                secAdapter.SelectCommand = secCom;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1 && secCom.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Все прошло успешно");
                }
                else
                {
                    MessageBox.Show("Error");

                }

                db.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
