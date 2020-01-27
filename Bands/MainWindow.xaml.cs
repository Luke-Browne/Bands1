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
        List<Band> RockBands = new List<Band>();
        List<Band> PopBands = new List<Band>();
        List<Band> IndieBands = new List<Band>();

        public Random rnd = new Random();
        DateTime[] ReleaseDates = {
                new DateTime(1992,9,12) , new DateTime(1991,11,15), new DateTime(1997,4,13), new DateTime(1992,1,23), new DateTime(1999,10,13),
                new DateTime(1996,7,5), new DateTime(1996,4,17), new DateTime(1998,10,13), new DateTime(1999,10,13), new DateTime(2015,10,13),
                new DateTime(2011,10,13),new DateTime(2012,10,13),new DateTime(2010,10,13),new DateTime(2014,12,13)
             };

        public MainWindow()
        {
            InitializeComponent();
        }

        public DateTime RandomDate(string x)
        {
            if (x == "Blur")
            {
                int randomDate = rnd.Next(11, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else if (x == "Muse")
            {
                int randomDate = rnd.Next(5, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else if (x == "A-ha")
            {
                int randomDate = rnd.Next(1, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else if (x == "Take That")
            {
                int randomDate = rnd.Next(1, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else if (x == "Bloc Party")
            {
                int randomDate = rnd.Next(1, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else if (x == "Arcade Fire")
            {
                int randomDate = rnd.Next(6, 14);
                DateTime releaseDate = ReleaseDates[randomDate];
                return releaseDate;
            }
            else
            {
                return DateTime.Now;
            }
        }
        public int RandomSales()
        {
            int Sales = rnd.Next(100, 100000);
            return Sales;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboBox1.Items.Add("All");
            comboBox1.Items.Add("Rock");
            comboBox1.Items.Add("Pop");
            comboBox1.Items.Add("Indie");
            comboBox1.SelectedItem = ("All");

            Band Band1 = new RockBand("Blur", new DateTime(1989, 3, 27), "Damon Albarn, Alex James, Graham Coxon, Dave Rowntree");
            Album Parklife = new Album("Parklife", RandomDate(Band1.Name), RandomSales());
            Band1.Albums.Add(Parklife);

            Band Band2 = new RockBand("Muse", new DateTime(1994, 6, 11), "Matt Bellamy, Chris Wolstenholme, Dominic Howard");
            Album Drones = new Album("Drones", RandomDate(Band2.Name), RandomSales());
            Band2.Albums.Add(Drones);


            Band Band3 = new PopBand("A-ha", new DateTime(1982, 4, 7), "Morten Harket, Magne Furuholmen, Paul Waaktaar-Savoy");
            Album Lifelines = new Album("Lifelines", RandomDate(Band3.Name), RandomSales());
            Band3.Albums.Add(Lifelines);

            Band Band4 = new PopBand("Take That", new DateTime(1990, 11, 14), "Robbie Williams, Mark Owen, Howard Donald, Gary Barlow, Jason Orange");
            Album Progress = new Album("Progress", RandomDate(Band4.Name), RandomSales());
            Band4.Albums.Add(Progress);


            Band Band5 = new IndieBand("Bloc Party", new DateTime(1999, 2, 17), "Gordon Moakes, Russell Lissack, Kele Okereke");
            Album Hymns = new Album("Hymns", RandomDate(Band5.Name), RandomSales());
            Band5.Albums.Add(Hymns);

            Band Band6 = new IndieBand("Arcade Fire", new DateTime(2001, 5, 21), "Win Butler, Richard Reed Parry, Matt Bauder, William Butler, Jeremey Gara, Howard Bilerman, Tim Kingsbury");
            Album Funeral = new Album("Funeral", RandomDate(Band6.Name), RandomSales());
            Band6.Albums.Add(Funeral);

            allBands.Add(Band1);
            allBands.Add(Band2);
            allBands.Add(Band3);
            allBands.Add(Band4);
            allBands.Add(Band5);
            allBands.Add(Band6);
            allBands.Sort();

            RockBands.Add(Band1);
            RockBands.Add(Band2);
            PopBands.Add(Band3);
            PopBands.Add(Band4);
            IndieBands.Add(Band5);
            IndieBands.Add(Band6);

            lbxBands.ItemsSource = allBands;
        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lbxBands.SelectedItem as Band;

            if (selectedBand != null)
            {
                membersTxt.Text = selectedBand.Members;
                yearTxt.Text = selectedBand.YearFormed.ToShortDateString();
                lbxAlbums.ItemsSource = null;
                lbxAlbums.ItemsSource = selectedBand.Albums;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
