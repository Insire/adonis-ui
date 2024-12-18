using System.Windows;
using AdonisUI.Controls;
using AdonisUI.Demo.ViewModels;

namespace AdonisUI.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : AdonisWindow
    {
        public bool IsDark
        {
            get => (bool)GetValue(IsDarkProperty);
            set => SetValue(IsDarkProperty, value);
        }

        public static readonly DependencyProperty IsDarkProperty = DependencyProperty.Register("IsDark", typeof(bool), typeof(MainWindow), new PropertyMetadata(false, OnIsDarkChanged));

        private static void OnIsDarkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((MainWindow) d).ChangeTheme((bool)e.OldValue);
        }

        public MainWindow()
        {
            DataContext = new ApplicationViewModel();
            InitializeComponent();
        }

        private void ChangeTheme(bool oldValue)
        {
            ResourceLocator.SetColorScheme(Application.Current.Resources, oldValue ? ResourceLocator.LightColorScheme : ResourceLocator.DarkColorScheme);
        }
    }
}
