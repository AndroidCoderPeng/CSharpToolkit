using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSharpToolkit.Widgets
{
    /// <summary>
    /// PlaceHolderTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class PlaceHolderTextBox : TextBox
    {
        public PlaceHolderTextBox()
        {
            InitializeComponent();
        }

        private void PlaceHolderTextBox_OnLoaded(object sender, RoutedEventArgs e)
        {
            Padding = new Thickness(3, 0, 3, 0);
            PlaceHolderPadding = new Thickness(5, 0, 5, 0);
        }

        #region 依赖属性

        [Category("自定义"), Description("该属性用于调整内部文字的Padding值")]
        public Thickness PlaceHolderPadding
        {
            get => (Thickness)GetValue(PlaceHolderPaddingProperty);
            set => SetValue(PlaceHolderPaddingProperty, value);
        }

        /// <summary>
        /// nameof(PlaceHolderPadding) 对应xaml里面的属性
        /// </summary>
        public static readonly DependencyProperty PlaceHolderPaddingProperty =
            DependencyProperty.Register(nameof(PlaceHolderPadding), typeof(Thickness), typeof(PlaceHolderTextBox),
                new PropertyMetadata(new Thickness(0, 0, 0, 0)));

        [Category("自定义"), Description("该属性用于控制TextBox边框圆角")]
        public int BorderCornerRadius
        {
            get => (int)GetValue(BorderCornerRadiusProperty);
            set => SetValue(BorderCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty BorderCornerRadiusProperty =
            DependencyProperty.Register(nameof(BorderCornerRadius), typeof(int), typeof(PlaceHolderTextBox),
                new PropertyMetadata(0));

        [Category("自定义"), Description("该属性用于显示TextBox的Hint值")]
        public string HintText
        {
            get => (string)GetValue(HintTextProperty);
            set => SetValue(HintTextProperty, value);
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register(nameof(HintText), typeof(string), typeof(PlaceHolderTextBox),
                new PropertyMetadata(null));

        [Category("自定义"), Description("该属性用于鼠标移至TextBox上面时修改边框颜色")]
        public SolidColorBrush MouseOverBorderColor
        {
            get => (SolidColorBrush)GetValue(MouseOverBorderColorProperty);
            set => SetValue(MouseOverBorderColorProperty, value);
        }

        public static readonly DependencyProperty MouseOverBorderColorProperty =
            DependencyProperty.Register(nameof(MouseOverBorderColor), typeof(SolidColorBrush),
                typeof(PlaceHolderTextBox), new PropertyMetadata(new SolidColorBrush(Colors.Red)));

        [Category("自定义"), Description("该属性用于根据文本框内容显示右侧清除按钮")]
        public Visibility IsClearButtonVisible
        {
            get => (Visibility)GetValue(IsClearButtonVisibleProperty);
            set => SetValue(IsClearButtonVisibleProperty, value);
        }

        public static readonly DependencyProperty IsClearButtonVisibleProperty =
            DependencyProperty.Register(nameof(IsClearButtonVisible), typeof(Visibility),
                typeof(PlaceHolderTextBox), new PropertyMetadata(Visibility.Collapsed));

        #endregion

        #region 文本框内容监听

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsClearButtonVisible = Text.Length == 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        #endregion

        #region 清除按钮事件

        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        #endregion
    }
}