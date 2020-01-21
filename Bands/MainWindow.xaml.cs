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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Bands Band1 = new Bands("Muse", "1994", "Matt Bellamy, Chris Wolstenholme, Dominic Howard");
            Bands Band2 = new Bands("Blur", "1988", "Damon Albarn, Graham Coxon, Alex James, Dave Rowntree");
            Bands Band3 = new Bands("Crush 40", "1998", "Johnny Gioeli, Tomoya Ohtani, Jun Senoue");
            Bands Band4 = new Bands("Gorillaz", "1998", "Damon Albarn, Jamie Hewlett, Paul Simonon, Mike Smith, Remi Kabaka Jr, Mick Jones, Jean-Michael Jarre, Danger Mouse");
            Bands Band5 = new Bands("Red Hot Chilli Peppers", "1983", "John Frusciante, Chad Smith, Anthony Kliedis, Flea, Hillel Slovak, Jack Irons");
            Bands Band6 = new Bands("Radiohead", "1985", "Thom Yorke, Jonny Greenwood, Ed O'Brien, Colin Greenwood, Philip Selway");


        }
    }
}
