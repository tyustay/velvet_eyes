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
using velvet_eyes.AppData;
using velvet_eyes.Pages;

namespace velvet_eyes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameObj.frameMain = FrmMain;

            FrmMain.Navigate(new Page());

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.GoBack();
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new Page2());
            this._NavigationFrame.Navigate(new Uri("Pages/Page2.xaml", UriKind.Relative));
        }
    }
}
