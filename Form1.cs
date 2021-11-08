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
using System.Globalization;


namespace Weather_Check
{
    public partial class Form1 : Form
    {
        class Weather
        {
            public int[] temp = new int [100];
            public int[] volog = new int[100];
            public int[] tusk = new int[100];
            public float[] osu = new float[100];
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
                    Console.WriteLine("{0} \t\t\t\t{1} \t{2} \t\t{3} \t\t{4} ", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));

                    for (int i = 0; reader.Read(); i++) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object age = reader.GetValue(2);
                        object osu = reader.GetValue(3);
                        object tusk = reader.GetValue(4);

                        var ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                        ci.NumberFormat.NumberDecimalSeparator = ",";

                        weat.day[i] = reader.GetValue(0).ToString();
                        weat.temp[i] = Int32.Parse(reader.GetValue(1).ToString());
                        weat.volog[i] = Int32.Parse(reader.GetValue(2).ToString());
                        weat.osu[i] = float.Parse(reader.GetValue(3).ToString(), ci);
                        weat.tusk[i] = Int32.Parse(reader.GetValue(4).ToString());
                        weat.num = i + 1;

                        Console.WriteLine("{0} \t\t{1} \t\t\t{2} \t\t\t\t{3}   \t\t\t{4} ", id, name, age, osu, tusk);
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
            //dataGridView_General.Dock = DockStyle.Fill;
           /* if (dataGridView_General.Visible == false)
                dataGridView_General.Visible = true;
            else dataGridView_General.Visible = false;*/
            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_all();
        }

