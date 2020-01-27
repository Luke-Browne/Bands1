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

            Band Band1 = new RockBand("Blur", new DateTime(1989, 3, 27), "Damon Albarn, Alex James, Graham Coxon, Dave Rowntree");
            Band Band2 = new RockBand("Muse", new DateTime(1994, 6, 11), "Matt Bellamy, Chris Wolstenholme, Dominic Howard");

            Band Band3 = new PopBand("A-ha", new DateTime(1982, 4, 7), "Morten Harket, Magne Furuholmen, Paul Waaktaar-Savoy");
            Band Band4 = new PopBand("Take That", new DateTime(1990, 11, 14), "Robbie Williams, Mark Owen, Howard Donald, Gary Barlow, Jason Orange");

            Band Band5 = new IndieBand("Bloc Party", new DateTime(1999, 2, 17), "Gordon Moakes, Russell Lissack, Kele Okereke");
            Band Band6 = new IndieBand("Arcade Fire", new DateTime(2001, 5, 21), "Win Butler, Richard Reed Parry, Matt Bauder, William Butler, Jeremey Gara, Howard Bilerman, Tim Kingsbury");

            allBands.Add(Band1);
            allBands.Add(Band2);
            allBands.Add(Band3);
            allBands.Add(Band4);
            allBands.Add(Band5);
            allBands.Add(Band6);
            allBands.Sort();

            lbxBands.ItemsSource = allBands;
        }

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
