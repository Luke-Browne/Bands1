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

namespace Bands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Band> allBands = new List<Band>();
        List<Band> filteredBands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Rock");
            comboBox1.Items.Add("Pop");
            comboBox1.Items.Add("Indie");
            comboBox1.SelectedItem = ("All");

            Band Band1 = new Band("Muse", "1994", "Matt Bellamy, Chris Wolstenholme, Dominic Howard");
            Band Band2 = new Band("Blur", "1988", "Damon Albarn, Graham Coxon, Alex James, Dave Rowntree");
            Band Band3 = new Band("Crush 40", "1998", "Johnny Gioeli, Tomoya Ohtani, Jun Senoue");
            Band Band4 = new Band("Gorillaz", "1998", "Damon Albarn, Jamie Hewlett, Paul Simonon, Mike Smith, Remi Kabaka Jr, Mick Jones, Jean-Michael Jarre, Danger Mouse");
            Band Band5 = new Band("Red Hot Chilli Peppers", "1983", "John Frusciante, Chad Smith, Anthony Kliedis, Flea, Hillel Slovak, Jack Irons");
            Band Band6 = new Band("Radiohead", "1985", "Thom Yorke, Jonny Greenwood, Ed O'Brien, Colin Greenwood, Philip Selway");

            allBands.Add(Band1);
            allBands.Add(Band2);
            allBands.Add(Band3);
            allBands.Add(Band4);
            allBands.Add(Band5);
            allBands.Add(Band6);
            allBands.Sort();

            lbxBands.ItemsSource = allBands;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
