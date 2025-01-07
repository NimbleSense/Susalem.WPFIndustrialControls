using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Susalem.WPFIndustrialControls.AttachProperties
{
    public class IconAP
    {
        public enum HorizontalPlacement
        {
            Left,
            Right
        }

        public static Path GetIcon(DependencyObject obj)
        {
            return (Path)obj.GetValue(IconProperty);
        }

        public static void SetIcon(DependencyObject obj, Path value)
        {
            obj.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =DependencyProperty.RegisterAttached("Icon", typeof(Path), typeof(IconAP));

        public static Image GetImage(DependencyObject obj)
        {
            return (Image)obj.GetValue(ImageProperty);
        }

        public static void SetImage(DependencyObject obj, Image value)
        {
            obj.SetValue(ImageProperty, value);
        }

        public static readonly DependencyProperty ImageProperty =DependencyProperty.RegisterAttached("Image", typeof(Image), typeof(IconAP));

        public static HorizontalPlacement GetHorizontalPlacement(DependencyObject obj)
        {
            return (HorizontalPlacement)obj.GetValue(HorizontalPlacementProperty);
        }

        public static void SetHorizontalPlacement(DependencyObject obj, HorizontalPlacement value)
        {
            obj.SetValue(HorizontalPlacementProperty, value);
        }

        public static readonly DependencyProperty HorizontalPlacementProperty =DependencyProperty.RegisterAttached("HorizontalPlacement", typeof(HorizontalPlacement), typeof(IconAP), new PropertyMetadata(HorizontalPlacement.Left));









    }
}
