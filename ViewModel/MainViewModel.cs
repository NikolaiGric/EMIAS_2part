using System.Collections.ObjectModel;
using EMIAS_10_cs.ViewModel.Helpers;
using EMIAS_2part.Model;

namespace EMIAS_2part.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Свойства

        private User selected;
        public User Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public MainViewModel()
        {
            Users = new ObservableCollection<User>();
            {
                new User("User", "7700", "Иванов", "Александр", "Александрович", "2024-03-01", "Где надо");
            }
        }
    }
}
