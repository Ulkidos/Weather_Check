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
using System.Diagnostics;


namespace Weather_Check
{
    public partial class Form1 : Form
    {
        class Weather
        {
            public int[] temp = new int [100];
            public int[] volog = new int[100];
            public int[] tusk = new int[100];
            public string[] day = new string[100];
            public int num;


        }
        Weather weat = new Weather();
        public Form1()
        {
            InitializeComponent();
            //string connectionString = @"Data Source=.\DESKTOP-19TQEGK;Initial Catalog=Weather;Integrated Security=True";
            string connectionString = ConfigurationManager.ConnectionStrings["Weather_Check_DataBase"].ConnectionString;
            Console.WriteLine(connectionString);

            Console.Read();

            // Создание подключения
            /*SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
            }*/

            //Weather weat = new Weather();

            string sqlExpression = "SELECT * FROM Weather.dbo.Погода";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                    for (int i = 0; reader.Read(); i++) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object age = reader.GetValue(2);

                        weat.day[i] = reader.GetValue(0).ToString();
                        weat.temp[i] = Int32.Parse(reader.GetValue(1).ToString());
                        weat.volog[i] = Int32.Parse(reader.GetValue(2).ToString());
                        weat.tusk[i] = Int32.Parse(reader.GetValue(3).ToString());
                        weat.num = i + 1;

                        Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
                    }
                }
                reader.Close();
            }
            Debug.WriteLine("Start");
            for (int i = 0; weat.day[i] != null; i++)
            {
                
                Debug.WriteLine(weat.temp[i]);
                //Console.WriteLine(weat.temp[i]);
            }
            Debug.WriteLine("End");
            Debug.WriteLine(weat.num);

            float avg_temp = 0;
            for (int i = 0; weat.day[i] != null; i++)
            {
                avg_temp += weat.temp[i];
            }
            Debug.WriteLine(avg_temp);
            avg_temp /= weat.num;
            Debug.WriteLine(avg_temp);

            Debug.WriteLine("Start");
            int index_anomaly = 4;
            for (int i = 0; weat.day[i] != null; i++)
            {
                if (avg_temp + index_anomaly < weat.temp[i] || avg_temp - index_anomaly > weat.temp[i])
                    Debug.WriteLine(weat.temp[i]);
            }
            Debug.WriteLine("End");


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

        private void температураToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            float avg_temp = 0;
            for (int i = 0; weat.day[i] != null; i++)
            {
                avg_temp += weat.temp[i];
            }
            Debug.WriteLine(avg_temp);
            avg_temp /= weat.num;
            Debug.WriteLine(avg_temp);

            Debug.WriteLine("Start");
            //int index_anomaly = Int32.Parse(textBox_temp.ToString());
            int index_anomaly = 4;
            for (int i = 0; weat.day[i] != null; i++)
            {
                if (avg_temp + index_anomaly < weat.temp[i] || avg_temp - index_anomaly > weat.temp[i])
                    Debug.WriteLine(weat.temp[i]);
            }
            Debug.WriteLine("End");
            погодаTableAdapter.GetDataBy("08.11.2021 0:00:00");
        }
    }
}
