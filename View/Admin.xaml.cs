using EMIAS_2part.ViewModel;
using System.Windows;

namespace EMIAS_2part
{
    public partial class Admin : Window
    {
        public Admin
        {
            InitializeComponent();
            DataContext = new AdminViewModel();
    }
}
}
