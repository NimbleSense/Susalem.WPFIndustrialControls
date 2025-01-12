using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Susalem.WPFIndustrialControls.Behaviors
{
    public abstract class TabActionBehaviorBase : Behavior<Button>
    {
        protected DependencyObject GetParentControl(DependencyObject child, Type targetType)
        {
            var parent = VisualTreeHelper.GetParent(child);
            if (parent.GetType() == targetType) { return parent; }
            return GetParentControl(parent, targetType);
        }
    }
}
