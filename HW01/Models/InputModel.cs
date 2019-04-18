using System;
using System.Windows.Forms;
using HW01.Managers;


namespace HW01.Models
{
    class InputModel
    {
        private UserModel _user;

        private readonly DateTime periodFrom;
        private readonly DateTime periodTo;

        public InputModel(UserModel user)
        {
            _user = user;
            DateTime presentDay = DateTime.Today;
            periodFrom = new DateTime(presentDay.Year - 135, presentDay.Month, presentDay.Day, presentDay.Hour, presentDay.Minute, presentDay.Second);
            periodTo = new DateTime(presentDay.Year - 1, presentDay.Month, presentDay.Day, presentDay.Hour, presentDay.Minute, presentDay.Second);
        }

        public void Submit(DateTime selectedData)
        {
            if (selectedData <= periodFrom)
            {
                MessageBox.Show("The date is invalid");
                return;
            }
            if (selectedData >= periodTo)
            {
                MessageBox.Show("The date is invalid");
                return;
            }

            _user = new UserModel(selectedData);
            NavigationManager.Instance.LoadData(_user);
            NavigationManager.Instance.Navigate(DataHandlers.Output);

        }
    }
}
