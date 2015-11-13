using System.Reflection;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using Prism.Mvvm;
using System.Globalization;
using System;

namespace paketxamarinworkshop
{
    using Views;
    using ViewModels;

    public class Bootstrapper : UnityBootstrapper
    {
        protected override Page CreateMainPage()
        {
            return Container.Resolve<MainPage>();
        }
        protected override void RegisterTypes()
        {
            //default convention – NavigationService.Navigate("ViewA");
            //Container.RegisterTypeForNavigation<ViewA>();

            //provide custom string as a unique name – NavigationService.Navigate("A");
            //Container.RegisterTypeForNavigation<ViewA>("A");

            //use a ViewModel class to act as the unique name – NavigationService.Navigate<ViewAViewModel>();
            //Container.RegisterTypeForNavigation<ViewA, ViewAViewModel>();
        }
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.Name;
                var viewModelAssemblyName = typeof(MainPageViewModel).GetTypeInfo().Assembly.FullName;;
                var viewModelNamespace = typeof(MainPageViewModel).GetTypeInfo().Namespace;
                var viewModelName = String.Format(CultureInfo.InvariantCulture, "{0}.{1}ViewModel, {2}", viewModelNamespace, viewName, viewModelAssemblyName);

                return Type.GetType(viewModelName);
            });
        }
    }
}
