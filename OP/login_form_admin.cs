using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP
{
    public partial class login_form_admin : Form
    {
        public login_form_admin()
        {
            InitializeComponent();
        }


        Point lastpoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void exit_user_Click(object sender, EventArgs e)
        {
            login_form newForm = new login_form();
            newForm.Show();
            this.Hide(); // Приховуємо поточну форму
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter_1(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave_1(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

       
    }
}
