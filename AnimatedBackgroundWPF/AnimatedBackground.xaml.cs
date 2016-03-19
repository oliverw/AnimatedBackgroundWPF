using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace AnimatedBackgroundWPF
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class AnimatedBackground : UserControl
    {
        public AnimatedBackground()
        {
            InitializeComponent();
        }

        public Storyboard MainStoryboard => (Storyboard)this.Resources["MainStoryboard"];
    }
}
