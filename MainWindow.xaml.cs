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
            for (int i = 0; i < 1000; i++)
            {
                rows.Add(new Row() { Url = "Http://www.google.com", Title = "Good stuff" });
                rows.Add(new Row() { Url = "Http://www.yahoo.com", Title = "Good stuff 2" });
            }
            var query = from row in rows
                select row;
            dataGrid.ItemsSource = rows;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            var grid = (DataGrid)sender;
            var index = grid.SelectedIndex;
            if(index == -1 )
            {
                return;
            }
            var sources = grid.ItemsSource.Cast<Row>().ToList();
            sources.RemoveAt(index);
            dataGrid.ItemsSource = sources;
            Console.WriteLine(sender);
            Console.WriteLine(e);
        }
    }
}
