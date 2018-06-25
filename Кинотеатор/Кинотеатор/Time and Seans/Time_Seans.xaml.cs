using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Time_Seans.xaml
    /// </summary>
    public partial class Time_Seans : Page
    {
        private Cinema cinema = new Cinema(); 
        public string id_user;
        public string id_users;
        Authi authi = new Authi();
        public List<Time_Seans> list = new List<Time_Seans>();
        private SqlConnection connect = null;
        private DataTable dataTable = new DataTable();
        public void OpenConnection()
        {
            connect = new SqlConnection(connSrt);
            connect.Open();
        }
        public void CloseConnection()
        {
            connect.Close();
        }


        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True");
        string connSrt = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True";

        Afisha afisha;
        public Time_Seans()
        {
            InitializeComponent();
            Time();
        }
        public Time_Seans(string name)
        {
            InitializeComponent();
            Time(name);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            afisha = new Afisha();
            NavigationService.Navigate(afisha);
        }
        public void Usser_Name()
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
                id_user = dataTable.Rows[i].ItemArray[1].ToString();
            }
            sqlConnection.Close();
            adapter.Dispose();
            //list.Add(new Time_Seans { id_users=id_user});
        }
        public void Time(string name = null)
        {
            time1210.Click += (s, e) =>
              {
                  Usser_Name();
                  string time1210 = "12:10";

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

                      SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);
                  
                  SqlParameter parameter = new SqlParameter();
                  parameter.ParameterName = "@User_name";
                  parameter.Value = id_user;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Time_seans";
                      parameter.Value = time1210;
                      parameter.SqlDbType = SqlDbType.VarChar;
                      sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Name_Cinema";
                  parameter.Value = name;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  try
                  {
                      sqlData.ExecuteNonQuery();
                      NavigationService.Navigate(cinema);
                  }
                  catch
                 {
                          MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                          return;
                 }
                  
              try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
                  
              };
            time1410.Click += (s, e) =>
            {
                string time1410 = "14:10";
                Usser_Name();
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

                SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@User_name";
                parameter.Value = id_user;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Time_seans";
                parameter.Value = time1410;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Name_Cinema";
                parameter.Value = name;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                    NavigationService.Navigate(cinema);
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            };
            time1635.Click += (s, e) =>
              {
                  Usser_Name();
                  string time1635 = "16:35";
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

                  SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                  SqlParameter parameter = new SqlParameter();
                  parameter.ParameterName = "@User_name";
                  parameter.Value = id_user;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Time_seans";
                  parameter.Value = time1635;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Name_Cinema";
                  parameter.Value = name;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  try
                  {
                      sqlData.ExecuteNonQuery();
                      NavigationService.Navigate(cinema);
                  }
                  catch
                  {
                      MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                      return;
                  }

                  try
                  {
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message.ToString(), "Error");
                  }
              };
            time1835.Click += (s, e) =>
              {
                  Usser_Name();
                  string time1835 = "18:35";
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

                  SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                  SqlParameter parameter = new SqlParameter();
                  parameter.ParameterName = "@User_name";
                  parameter.Value = id_user;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Time_seans";
                  parameter.Value = time1835;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Name_Cinema";
                  parameter.Value = name;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  try
                  {
                      sqlData.ExecuteNonQuery();
                      NavigationService.Navigate(cinema);
                  }
                  catch
                  {
                      MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                      return;
                  }

                  try
                  {
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message.ToString(), "Error");
                  }
              };
            time1940.Click += (s, e) =>
            {
                Usser_Name();
                string time1940 = "19:40";
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

                SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@User_name";
                parameter.Value = id_user;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Time_seans";
                parameter.Value = time1940;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Name_Cinema";
                parameter.Value = name;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                    NavigationService.Navigate(cinema);
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }

                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            };
            //Ночной режим
            time2141.Click += (s, e) =>
            {
                Usser_Name();
                string time2141 = "21:41";
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

                SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@User_name";
                parameter.Value = id_user;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Time_seans";
                parameter.Value = time2141;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Name_Cinema";
                parameter.Value = name;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                    NavigationService.Navigate(cinema);
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }

                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            };
            time0010.Click += (s, e) =>
            {
                Usser_Name();
                string time0010 = "00:10";
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

                SqlCommand sqlData = new SqlCommand("Insert Into [Table1]" + "(time_seans,User_name,Name_Cinema) Values(@Time_seans,@User_name,@Name_Cinema)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@User_name";
                parameter.Value = id_user;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Time_seans";
                parameter.Value = time0010;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Name_Cinema";
                parameter.Value = name;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                    NavigationService.Navigate(cinema);
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }

                try
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
            };
        }
       
    }
}
