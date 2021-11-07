using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Weather_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string connectionString = @"Data Source=.\DESKTOP-19TQEGK;Initial Catalog=Weather;Integrated Security=True";
            string connectionString = ConfigurationManager.ConnectionStrings["Weather_Check_DataBase"].ConnectionString;
            Console.WriteLine(connectionString);

            Console.Read();

            // Создание подключения
            //SqlConnection connection = new SqlConnection(connectionString); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "weatherDataSet.Погода". При необходимости она может быть перемещена или удалена.
            this.погодаTableAdapter.Fill(this.weatherDataSet.Погода);

        }

        private void основнаТаблицяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_General.Visible == false)
                dataGridView_General.Visible = true;
            else dataGridView_General.Visible = false;
        }
    }
}
