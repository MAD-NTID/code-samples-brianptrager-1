using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutsAndViews
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<SomeType> SomeTypes = new List<SomeType>();

        public MainPage()
        {
            InitializeComponent();
            Generate();
            this.SomeTypesListView.ItemsSource = SomeTypes;
        }


        void Generate()
        {
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
            SomeTypes.Add(new SomeType { Name = "asdas", Idk = "asdasdasd" });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
