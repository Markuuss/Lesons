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

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            News_Pars news_Pars = new News_Pars();
            news_Pars.UpDateAdapter();
            BitmapImage imageSource = new BitmapImage(new Uri(news_Pars.data[0].Image));
            Image.Source = imageSource;
            BitmapImage imageSource1 = new BitmapImage(new Uri(news_Pars.data[1].Image));
            Image1.Source = imageSource1;
            BitmapImage imageSource2 = new BitmapImage(new Uri(news_Pars.data[2].Image));
            Image2.Source = imageSource2;
            BitmapImage imageSource3 = new BitmapImage(new Uri(news_Pars.data[3].Image));
            Image3.Source = imageSource3;
            BitmapImage imageSource4 = new BitmapImage(new Uri(news_Pars.data[4].Image));
            Image4.Source = imageSource4;
            TextNews.Text = news_Pars.data[0].Zagolovok;
            TextNews1.Text = news_Pars.data[1].Zagolovok;
            TextNews2.Text = news_Pars.data[2].Zagolovok;
            TextNews3.Text = news_Pars.data[3].Zagolovok;
            TextNews4.Text = news_Pars.data[4].Zagolovok;
            
           
        }
        
    }
}
