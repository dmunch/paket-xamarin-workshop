using System;
using Prism.Mvvm;
using Prism.Commands;

namespace xamarinpaketworkshop.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        string _title = "Welcome";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand SayHelloCommand { get; set; }

        public MainPageViewModel()
        {
            SayHelloCommand = new DelegateCommand(SayHello);
        }

        void SayHello()
        {
            this.Title = "Hello Paket";
        }
    }
}