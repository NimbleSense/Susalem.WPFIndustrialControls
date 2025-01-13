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

namespace Stone.Test
{
    /// <summary>
    /// TestEllioticStripBtn.xaml 的交互逻辑
    /// </summary>
    public partial class TestEllioticStripBtn : Window
    {
        public TestEllioticStripBtn()
        {
            InitializeComponent();
        }

        Point _pressedPosition;
        bool _isDragMoved = false;

        // 因为DragMove的内部实现使用了SC_MOVE，使标题栏（win32窗口）捕获鼠标，原本窗口失去鼠标捕获。
        // 窗口内的控件无法响应鼠标消息，因此上述简单拖动在有控件的窗口中是不可行的
        // (局部拖动是可行的，但本文讲的是任意区域拖动）。

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

        private void btn_upload_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("上传成功");
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }   

    }
}
