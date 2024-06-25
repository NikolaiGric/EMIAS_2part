using EMIAS_2part.ViewModel;
using System.Windows;

namespace EMIAS_2part
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}