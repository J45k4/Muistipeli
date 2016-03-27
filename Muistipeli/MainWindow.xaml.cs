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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChooseSizePage choosesizepage = new ChooseSizePage();
        public MainWindow()
        {
            InitializeComponent();
            choosesizepage.SizeChoosed += Choosesizepage_SizeChoosed;
            MainFrame.Navigate(choosesizepage);

        }

        private void Choosesizepage_SizeChoosed(object sender, SizeChoosenEventArgs e)
        {
            MainFrame.Navigate(new GridBoard(e.Size, new MuistipeliGame()));
        }
    }
}
