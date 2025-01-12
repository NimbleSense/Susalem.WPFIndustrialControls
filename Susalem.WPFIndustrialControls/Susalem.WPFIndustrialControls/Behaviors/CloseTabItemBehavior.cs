using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Susalem.WPFIndustrialControls.Behaviors
{
    public class CloseTabItemBehavior : TabActionBehaviorBase
    {
        private async void CloseTabItem(object sender, RoutedEventArgs e)
        {
            var bt = sender as Button;
            var tabitem = GetParentControl(bt,typeof(TabItem)) as TabItem;
            var tabcontrol= GetParentControl(tabitem, typeof(TabControl)) as TabControl;
            if (tabcontrol!=null)
            {
               tabitem.Width=tabitem.ActualWidth;
                tabitem.HorizontalAlignment=HorizontalAlignment.Left;
                DoubleAnimation da = new(0, new Duration(TimeSpan.FromSeconds(0.2)));
                tabitem.BeginAnimation(FrameworkElement.WidthProperty, da);
                await Task.Delay(200);
                tabcontrol.Items.Remove(tabitem);
            }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Click += CloseTabItem;
        }
        protected override void OnDetaching()
        {
            AssociatedObject.Click -= CloseTabItem;
        }
    }
}
