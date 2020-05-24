
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisSayfası : ContentPage
    {
        public GirisSayfası()
        {
            InitializeComponent();

            image.Source= "https://www.bedayz.com/CustomCss/images/logo.png";
        }

       
    }
}