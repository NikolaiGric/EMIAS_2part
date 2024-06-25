using System.Collections.ObjectModel;
using EMIAS_10_cs.ViewModel.Helpers;
using EMIAS_2part.Model;

namespace EMIAS_2part.ViewModel
{
    internal class AdminViewModel : BindingHelper
    {
        #region Свойства

        private Admin selected;
        public Admin Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Admin> admins;
        public ObservableCollection<Admin> Admins
        {
            get { return admins; }
            set
            {
                admins = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public AdminViewModel()
        {
            Admins = new ObservableCollection<Admin>();
            {
                new Admin("Admin", "7700", "Иванов", "Александр", "Александрович");
            }
        }
    }
}
