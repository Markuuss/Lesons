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
    /// Логика взаимодействия для Cinema.xaml
    /// </summary>
    public partial class Cinema : Page
    {
        int non;
        int zanet = 0;
        int full = 41;
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
        public Cinema()
        {
            InitializeComponent();
            Mest.Content = 41;
           
            Non.Content = zanet;
           
           
            free.Content = full;
            Button();
            

        }
        public void Button()
        {
        Rad1_Namber1.Click += (s, e) =>
          { 
              zanet++;
              Non.Content = zanet;
              full--;
              free.Content = full;
              string Mesto = "1";
              string Read = "1";

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

              SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

              SqlParameter parameter = new SqlParameter();
              parameter.ParameterName = "@Mesto";
              parameter.Value = Mesto;
              parameter.SqlDbType = SqlDbType.VarChar;
              sqlData.Parameters.Add(parameter);
              parameter = new SqlParameter();
              parameter.ParameterName = "@Rad";
              parameter.Value = Read;
              parameter.SqlDbType = SqlDbType.VarChar;
              sqlData.Parameters.Add(parameter);
              try
              {
                  sqlData.ExecuteNonQuery();
              }
              catch
              {
                  MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                  return;
              }
          };
                  Rad1_Namber2.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "2";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber3.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "3";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber4.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "4";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber5.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "5";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber6.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "6";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber7.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "7";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber8.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "8";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber9.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "9";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber10.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "10";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber11.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "11";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber12.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "12";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber13.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "13";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber14.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "14";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber15.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "15";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad1_Namber16.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "16";
                string Read = "1";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            //Реад 2
            Rad2_Namber1.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "1";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber2.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "2";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber3.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "3";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber4.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "4";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber5.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "5";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber6.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "6";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber7.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "7";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber8.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "8";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber9.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "9";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber10.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "10";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber11.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "11";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber12.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "12";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber13.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "13";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber14.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "14";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad2_Namber15.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "15";
                string Read = "2";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            //Реад 3
            Rad3_Namber1.Click += (s, e) =>
              {
                  zanet++;
                  Non.Content = zanet;
                  full--;
                  free.Content = full;
                  string Mesto = "1";
                  string Read = "3";

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

                  SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                  SqlParameter parameter = new SqlParameter();
                  parameter.ParameterName = "@Mesto";
                  parameter.Value = Mesto;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  parameter = new SqlParameter();
                  parameter.ParameterName = "@Rad";
                  parameter.Value = Read;
                  parameter.SqlDbType = SqlDbType.VarChar;
                  sqlData.Parameters.Add(parameter);
                  try
                  {
                      sqlData.ExecuteNonQuery();
                  }
                  catch
                  {
                      MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                      return;
                  }
              };
            Rad3_Namber2.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "2";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber3.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "3";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber4.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "4";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber5.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "5";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber6.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "6";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber7.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "7";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber8.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "8";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber9.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "9";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
            Rad3_Namber10.Click += (s, e) =>
            {
                zanet++;
                Non.Content = zanet;
                full--;
                free.Content = full;
                string Mesto = "10";
                string Read = "3";

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

                SqlCommand sqlData = new SqlCommand("Insert Into [Statistic]" + "(Mesto,Rad) Values(@Mesto,@Rad)", connect);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Mesto";
                parameter.Value = Mesto;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Rad";
                parameter.Value = Read;
                parameter.SqlDbType = SqlDbType.VarChar;
                sqlData.Parameters.Add(parameter);
                try
                {
                    sqlData.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка, при выполнении запроса на добавление записи");
                    return;
                }
            };
        }
    }
}
