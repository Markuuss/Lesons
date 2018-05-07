﻿using System;
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
            FileStream fileStream = File.OpenRead("Opisanie1.txt");
            StreamReader streamReader = new StreamReader(fileStream,Encoding.GetEncoding(1251));
            Opisanie1.Text = streamReader.ReadToEnd();
            
            FileStream fileStream1 = File.OpenRead("Opisanie2.txt");
            StreamReader streamReader1 = new StreamReader(fileStream1, Encoding.GetEncoding(1251));
            Opisanie2.Text = streamReader1.ReadToEnd();


            streamReader.Close();
            streamReader1.Close();
        }

      
    }
}
