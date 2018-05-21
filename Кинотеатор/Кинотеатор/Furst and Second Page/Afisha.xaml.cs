using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для Afisha.xaml
    /// </summary>
    public partial class Afisha : Page
    {
        public Afisha()
        {
            InitializeComponent();
            //FileStream fileStream = File.OpenRead("Opisanie1.txt");
            //StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1251));
            //Opisanie1.Text = streamReader.ReadToEnd();

            //FileStream fileStream1 = File.OpenRead("Opisanie2.txt");
            //StreamReader streamReader1 = new StreamReader(fileStream1, Encoding.GetEncoding(1251));
            //Opisanie2.Text = streamReader1.ReadToEnd();

            //FileStream file = File.OpenRead("Opisanie3.txt");
            //StreamReader stream = new StreamReader(file, Encoding.GetEncoding(1251));
            //Opisanie3.Text = stream.ReadToEnd();

            //FileStream file1 = File.OpenRead("Opisanie4.txt");
            //StreamReader stream1 = new StreamReader(file1, Encoding.GetEncoding(1251));
            //Opisanie4.Text = stream1.ReadToEnd();

            //streamReader.Close();
            //streamReader1.Close();
            Cinema_Pars cinema_Pars = new Cinema_Pars();
            cinema_Pars.CinemaParsing();

            BitmapImage imageSource = new BitmapImage(new Uri(cinema_Pars.Afisha[0].Image));
            Name1.Source = imageSource;
            Name_Cinema1.Text = cinema_Pars.Afisha[0].name;
            BitmapImage imageSource1 = new BitmapImage(new Uri(cinema_Pars.Afisha[1].Image));
            Name2.Source = imageSource1;
            Name_Cinema2.Text = cinema_Pars.Afisha[1].name;
            BitmapImage imageSource2 = new BitmapImage(new Uri(cinema_Pars.Afisha[2].Image));
            Name3.Source = imageSource2;
            Name_Cinema3.Text = cinema_Pars.Afisha[2].name;
            BitmapImage imageSource3 = new BitmapImage(new Uri(cinema_Pars.Afisha[3].Image));
            Name4.Source = imageSource3;
            Name_Cinema4.Text = cinema_Pars.Afisha[3].name;
            BitmapImage imageSource4 = new BitmapImage(new Uri(cinema_Pars.Afisha[4].Image));
            Name5.Source = imageSource4;
            Name_Cinema5.Text = cinema_Pars.Afisha[4].name;
            BitmapImage imageSource5 = new BitmapImage(new Uri(cinema_Pars.Afisha[5].Image));
            Name6.Source = imageSource5;
            Name_Cinema6.Text = cinema_Pars.Afisha[5].name;
            BitmapImage imageSource6 = new BitmapImage(new Uri(cinema_Pars.Afisha[6].Image));
            Name7.Source = imageSource6;
            Name_Cinema7.Text = cinema_Pars.Afisha[6].name;
            BitmapImage imageSource7 = new BitmapImage(new Uri(cinema_Pars.Afisha[7].Image));
            Name8.Source = imageSource7;
            Name_Cinema8.Text = cinema_Pars.Afisha[7].name;
            BitmapImage imageSource8 = new BitmapImage(new Uri(cinema_Pars.Afisha[8].Image));
            Name9.Source = imageSource8;
            Name_Cinema9.Text = cinema_Pars.Afisha[8].name;
            BitmapImage imageSource9 = new BitmapImage(new Uri(cinema_Pars.Afisha[9].Image));
            Name10.Source = imageSource9;
            Name_Cinema10.Text = cinema_Pars.Afisha[9].name;
            BitmapImage imageSource10 = new BitmapImage(new Uri(cinema_Pars.Afisha[10].Image));
            Name11.Source = imageSource10;
            Name_Cinema11.Text = cinema_Pars.Afisha[10].name;
            BitmapImage imageSource11 = new BitmapImage(new Uri(cinema_Pars.Afisha[11].Image));
            Name12.Source = imageSource11;
            Name_Cinema9.Text = cinema_Pars.Afisha[11].name;
            BitmapImage imageSource12 = new BitmapImage(new Uri(cinema_Pars.Afisha[12].Image));
            Name13.Source = imageSource12;
            Name_Cinema13.Text = cinema_Pars.Afisha[12].name;
            BitmapImage imageSource13 = new BitmapImage(new Uri(cinema_Pars.Afisha[13].Image));
            Name14.Source = imageSource13;
            Name_Cinema14.Text = cinema_Pars.Afisha[13].name;
            BitmapImage imageSource14 = new BitmapImage(new Uri(cinema_Pars.Afisha[14].Image));
            Name15.Source = imageSource14;
            Name_Cinema15.Text = cinema_Pars.Afisha[14].name;

        }

      
    }
}
