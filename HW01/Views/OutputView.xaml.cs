using System.Windows.Controls;
using HW01.Models;
using HW01.ViewModels;

namespace HW01.Views
{
    /// <summary>
    /// Interaction logic for OutputView.xaml
    /// </summary>
    public partial class OutputView : UserControl
    {
        private OutputViewModel _outputViewModel;

        public OutputView(UserModel user)
        {
            InitializeComponent();
            _outputViewModel = new OutputViewModel(user);
            DataContext = _outputViewModel;
        }

    }
}
