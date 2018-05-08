using App3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static App3.ProductsPage;

namespace App3.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private int _id;
        private string _name;
        private int _amount;
        private decimal _price;
        private string _image;
        private byte[] _imageToDisplay;
        private Producer _producer;

        public int ID
        {
            get { return _id; }
            set { SetValue(ref _id, value); }
        }
        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }
        public int Amount
        {
            get { return _amount; }
            set { SetValue(ref _amount, value); }
        }
        public decimal Price
        {
            get { return _price; }
            set { SetValue(ref _price, value); }
        }
        public string Image
        {
            get { return _image; }
            set { SetValue(ref _image, value); }
        }
        public byte[] ImageToDisplay
        {
            get { return _imageToDisplay; }
            set { SetValue(ref _imageToDisplay, value); }
        }
        public Producer Producer
        {
            get { return _producer; }
            set { SetValue(ref _producer, value); }
        }
    }
}
