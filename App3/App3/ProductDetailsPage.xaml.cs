using App3.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPage : ContentPage
    {


        public ProductDetailsPage(ProductViewModel product)
        {
            InitializeComponent();
            if (product.ImageToDisplay != null)
            {
                Stream stream = new MemoryStream(product.ImageToDisplay);
                image.Source = ImageSource.FromStream(() => stream);


            }
            BindingContext = product;

        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}