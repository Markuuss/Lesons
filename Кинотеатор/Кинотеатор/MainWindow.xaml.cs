using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Кинотеатор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        private MainPage mainPage = new MainPage();
        private Cinema cinema = new Cinema();
        private Afisha afisha = new Afisha();
        private Authi authi = new Authi();
        
      
        public MainWindow()
        {
            InitializeComponent();
            Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            News_Pars news_Pars = new News_Pars();
            news_Pars.UpDateAdapter();
            Cinema_Pars cinema_Pars = new Cinema_Pars();
            cinema_Pars.CinemaParsing();
            
          
        }
       
        private void main_Selected(object sender, RoutedEventArgs e)
        {
          Frame.NavigationService.Navigate(mainPage);

        }

        private void mainButtonHamb_Selected(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(afisha);


        }

        private void Autifical_Selected(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(authi);
        }
    }
}
//<Label Content = "Выберите кинокартину на которую вы желайте пойти" Foreground="White" FontSize="17" HorizontalAlignment="Left" Margin="10,10,0,0" VerticalAlignment="Top" Width="433"/>
//        <ScrollViewer HorizontalContentAlignment = "Left" HorizontalAlignment="Left" Height="466" Margin="0,42,0,0" VerticalAlignment="Top" Width="662">
//            <StackPanel HorizontalAlignment = "Left" Height="465" Width="652">
//                <StackPanel Orientation = "Horizontal" >
//                    < Image Source="Imege_Resources/Msit.png" Height="194" Margin="0,0,0.2,0" Width="255" Stretch='Fill'/>
//                    <Label VerticalContentAlignment = "Top" HorizontalContentAlignment="Left" Content="HYI" Width="390"/>
//                </StackPanel>
//                <StackPanel Orientation = "Horizontal" >
//                    < Image Source="Imege_Resources/2.png" Height="194" Margin="0,0,0.2,0" Width="255" Stretch="Fill"/>
//                    <Label VerticalContentAlignment = "Top" HorizontalContentAlignment="Left" Content="HYI" Width="390"/>
//                </StackPanel>
//                <StackPanel Orientation = "Horizontal" >
//                    < Image Source="Imege_Resources/3.png" Height="194" Margin="0,0,0.2,0" Width="255" Stretch="Fill"/>
//                    <Label VerticalContentAlignment = "Top" HorizontalContentAlignment="Left" Content="HYI" Width="390"/>
//                </StackPanel>



//            </StackPanel>
//        </ScrollViewer>
