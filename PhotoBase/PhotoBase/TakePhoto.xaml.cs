using PhotoBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhotoBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TakePhoto : ContentPage
    {
        readonly ProjectPhoto im;
        public TakePhoto(ProjectPhoto im)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.im = im;
            name.Text = im.Name;
            img.Source = im.Imagepath;
        }
    }
}