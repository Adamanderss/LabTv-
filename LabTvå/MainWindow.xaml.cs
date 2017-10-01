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

namespace LabTvå
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string name;
        public static string date;
        public static string comment;
        public static string totalInput;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                totalInput = "Namn: " + name + "\nDatum: " + date + "\nKommentar: " + comment;
                listBox1.Items.Add(totalInput.ToString());
         
                this.nameInput.Clear();
                this.dateInput.Clear();
                this.commentInput.Clear();
                this.nameInput.Focus(); 
        }
        private void NameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = nameInput.Text;
        }
        private void DateInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            date = dateInput.Text;          
        }
        private void CommentInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            comment = commentInput.Text;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
