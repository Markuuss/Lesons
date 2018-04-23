using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Label_TextChanged(object sender, TextChangedEventArgs e)
        { 
        }

        private void Interfes_UpdateBLableEvent(object sender, MouseEventArgs e)
        {
            label.Text = "Курсор наведен на: ";
            if (sender is Label || sender is Button)
                label.Text += (sender is Label ? ((Label)sender).Content.ToString() : ((Button)sender).Content.ToString());
            else if (sender is TabItem)
                label.Text += (sender as TabItem).Header.ToString();
        }

        
        

        private void Spravka_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://metanit.com/sharp/wpf/1.php");
        }
    }
}
