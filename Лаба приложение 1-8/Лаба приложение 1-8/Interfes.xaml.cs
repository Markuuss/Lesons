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

namespace Лаба_приложение_1_8
{
    /// <summary>
    /// Логика взаимодействия для Interfes.xaml
    /// </summary>
    public partial class Interfes : UserControl
    {
        public event EventHandler<MouseEventArgs> UpdateBLableEvent;
        private Dialog dialog;
        public Interfes()
        {
            InitializeComponent();
        }
        private void User_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
        }
            private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            UpdateBLableEvent(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs es)
        {
            dialog =new Dialog();
            dialog.EventSelectedAction += (s, e) =>
            {
                selectedAction.Content = "Выбрано: " + (s as Button).Content.ToString();
            };
            dialog.Show();
        }
    }
}
