using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSharpToolkit.Widgets
{
    /// <summary>
    /// CornerRadiusButton.xaml 的交互逻辑
    /// </summary>
    public partial class CornerRadiusButton : Button
    {
        public CornerRadiusButton()
        {
            InitializeComponent();
        }

        #region 自定义属性

        [Category("自定义"), Description("该属性用于控制Button边框圆角")]
        public int BorderCornerRadius
        {
            get => (int)GetValue(BorderCornerRadiusProperty);
            set => SetValue(BorderCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty BorderCornerRadiusProperty =
            DependencyProperty.Register(nameof(BorderCornerRadius), typeof(int), typeof(CornerRadiusButton),
                new PropertyMetadata(0));

        [Category("自定义"), Description("该属性用于鼠标移至Button上面时修改边框颜色")]
        public SolidColorBrush MouseOverBackground
        {
            get => (SolidColorBrush)GetValue(MouseOverBackgroundProperty);
            set => SetValue(MouseOverBackgroundProperty, value);
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register(nameof(MouseOverBackground), typeof(SolidColorBrush),
                typeof(CornerRadiusButton), new PropertyMetadata(new SolidColorBrush(Colors.LightGray)));

        #endregion
    }
}