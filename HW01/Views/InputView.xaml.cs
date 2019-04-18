using System.Windows.Controls;
using HW01.Models;
using HW01.ViewModels;

namespace HW01.Views
{
    /// <summary>
    /// Interaction logic for InputView.xaml
    /// </summary>
    public partial class InputView : UserControl
    {
        private InputViewModel _inputViewModel;

        public InputView(UserModel user)
        {
            InitializeComponent();
            _inputViewModel = new InputViewModel(user);
            DataContext = _inputViewModel;
        }
    }
}
