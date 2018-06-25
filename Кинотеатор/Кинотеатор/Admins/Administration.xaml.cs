using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для Administration.xaml
    /// </summary>
    public partial class Administration : Page
    {
        string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
        private SqlConnection connect = null;
        string login;
        public Administration()
        {
            InitializeComponent();
            SingUP();
        }
        public void Login_stat(string name)
        {
            login = name;
        }

        public void OpenConnection()
        {
            connect = new SqlConnection(connSrt);
            connect.Open();
        }
        public void CloseConnection()
        {
            connect.Close();
        }
        public void SingUP()
        {
            Sing.Click += (s, e) =>
            {
                
                    string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
                    try
                    {
                        connect = new SqlConnection(connSrt);
                        connect.Open();
                    }
                    catch (SqlException se)
                    {
                        MessageBox.Show("Ошибка подключения:{0}", se.Message);
                        return;
                    }
                    SqlCommand sqlData = new SqlCommand("Select * from [Admin] WHERE Login=@login and Password=@password", connect);
                     if(Login_Admin.Text.Length == 0||Password_Admin.Text.Length==0)
                    {
                        MessageBox.Show("Вы не ввели логин или пароль");
                    }
                    sqlData.Parameters.AddWithValue("@login", Login_Admin.Text);
                    sqlData.Parameters.AddWithValue("@password", Password_Admin.Text);
                    SqlDataReader sql = sqlData.ExecuteReader();
                    if (sql.HasRows == true)
                    {
                        Statistic statistic = new Statistic(login);
                        statistic.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не Конект");
                    }
                    connect.Close();

               

            };
        }
    }
}
