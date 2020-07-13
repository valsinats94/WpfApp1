using Prism.Commands;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    public class TeacherViewModel : BaseViewModel
    {
        private ICommand testCommand;

        public ICommand TestCommand
        {
            get
            {
                if (testCommand == null)
                    testCommand = new DelegateCommand<object>(Test);

                return testCommand;
            }
        }

        private void Test(object obj)
        {
            
        }
    }
}
