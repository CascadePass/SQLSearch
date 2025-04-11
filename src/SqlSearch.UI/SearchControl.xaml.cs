using System.Windows;
using System.Windows.Controls;

namespace SqlSearch.UI
{
    /// <summary>
    /// Interaction logic for SearchControl.xaml
    /// </summary>
    public partial class SearchControl : UserControl
    {
        public static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.Register("SearchText", typeof(string), typeof(SearchControl), new PropertyMetadata(string.Empty));

        public SearchControl()
        {
            this.InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        public string SearchText
        {
            get { return (string)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }
    }
}
