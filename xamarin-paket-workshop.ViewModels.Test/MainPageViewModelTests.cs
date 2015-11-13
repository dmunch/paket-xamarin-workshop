using System;
using NUnit.Framework;

namespace xamarinpaketworkshop.ViewModels.Test
{
    public class MainPageViewModelTests
    {
       
        public MainPageViewModelTests()
        {
        }
            
        [Test]
        public void TitleEqualsWelcomeOnConstruction()
        {
            var viewModel = new MainPageViewModel();

            Assert.AreEqual("Welcome", viewModel.Title);
        }

        [Test]
        public void SayHelloCommandChangesText()
        {
            var viewModel = new MainPageViewModel();

            viewModel.SayHelloCommand.Execute();
            Assert.AreEqual("Hello Paket", viewModel.Title);
        }
    }
}