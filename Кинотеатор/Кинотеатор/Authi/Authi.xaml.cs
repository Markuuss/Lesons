using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для Authi.xaml
    /// </summary>
    public partial class Authi : Page
    {
        public List<Authi> id_c = new List<Authi>();
        public string login;
        private DataTable dataTable = new DataTable();
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True");
        string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
        //Afisha afisha = new Afisha();
        DataTable dt = new DataTable();
        private SqlConnection connect = null;
        private MainPage mainPage = new MainPage();
        public delegate void Login_Statistic(string login_statistic);
        public event Login_Statistic Login;
        public void OpenConnection()
        {
            connect = new SqlConnection(connSrt);
            connect.Open();
        }
        public void CloseConnection()
        {
            connect.Close();
        }
        public Authi()
        {
            InitializeComponent();
            
            InsertUser();
        }
        
        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            
            try
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
                SqlCommand sqlData = new SqlCommand("Select * from [Table] WHERE Login=@login and Password=@password", connect);
                sqlData.Parameters.AddWithValue("@login", Login_User.Text);
                login = Login_User.Text;
                Login(login);
                sqlData.Parameters.AddWithValue("@password", Password_User.Text);
                SqlDataReader sql = sqlData.ExecuteReader();
                
                if (Login_User.Text.Length <= 3 || Password_User.Text.Length <= 5)
                {
                    MessageBox.Show("Малая длина пароля или логина");
                }
                else if (Login_User.Text.Length == 0 || Password_User.Text.Length == 0)
                {
                    MessageBox.Show("Вы не ввели логин или пароль");
                }
                if (sql.HasRows==true)
                {
                    MessageBox.Show("Вход");
                    NavigationService.Navigate(mainPage);
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет");
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            

        }
        public void InsertUser()
        {
            Registr.Click += (e, s) =>
              {
                  try
                  {
                  string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";
                      try {
                          connect = new SqlConnection(connSrt);
                          connect.Open();
                      }

                      catch(SqlException se)
                      {
                          MessageBox.Show("Ошибка подключения:{0}", se.Message);
                          return;
                      }
                      if (Login_User.Text.Length <= 3 || Password_User.Text.Length <= 5)
                      {
                          MessageBox.Show("Малая длина пароля или логина");
                      }
                      else if (Login_User.Text.Length == 0 || Password_User.Text.Length == 0)
                      {
                          MessageBox.Show("Вы не ввели логин или пароль");
                      }
                      SqlCommand sqlData = new SqlCommand("Insert Into [Table]" + "(Login,Password) Values(@login,@password)",connect);
                      SqlParameter parameter = new SqlParameter();
                      parameter.ParameterName = "@login";
                      parameter.Value = Login_User.Text;
                      parameter.SqlDbType = SqlDbType.VarChar;
                      sqlData.Parameters.Add(parameter);
                      parameter = new SqlParameter();
                      parameter.ParameterName = "@password";
                      parameter.Value = Password_User.Text;
                      parameter.SqlDbType = SqlDbType.VarChar;
                      sqlData.Parameters.Add(parameter);
                      try
                      {
                          sqlData.ExecuteNonQuery();
                          MessageBox.Show("Вы успешно зарегистрированны!");
                      }
                      catch
                      {
                         MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                          return;
                      }
                      connect.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message.ToString(), "Error");
                  }

              };
            
        }
    }
}
