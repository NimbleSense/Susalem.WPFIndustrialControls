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
    public class CreateNewTabItemBehavior : TabActionBehaviorBase
    {
        private void CreateNewTabItem(object sender, RoutedEventArgs e)
        {
            var bt = sender as Button;
            TextBlock text = new()
            {
                Text = "Empty Tab",
                FontSize=20,
            };
            var tabitem = new TabItem()
            {
                Header="Empty Tab",
                Content = text
            };
            var tabcontrol = GetParentControl(bt, typeof(TabControl)) as TabControl;
            if (tabcontrol != null)
            {
                tabcontrol.Items.Add(tabitem);
              
                tabcontrol.SelectedItem = tabitem;
                Transform tf = new TranslateTransform(-tabitem.ActualWidth,0);
                tabitem.RenderTransform = tf;
                DoubleAnimation da = new(0, new Duration(TimeSpan.FromSeconds(0.2)));
                tf.BeginAnimation(TranslateTransform.XProperty, da);
            }
        }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.Click += CreateNewTabItem;
        }
        protected override void OnDetaching()
        {
            AssociatedObject.Click -= CreateNewTabItem;
        }
    }
}
