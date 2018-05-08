using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.Internals;

namespace App3.ViewModels
{
    public class ProductRepository : IRepository<ObservableCollection<ProductViewModel>>
    {


        public enum ReturnType
        {
            JSON,
            XML
        }

        private string ResourceURL { get; set; }
        private string ContentHeader { get; set; }
        private Method TypeOfRequest { get; set; }
        private ReturnType ResponseFormat { get; set; }
        private bool HasImages { get; set; }
        private RestClient RestClient { get; set; } = new RestClient();
        private RestRequest Request { get; set; } = new RestRequest();

        public ObservableCollection<ProductViewModel> Products { get; private set; }

        public ProductRepository(bool hasImages = false, Method requestType = Method.GET, 
            ReturnType returnType = ReturnType.JSON, 
            string resourceURL = "https://31a1f95b.ngrok.io/api/products")
        {
            ResourceURL = resourceURL;
            RestClient.BaseUrl = new Uri(ResourceURL);
            TypeOfRequest = requestType;
            ResponseFormat = returnType;
            HasImages = hasImages;

            SetContentHeader(returnType);
        }

        private void SetContentHeader(ReturnType returnType)
        {
            if (returnType == ReturnType.JSON)
                ContentHeader = "application/json";
            else if (returnType == ReturnType.XML)
                ContentHeader = "application/xml";
        }
        
      

        public ObservableCollection<ProductViewModel> GetAllItems()
        {
            Request.AddHeader("content-type", ContentHeader);
            try
            {
                Products = JsonConvert.DeserializeObject<ObservableCollection<ProductViewModel>>
                    (RestClient.Execute(Request).Content);
            }
            catch(JsonSerializationException)
            {
                throw;
            }
             
            if(HasImages)
                Products.ForEach(p => p.ImageToDisplay = Convert.FromBase64String(p.Image));

            return Products;
        }
    }
}
