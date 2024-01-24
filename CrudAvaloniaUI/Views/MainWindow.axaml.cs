using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CrudAvaloniaUI.ViewModels;

namespace CrudAvaloniaUI.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}