        private void температураToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            float avg = 0;
            for (int i = 0; weat.day[i] != null; i++)
            {
                avg += weat.temp[i];
            }
            Debug.WriteLine(avg);
            avg /= weat.num;
            Debug.WriteLine(avg);
            
            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_temp((int)avg + Int32.Parse(textBox_temp.Text), (int)avg - Int32.Parse(textBox_temp.Text));
                       
        }

        private void вологістьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float avg = 0;
            for (int i = 0; weat.day[i] != null; i++)
            {
                avg += weat.volog[i];
            }
            avg /= weat.num;

            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_volog((int)avg + Int32.Parse(textBox_volog.Text), (int)avg - Int32.Parse(textBox_volog.Text));
        }

        private void тискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float avg = 0;
            for (int i = 0; weat.day[i] != null; i++)
            {
                avg += weat.tusk[i];
            }
            Debug.WriteLine(avg);
            avg /= weat.num;
            Debug.WriteLine(avg);

            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_tusk((int)avg + Int32.Parse(textBox_tusk.Text), (int)avg - Int32.Parse(textBox_tusk.Text));

        }

        private void осіданняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float avg = 0;
            int num = 1;
            for (int i = 0; weat.day[i] != null; i++)
            {
                if(weat.osu[i] > 0.2)
                {
                    avg += weat.osu[i];
                    Debug.WriteLine("osu_ = " + weat.osu[i] + " \t osu_sum = " + avg);
                    num++;
                }
            }
            Debug.WriteLine("osu_sum = " + avg);
            avg /= num;
            Debug.WriteLine("osu_avg = " + avg);

            Debug.WriteLine("osu_limit = " + float.Parse(textBox_osu.Text, CultureInfo.InvariantCulture.NumberFormat));

            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_osu((int)avg + float.Parse(textBox_osu.Text, CultureInfo.InvariantCulture.NumberFormat), (int)avg - float.Parse(textBox_osu.Text, CultureInfo.InvariantCulture.NumberFormat));

        }

        private void дощToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_rain();

        }

        private void туманToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_fog();
        }
        
        private void osu_nothing(object sender, EventArgs e)
        {
            checkBox_osu_fog.Checked = false;
            checkBox_osu_frost.Checked = false;
            checkBox_osu_rain.Checked = false;
            checkBox_osu_snow.Checked = false;
        }
        private void osu_something(object sender, EventArgs e)
        {
            checkBox_osu_nothing.Checked = false;
        }
        /*private void volog_norm(object sender, EventArgs e)
        {
            checkBox_volog_dry.Checked = false;
            checkBox_volog_wet.Checked = false;
        }
        private void volog_dry(object sender, EventArgs e)
        {
            checkBox_volog_norm.Checked = false;
            checkBox_volog_wet.Checked = false;
        }
        private void volog_wet(object sender, EventArgs e)
        {
            checkBox_volog_norm.Checked = false;
            checkBox_volog_dry.Checked = false;
        }
        private void tusk_norm(object sender, EventArgs e)
        {
            checkBox_tusk_high.Checked = false;
            checkBox_tusk_low.Checked = false;
        }
        private void tusk_high(object sender, EventArgs e)
        {
            checkBox_tusk_norm.Checked = false;
            checkBox_tusk_low.Checked = false;
        }
        private void tusk_low(object sender, EventArgs e)
        {
            checkBox_tusk_high.Checked = false;
            checkBox_tusk_norm.Checked = false;
        }
        private void temp_norm(object sender, EventArgs e)
        {
            checkBox_temp_hot.Checked = false;
            checkBox_temp_cold.Checked = false;
        }
        private void temp_hot(object sender, EventArgs e)
        {
            checkBox_temp_norm.Checked = false;
            checkBox_temp_cold.Checked = false;
        }
        private void temp_cold(object sender, EventArgs e)
        {
            checkBox_temp_hot.Checked = false;
            checkBox_temp_norm.Checked = false;
        }*/

        private void таблицяЗаКритеріямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int temp_max, temp_min, volog_max, volog_min, tusk_max, tusk_min;
            float osu_max, osu_min;
            string count1, count2, count3, count4, count5;
            temp_max = 28;
            temp_min = 5;
            volog_max = 75;
            volog_min = 60;
            osu_max = 10;
            osu_min = 0;
            tusk_max =755;
            tusk_min = 75;
            count1 = "1";
            count2 = "1";
            count3 = "1";
            count4 = "1";
            count5 = "1";

            /*Параметри температури*/
            if (checkBox_temp_hot.Checked == true)
                temp_max = 100;
            else temp_max = 28;

            if (checkBox_temp_hot.Checked == true)
                temp_min = -100;
            else temp_min = 5;

            /*Праметри тиску*/
            if (checkBox_tusk_high.Checked == true)
                tusk_max = 1000;
            else tusk_max = 754;

            if (checkBox_tusk_low.Checked == true)
                tusk_min = 750;
            else tusk_min = 0;

            /*Праметри вологості*/
            if (checkBox_volog_wet.Checked == true)
                volog_max = 100;
            else volog_max = 75;

            if (checkBox_volog_dry.Checked == true)
                volog_min = 0;
            else volog_min = 50;

            /*Праметри опадів*/
            if (checkBox_osu_rain.Checked == true && checkBox_osu_nothing.Checked == true)
            {
                osu_max = 100;
                osu_min = 0;
            }
            else if(checkBox_osu_rain.Checked == false && checkBox_osu_nothing.Checked == true)
            {
                osu_max = 0;
                osu_min = 0;
            }
            else
            {
                osu_max = -5;
                osu_min = -5;
            }

            if (checkBox_osu_fog.Checked == true)
                count5 = "1";
           else count5 = "0";

            /*Праметри сезону*/
            if (checkBox_sezon_spring.Checked == true)
                count1 = "1";
            else count1 = "0";

            if (checkBox_sezon_summer.Checked == true)
                count2 = "1";
            else count2 = "0";

            if (checkBox_sezon_autumn.Checked == true)
                count3 = "1";
            else count3 = "0";

            if (checkBox_sezon_winter.Checked == true)
                count4 = "1";
            else count4 = "0";

            Debug.WriteLine("\n\ntemp_max = " + temp_max + "\ttemp_min = " + temp_min 
                + "\ntusk_max = " + tusk_max + "\ttusk_min = " + tusk_min 
                + "\nvolog_max = " + volog_max + "\tvolog_min = " + volog_min
                + "\nosu_max = " + osu_max + "\tosu_min = " + osu_min
                + "\ncount: " + count1 + " " +  count2 + " " + count3 + " " + count4);
            /*Виклик запиту*/
            dataGridView_General.DataSource = погодаTableAdapter.GetDataBy_criteria(temp_max, temp_min, volog_max, volog_min, osu_max, osu_min, count5, tusk_max, tusk_min, count4, count3, count2, count1);
        }
    }
}
