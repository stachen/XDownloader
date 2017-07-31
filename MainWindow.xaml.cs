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

namespace XDownloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Row
        {
            public string Url { get; set; }
            public string Title { get; set; }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            var rows = new List<Row>();
            rows.Add(new Row() { Url = "Http://www.google.com", Title = "Good stuff" });
            var query = from row in rows
                select row;


            dataGrid.ItemsSource = query.ToList();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
