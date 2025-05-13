using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пятигорская_бронза_приложение
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = textBox1.Text;
            var PasswordUser = textBox2.Text;
            if (LoginUser == "admin" && PasswordUser == "admin")
            {
                Form Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.save_btn.Enabled = false;
            form1.delete_btn.Enabled = false;
            form1.Show();
            this.Hide();
        }
    }
}
