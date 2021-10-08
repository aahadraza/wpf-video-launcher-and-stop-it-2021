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

namespace VIDEO_PLAYING_AND_SEARCH_IT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            myMedia.Volume = 100;
            myMedia.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myMedia.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e, object v)
        {
            myMedia.Pause();
            if(myMedia.Volume==100)
            {
                myMedia.Volume = 0;
                muteButt.Content = v;
            }
            else
            {
                myMedia.Volume = 100;
                muteButt.Content = v;
            }
        }
    }
}
