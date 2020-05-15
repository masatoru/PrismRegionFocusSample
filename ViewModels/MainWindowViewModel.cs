using Prism.Mvvm;

namespace PrismRegionFocusSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Region Focus Sample";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
