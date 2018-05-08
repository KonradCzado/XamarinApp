using App3.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Messages : ContentPage
	{
		public Messages ()
		{
			InitializeComponent ();
            RestClient client = new RestClient("https://37ab2585.ngrok.io/api/webapi");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/json");
            var result = client.Execute(request);

            var data = JsonConvert.DeserializeObject<ObservableCollection<Message>>(result.Content);
            listView.ItemsSource = data;
            //BindingContext = data;
        }
	}
}