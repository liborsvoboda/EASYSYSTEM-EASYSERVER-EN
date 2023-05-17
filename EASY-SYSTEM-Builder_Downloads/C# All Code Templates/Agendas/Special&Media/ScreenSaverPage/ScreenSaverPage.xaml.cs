using EASYTools.ImageEffectLibrary;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace GlobalNET.Pages {

    public partial class ScreenSaverPage : UserControl {
        private Trackball _trackball;

        public ScreenSaverPage() {
            InitializeComponent();

            _trackball = new Trackball();
            _trackball.Attach(this);
            _trackball.Slaves.Add(myViewport3D);
            _trackball.Enabled = true;

            var s = (Storyboard)FindResource("RotateStoryboard");
            BeginStoryboard(s);
        }
    }
}