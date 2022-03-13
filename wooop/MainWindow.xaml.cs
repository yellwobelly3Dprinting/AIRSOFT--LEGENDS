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

namespace wooop
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/15udL4qAruwHCsjwJ_l_HVqvOHA4-wox4?usp=sharing");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox?compose=DmwnWrRtsnbSXNSsmKmlqkcMxlJdSJcCzgjgNDVTMXbdgJVFmnbpWcwQnVDtDtGSVKGgVWsHmLpQ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1Oz6mhTRLfVl-sVAszeNzrjXHXN6l2fO-?usp=sharing");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1t-Jz1zK0m5jfq3vMapCTprCV9yhb_FaRX_YiAcOYgoY/edit?usp=sharing");
        }
    }
}
