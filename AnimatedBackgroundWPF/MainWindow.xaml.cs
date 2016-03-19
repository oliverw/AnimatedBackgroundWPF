using System.Windows;

namespace AnimatedBackgroundWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            uc.MainStoryboard.Begin();
        }
    }
}
