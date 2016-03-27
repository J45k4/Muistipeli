using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Muistipeli
{
    /// <summary>
    /// Interaction logic for ChooseSizePage.xaml
    /// </summary>
    public partial class ChooseSizePage : Page
    {
        public event EventHandler<SizeChoosenEventArgs> SizeChoosed;
        int selectedSize = 4;
        public ChooseSizePage()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++) {
                RadioButton button = new RadioButton()
                {
                    GroupName = "Size",
                    Content = (i + 2) * 2 + "x" + (i + 2) * 2,
                    VerticalAlignment = VerticalAlignment.Center,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    FontSize = 20
                };
                button.Click += Button_Click;
                sizes.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioButton b = (RadioButton)sender;
            selectedSize = (sizes.Children.IndexOf(b)+2)*2;
        }

        private void Play(object sender, RoutedEventArgs e)
        {
            if (SizeChoosed != null)
            {
                SizeChoosed(this, new SizeChoosenEventArgs() { Size = selectedSize });
            }
        }
    }
}
