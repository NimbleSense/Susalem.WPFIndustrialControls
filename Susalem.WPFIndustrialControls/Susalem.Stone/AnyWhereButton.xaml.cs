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
    /// AnyWhereButton.xaml 的交互逻辑
    /// </summary>
    public partial class AnyWhereButton : UserControl
    {
        //鼠标是否按下
        bool _isMouseDown = false;
        //鼠标按下的位置
        Point _mouseDownPosition;
        //鼠标按下控件的位置
        Point _mouseDownControlPosition;

        public AnyWhereButton()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var c = sender as Control;
            _isMouseDown = true;
            _mouseDownPosition = e.GetPosition(this);
            var transform = c.RenderTransform as TranslateTransform;
            if (transform == null)
            {
                transform = new TranslateTransform();
                c.RenderTransform = transform;
            }
            _mouseDownControlPosition = new Point(transform.X, transform.Y);
            c.CaptureMouse();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseDown)
            {
                var c = sender as Control;
                var pos = e.GetPosition(this);
                var dp = pos - _mouseDownPosition;
                var transform = c.RenderTransform as TranslateTransform;
                transform.X = _mouseDownControlPosition.X + dp.X;
                transform.Y = _mouseDownControlPosition.Y + dp.Y;
            }
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var c = sender as Control;
            _isMouseDown = false;
            c.ReleaseMouseCapture();
        }
    }
}
