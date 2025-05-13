using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Пятигорская_бронза_приложение
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data source=DESKTOP-G7LMSC7;
        Initial Catalog=Пятигорская бронза; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            load_data();
        }
        public void load_data()
        {
            SqlDataAdapter sqlData1 = new SqlDataAdapter("SELECT*FROM [Менеджеры]", connection);
            SqlDataAdapter sqlData2 = new SqlDataAdapter("SELECT*FROM [Продукция]", connection);
            SqlDataAdapter sqlData3 = new SqlDataAdapter("SELECT*FROM [Заказы]", connection);
            SqlDataAdapter sqlData4 = new SqlDataAdapter("SELECT*FROM [Поставки]", connection);
            DataTable data1 = new DataTable(); DataTable data2 = new DataTable(); DataTable data3 = new DataTable(); DataTable data4 = new DataTable();
            DataTable data5 = new DataTable(); DataTable data6 = new DataTable(); DataTable data7 = new DataTable(); DataTable data8 = new DataTable();
            sqlData1.Fill(data1); sqlData2.Fill(data2); sqlData3.Fill(data3); sqlData4.Fill(data4);
            dataGridView1.DataSource = data1; dataGridView2.DataSource = data2; dataGridView3.DataSource = data3; dataGridView4.DataSource = data4;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                int Num = dataGridView1.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("INSERT INTO [Менеджеры](ФИО_сотрудника, Ставка_сотрудника, Номер_телефона, Почта_сотрудника) VALUES " +
                "('" +
                dataGridView1.Rows[Num].Cells[1].Value.ToString() + "' , '" +
                dataGridView1.Rows[Num].Cells[2].Value.ToString() + "' , '" +
                dataGridView1.Rows[Num].Cells[3].Value.ToString() + "' , '" +
                dataGridView1.Rows[Num].Cells[4].Value.ToString() + " ')", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                int Num = dataGridView2.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("INSERT INTO [Продукция](Номер_продукции, Наименование_продукции, Стоимость_продукции, Количество_продукции) VALUES " +
                "('" +
                dataGridView2.Rows[Num].Cells[0].Value.ToString() + " ',' " +
                dataGridView2.Rows[Num].Cells[1].Value.ToString() + "' , '" +
                dataGridView2.Rows[Num].Cells[2].Value.ToString() + "' , '" +
                dataGridView2.Rows[Num].Cells[3].Value.ToString() + " ')", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                int Num = dataGridView3.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("INSERT INTO [Заказы](Номер_заказа, ФИО_заказчика, Номер_телефона_заказчика, Номер_сотрудника, Дата_заказа, Описание_заказа, Количество_заказа, Общая_стоимость_заказа, Номер_продукции) VALUES " +
                "('" +
                dataGridView3.Rows[Num].Cells[0].Value.ToString() + " ',' " +
                dataGridView3.Rows[Num].Cells[1].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[2].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[3].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[4].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[5].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[6].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[7].Value.ToString() + "' , '" +
                dataGridView3.Rows[Num].Cells[8].Value.ToString() + " ')", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                int Num = dataGridView4.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("INSERT INTO [Поставки](Номер_поставки, Номер_сотрудника, Дата_поставки, Номер_продукции, Количество_поставки, Адрес_поставки, Общая_стоимость_поставки) VALUES " +
                "('" +
                dataGridView4.Rows[Num].Cells[0].Value.ToString() + " ',' " +
                dataGridView4.Rows[Num].Cells[1].Value.ToString() + "' , '" +
                dataGridView4.Rows[Num].Cells[2].Value.ToString() + "' , '" +
                dataGridView4.Rows[Num].Cells[3].Value.ToString() + "' , '" +
                dataGridView4.Rows[Num].Cells[4].Value.ToString() + "' , '" +
                dataGridView4.Rows[Num].Cells[5].Value.ToString() + "' , '" +
                dataGridView4.Rows[Num].Cells[6].Value.ToString() + " ')", connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("saved");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            load_data();
            MessageBox.Show("Updated");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                int Num = dataGridView1.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("DELETE FROM [Менеджеры] WHERE Номер_сотрудника='" + dataGridView1.Rows[Num].Cells[0].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                int Num = dataGridView2.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("DELETE FROM [Продукция] WHERE Номер_продукции='" + dataGridView2.Rows[Num].Cells[0].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                int Num = dataGridView3.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("DELETE FROM [Заказы] WHERE Номер_заказа='" + dataGridView3.Rows[Num].Cells[0].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                int Num = dataGridView4.CurrentCell.RowIndex;
                SqlCommand command = new SqlCommand("DELETE FROM [Поставки] WHERE Номер_поставки='" + dataGridView4.Rows[Num].Cells[0].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
            }
            load_data();
            MessageBox.Show("Deleted");
        }

        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}
