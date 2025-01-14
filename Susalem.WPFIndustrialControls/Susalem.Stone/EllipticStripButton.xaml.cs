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

namespace Susalem.Stone
{
    /// <summary>
    /// EllipticStripButton.xaml 的交互逻辑
    /// </summary>
    public partial class EllipticStripButton : UserControl
    {
        public EllipticStripButton()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {

        }
        bool doDrag = false;
        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDrag&&e.LeftButton==MouseButtonState.Pressed)
            {
                e.Handled = true;
                this.Margin = new Thickness(this.Margin.Left + e.GetPosition(this).X, this.Margin.Top + e.GetPosition(this).Y, this.Margin.Right - e.GetPosition(this).X, this.Margin.Bottom - e.GetPosition(this).Y);
            }
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            doDrag = true;
            this.CaptureMouse();
            e.Handled = true;
        }

        private void UserControl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.ReleaseMouseCapture();
            doDrag = false;
            e.Handled = true;
        }
    }
}
