using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana07
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;
            btn10.Clicked += Btn10_Clicked;
            btn11.Clicked += Btn11_Clicked;
            btn12.Clicked += Btn12_Clicked;
            btn13.Clicked += Btn13_Clicked;
        }

        private void Btn13_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new InheritanceDemo());
        }

        private void Btn12_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new InheritanceCode());
        }

        private void Btn11_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ImplicitDemo());
        }

        private void Btn10_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ImplicitControlDemo());
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ImplicitCode());
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new GlobalDemo());
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ExplicitDemo());
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ExplicitControlDemo());
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ExplicitControlCode());
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ExplicitCode());
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DynamicDemo());
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new DynamicCode());
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ClassDemo());
        }
    }
}