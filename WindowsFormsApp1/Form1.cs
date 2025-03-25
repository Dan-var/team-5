using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            namefield.ForeColor = Color.Gray;
            surnamefield.Text = "Введіть прізвище";
            surnamefield.ForeColor = Color.Gray;
            loginfield.ForeColor = Color.Gray;
            loginfield.Text = "Введіть логін";
            passwordfield.ForeColor = Color.Gray;
            passwordfield.Text = "Введіть пароль";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (namefield.Text == "Введіть ім'я")
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }
            if (surnamefield.Text == "Введіть прізвище")
            {
                MessageBox.Show("Введіть прізвище");
                return;
            }
            if (loginfield.Text == "Введіть логін")
            {
                MessageBox.Show("Введіть логін");
                return;
            }
            if (passwordfield.Text == "Введіть пароль")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }

            if (isUserExists())
                return;

            Db db = new Db();
            MySqlCommand command = new MySqlCommand("INSERT INTO users (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginfield.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordfield.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namefield.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnamefield.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успішно створений");
            }
            else {
                MessageBox.Show("Помилка");
            }

            db.closeConnection();
        }
        public Boolean isUserExists()
        {
            Db db = new Db();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul ", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginfield.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                MessageBox.Show("Такий логін вже існує");
                return true;
            }
            else
                return false;

        }

        private void namefield_Enter(object sender, EventArgs e)
        {
            if (namefield.Text == "Введіть ім'я")
                namefield.Text = "";

        }
        private void namefield_Leave(object sender, EventArgs e)
        {
            if (namefield.Text == "")
            {
                namefield.Text = "Введіть ім'я";
                namefield.ForeColor = Color.Gray;
            }
        }

        private void surnamefield_Enter(object sender, EventArgs e)
        {
            if (surnamefield.Text == "Введіть прізвище")
                surnamefield.Text = "";
        }

        private void surnamefield_Leave(object sender, EventArgs e)
        {
            if (surnamefield.Text == "")
            {
                surnamefield.Text = "Введіть прізвище";
                surnamefield.ForeColor = Color.Gray;
            }
        }

        private void loginfield_Enter(object sender, EventArgs e)
        {
            if (loginfield.Text == "Введіть логін")
                loginfield.Text = "";
        }

        private void loginfield_Leave(object sender, EventArgs e)
        {
            if (loginfield.Text == "")
            {
                loginfield.Text = "Введіть логін";
                loginfield.ForeColor = Color.Gray;
            }
        }

        private void passwordfield_Enter(object sender, EventArgs e)
        {
            if (passwordfield.Text == "Введіть пароль")
                passwordfield.Text = "";
        }

        private void passwordfield_Leave(object sender, EventArgs e)
        {
            if(passwordfield.Text == "")
            {
                passwordfield.Text = "Введіть пароль";
                passwordfield.ForeColor = Color.Gray;
            }
        }
    }
}
