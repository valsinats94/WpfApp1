using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Declarations

        private BaseViewModel viewModel;
        private ICommand teacherCommand;
        private ICommand studentCommand;

        #endregion

        public BaseViewModel BaseViewModel
        {
            get
            {
                return viewModel;
            }
            set
            {
                viewModel = value;
                OnPropertyChanged("BaseViewModel");
            }
        }

        public ICommand TeacherCommand
        {
            get
            {
                if (teacherCommand == null)
                    teacherCommand = new DelegateCommand<object>(CreateTeacherViewModel);

                return teacherCommand;
            }
        }

        public ICommand StudentCommand
        {
            get
            {
                if (studentCommand == null)
                    studentCommand = new DelegateCommand<object>(CreateStudentViewModel);

                return studentCommand;
            }
        }

        private void CreateStudentViewModel(object obj)
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            StudentView studentView = new StudentView();

            studentViewModel.View = studentView;
            studentView.DataContext = studentViewModel;

            BaseViewModel = studentViewModel;
        }

        private void CreateTeacherViewModel(object obj)
        {
            BaseViewModel = new TeacherViewModel();
        }
    }
}
