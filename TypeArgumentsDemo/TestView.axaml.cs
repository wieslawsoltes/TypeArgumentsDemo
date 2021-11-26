using Avalonia.Markup.Xaml;

namespace TypeArgumentsDemo
{
    public class TestView : BaseView<string>
    {
        public TestView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
