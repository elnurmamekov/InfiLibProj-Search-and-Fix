using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiLibProj
{
    public partial class MenuForm : Form
    {
        private Form currentChildForm;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LibrariansForm LibForm = new LibrariansForm();

            LibForm.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoginForm LogForm = new LoginForm();

            LogForm.Show();
            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentsForm());
        }


        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BooksForm());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IssueBook());
        }

        Point lastPoint;

        private void MenuForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReturnBook());
        }

        private void MenuForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelChildForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelChildForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
