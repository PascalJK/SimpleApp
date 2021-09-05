using SimpleApp.ViewModels.Base;

namespace SimpleApp.ViewModels
{
    internal class Page2VM : BaseVM
    {
        private string _Text1 = "Hello From the other Side";
        public string Text1 { get => _Text1; set => SetProperty(ref _Text1, value); }

        public Page2VM()
        {
        }
    }
}
