using Susalem.Stone;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stone.Test
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
            //EllipticStripWindow childWindow = new EllipticStripWindow();
            //childWindow.Owner = this; // 设置父窗口
            //contentControl.Content = childWindow.Content; // 将子窗口的内容设置为父窗口的内容
            //childWindow.Show(); // 显示子窗口
        }
    }
}