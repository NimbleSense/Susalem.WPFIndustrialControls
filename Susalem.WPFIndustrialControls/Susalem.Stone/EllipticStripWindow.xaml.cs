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
using System.Windows.Shapes;

namespace Susalem.Stone
{
    /// <summary>
    /// EllipticStripWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EllipticStripWindow : Window
    {
        Point _pressedPosition;
        bool _isDragMoved = false;
        public EllipticStripWindow()
        {
            InitializeComponent();
        }

        void Window_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            _pressedPosition = e.GetPosition(this);
        }

        void Window_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed && _pressedPosition != e.GetPosition(this))
            {
                _isDragMoved = true;
                DragMove();
            }
        }

        void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDragMoved)
            {
                _isDragMoved = false;
                e.Handled = true;
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
