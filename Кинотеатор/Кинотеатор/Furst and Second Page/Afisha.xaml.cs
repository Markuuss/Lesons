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
        Button[] buttons = new Button[15];
        private Time_Seans time_Seans = new Time_Seans();
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
            Pars_opisan pars_ = new Pars_opisan();
            pars_.Opisan();
            

            

            
            for (int i = 0; i <15 ; i++)
            {
            TextBlock textBlock = new TextBlock();
                TextBlock text = new TextBlock();
            BitmapImage imageSource = new BitmapImage(new Uri(cinema_Pars.Afisha[i].Image));
            Image image = new Image();
            image.HorizontalAlignment = HorizontalAlignment.Left;
            image.Width = 150;
            image.Source = imageSource;
            
                textBlock.Foreground = new System.Windows.Controls.TextBlock().Foreground = System.Windows.Media.Brushes.White;
                textBlock.FontSize = 23;
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                textBlock.VerticalAlignment = VerticalAlignment.Top;
                textBlock.Text = cinema_Pars.Afisha[i].name;
                text.Foreground = new System.Windows.Controls.TextBlock().Foreground = System.Windows.Media.Brushes.White;
                text.FontSize = 15;
                text.HorizontalAlignment = HorizontalAlignment.Center;
                text.VerticalAlignment = VerticalAlignment.Top;
                text.Text = pars_.Opisa[i].Opisanie;
                var butto=new Button();
                for (int j = 0; j < buttons.Length; j++)
                {
                    butto = new Button
                    {
                        Content = "Выбор сеанса",
                        Width = 250,
                        Height = 50,
                        Background = System.Windows.Media.Brushes.Black,
                        Foreground =System.Windows.Media.Brushes.White,
                        HorizontalAlignment = HorizontalAlignment.Right,
                        Tag = textBlock.Text
                    };
                    buttons[i] = butto;
                }
                Stack.Children.Add(textBlock);
                Stack.Children.Add(text);
                Stack.Children.Add(image);
                Stack.Children.Add(butto);
            }
            var button = new Button();
            for ( int i = 0; i <buttons.Length-1; i++)
            {
                buttons[i].Click += (e, s) => {
                    time_Seans = new Time_Seans(buttons[i].Tag.ToString());
                    NavigationService.Navigate(time_Seans);
                };
            }
          

        }

      
    }
}
