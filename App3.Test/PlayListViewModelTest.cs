using System;
using System.Collections.ObjectModel;
using App3.ViewModels;

using Moq;
using NUnit.Framework;

namespace App3.Test
{
    [TestFixture()]
    public class PlayListViewModelTest
    {
        private ProductsViewModel _viewModel;
        private Mock<IPageService> _pageService;
        private Mock<IRepository<ObservableCollection<ProductViewModel>>> _repository;


        [SetUp]
        public void SetUp()
        {
            _pageService = new Mock<IPageService>();
            _repository = new Mock<IRepository<ObservableCollection<ProductViewModel>>>();
            _viewModel = new ProductsViewModel(_pageService.Object, _repository.Object);
        }

        [Test()]
        public void SelectProduct_WhenCalled_SholdBeDeselectedAfterExecute()
        {

            ProductViewModel model = new ProductViewModel();
         
            _viewModel.Products.Add(model);
            _viewModel.SelectProductCommand.Execute(model);


            NUnit.Framework.Assert.IsNull(_viewModel.SelectedProduct);
        }
    }
}
