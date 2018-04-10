using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Собственное_прриложение
{
    /// <summary>
    /// Логика взаимодействия для Text.xaml
    /// </summary>
    public partial class Text : Window
    {
        public Text()
        {
            InitializeComponent();
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, TextBox1.Text);
            System.Windows.Forms.MessageBox.Show("Файл сохранён");
          
            
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
           if(saveFileDialog.ShowDialog()==System.Windows.Forms.DialogResult.Cancel)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, TextBox1.Text);
                System.Windows.MessageBox.Show("Файл сохранён");
            }
        }

        private void Create1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if(saveFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.Cancel)
            {
                var filename = saveFileDialog.FileName;
                File.Create(filename);
            }
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Select_file(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            string FileName = openFileDialog.FileName;
            string FileText = File.ReadAllText(FileName);
            TextBox1.Text = FileText;
            System.Windows.MessageBox.Show("Файл открыт");
        }

        private void De1ete1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            var fileDelete = openFileDialog.FileName;
          File.Delete(fileDelete);
            System.Windows.MessageBox.Show("Файл удалён");
        }

        private void Create_Papc1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            var papka = saveFileDialog.FileName;
            Directory.CreateDirectory(papka);
        }

        private void Delete1_Papka(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return;
            var papka_delete = openFileDialog.FileName;
            Directory.Delete(papka_delete,true);
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Shrift(object sender, RoutedEventArgs e)
        {

        }

        private void Size(object sender, RoutedEventArgs e)
        {

        }
    }
}
