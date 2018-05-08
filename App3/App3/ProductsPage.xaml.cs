using App3.Models;
using App3.Resources;
using App3.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
   
     

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {



        public ProductsViewModel ViewModel
        {
            get { return BindingContext as ProductsViewModel; }
            set { BindingContext = value; }
        }
       

        public IRepository<ObservableCollection<ProductViewModel>> Repository { get; set; }
        
        

        public ProductsPage()
        {
            InitializeComponent();
          

            Repository = new ProductRepository(true);
            ViewModel = new ProductsViewModel(new PageService(),
                Repository);

        }

        void RefreshEvent(object sender, EventArgs e)
        {
            BindingContext = ViewModel;
        }


        void Item_Selected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ViewModel.SelectProductCommand.Execute(e.SelectedItem);
        }

    }
}