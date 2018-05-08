using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.MyExtensions
{
    class EmbeddedImage : IMarkupExtension
    {

        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(ResourceId);
        }
    }
}
