using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для Statistic.xaml
    /// </summary>
    public partial class Statistic : Window
    {
        StreamReader streamReader;
        DataTable dataTable = new DataTable();
        public string user_name;
        public string time;
        public string cinema;
        string name_user;
        string rad;
        string mesto;
        string login_name;
        private SqlConnection connect = null;
        string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
        public void OpenConnection()
        {
            connect = new SqlConnection(connSrt);
            connect.Open();
        }
        public void CloseConnection()
        {
            connect.Close();
        }
        public Statistic()
        {
            InitializeComponent();
           
        }
        public Statistic(string login)
        {
            InitializeComponent();
            login_name =login;
            Data();
        }
        public void Data()
        {
            
            string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
            string command = "Select* from[Table]";
            SqlConnection sqlConnection = new SqlConnection(connSrt);
            SqlCommand sql = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (login_name==dataTable.Rows[i].ItemArray[1].ToString())
                {
                    name_user = dataTable.Rows[i].ItemArray[1].ToString();
                    string name = name_user;
                    Login.Content = name;
                }
                

            }
            string command1= "Select* from[Table1]";
            sqlConnection = new SqlConnection(connSrt);
            sql = new SqlCommand(command1,sqlConnection);
            sqlConnection.Open();
            adapter = new SqlDataAdapter(sql);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                time = dataTable.Rows[i].ItemArray[2].ToString();
                Time.Content = time;
            }
            string command2 = "Select* from[Table1]";
            sqlConnection = new SqlConnection(connSrt);
            sql = new SqlCommand(command2, sqlConnection);
            sqlConnection.Open();
            adapter = new SqlDataAdapter(sql);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cinema = dataTable.Rows[i].ItemArray[5].ToString();
                streamReader = new StreamReader(GenerateStreamFromString(cinema), System.Text.Encoding.UTF8);
                cinema = streamReader.ReadLine();
                Cinema.Content = cinema;
            }
            sqlConnection.Close();
            adapter.Dispose();
            Red_and_mesto();
        }
     
        public void Red_and_mesto()
        {
            string command = "Select* from[Statistic]";
            SqlConnection sqlConnection = new SqlConnection(connSrt);
            SqlCommand sql = new SqlCommand(command, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                rad = dataTable.Rows[i].ItemArray[3].ToString();
                Mesto.Content = rad;
            }
            string command2 = "Select* from[Statistic]";
            sqlConnection = new SqlConnection(connSrt);
            sql = new SqlCommand(command2, sqlConnection);
            sqlConnection.Open();
            adapter = new SqlDataAdapter(sql);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                mesto = dataTable.Rows[i].ItemArray[4].ToString();
                Read.Content = mesto;
            }
            sqlConnection.Close();
            adapter.Dispose();
        }
        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
