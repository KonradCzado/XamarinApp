using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App3.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<ProductViewModel> Products { get; private set; } = new ObservableCollection<ProductViewModel>();
        private readonly IPageService _pageService;
        private readonly IRepository<ObservableCollection<ProductViewModel>> _repository;

        public ICommand SelectProductCommand { get; private set; }

        public ProductsViewModel(IPageService pageService, IRepository<ObservableCollection<ProductViewModel>>repository)
        {
            _pageService = pageService;
            _repository = repository;

            SelectProductCommand = new Command<ProductViewModel>(async (viewModel) =>  await SelectProduct(viewModel));
            Products = _repository.GetAllItems();
            
        }

        private ProductViewModel _selectedProduct;
        public ProductViewModel SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                SetValue(ref _selectedProduct, value);
            }
        }



        private async Task SelectProduct(ProductViewModel product)
        {
            if (product == null)
                return;
            SelectedProduct = product;
          
            await _pageService.PushAsync(new ProductDetailsPage(product));
            SelectedProduct = null;
        }

       
    }
}
