using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;

namespace Susalem.WPFIndustrialControls.Controls
{
    [TemplatePart(Name = ElementLeftArm, Type = typeof(Path))]
    [TemplatePart(Name = ElementRightArm, Type = typeof(Path))]
    [TemplatePart(Name = ElementChamber, Type = typeof(Border))]
    public class TelescopicArm : Control
    {
        protected Path? LeftArm { get; set; } = null;
        protected Path? RightArm { get; set; } = null;
        protected Border? Chamber { get; set; } = null;

        const string ElementLeftArm = "part_leftArm";
        const string ElementRightArm = "part_rightArm";
        const string ElementChamber = "part_chamber";

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            LeftArm = GetTemplateChild(ElementLeftArm) as Path;
            RightArm = GetTemplateChild(ElementRightArm) as Path;
            Chamber = GetTemplateChild(ElementChamber) as Border;

        }

        public static Thickness GetArmStrokeThickness(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ArmStrokeThicknessProperty);
        }

        public static void SetArmStrokeThickness(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ArmStrokeThicknessProperty, value);
        }

        public static readonly DependencyProperty ArmStrokeThicknessProperty =
            DependencyProperty.RegisterAttached("ArmStrokeThickness", typeof(Thickness), typeof(TelescopicArm), new PropertyMetadata(new Thickness(1)));


        public static Brush GetArmStroke(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ArmStrokeProperty);
        }

        public static void SetArmStroke(DependencyObject obj, Brush value)
        {
            obj.SetValue(ArmStrokeProperty, value);
        }

        public static readonly DependencyProperty ArmStrokeProperty =
            DependencyProperty.RegisterAttached("ArmStroke", typeof(Brush), typeof(TelescopicArm), new PropertyMetadata(Brushes.Black));





        public static double GetValue(DependencyObject obj)
        {
            return (double)obj.GetValue(ValueProperty);
        }

        public static void SetValue(DependencyObject obj, double value)
        {
            obj.SetValue(ValueProperty, value);
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached("Value", typeof(double), typeof(TelescopicArm), new PropertyMetadata(0d, OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ta = d as TelescopicArm;
            double dv = (double)e.NewValue;
            if (ta.Chamber != null)
            {
                ta.Chamber!.Width = 100d - dv;
            }

        }
    }

}
