using HW01.Models;


namespace HW01.Managers
{
    class NavigationManager
    {
        private static NavigationManager _instance;
        private static object _locker = new object();
        private NavigationModel _navigationModel;

        public static NavigationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    {
                        lock (_locker)
                        {
                            _instance = new NavigationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Initialize(NavigationModel navigationModel)
        {
            _navigationModel = navigationModel;
        }

        public void Navigate(DataHandlers handler)
        {
            _navigationModel?.Navigate(handler);
        }

        public void LoadData(UserModel user)
        {
            _navigationModel?.LoadData(user);
        }
    }
}
