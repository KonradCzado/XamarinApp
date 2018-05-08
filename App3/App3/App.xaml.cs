using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
            
            MainPage = new App3.Messages();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey("NotificationsEnabled"))
                    return (bool)Properties["NotificationsEnabled"];
                return false;
            }
            set
            {
                Properties["NotificationsEnabled"] = value;
            }
        }

        public string Country
        {
            get
            {
                if (Properties.ContainsKey("Country"))
                    return Properties["Country"].ToString();
                return "";
            }
            set
            {
                Properties["Country"] = value;
            }
        }
    }
}
