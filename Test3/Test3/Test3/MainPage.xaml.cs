using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3{
	public partial class MainPage : ContentPage{
        public const string someText = "Hello";
		public MainPage(){

            /*Стек элементов*/
            /*Label label1 = new Label()
            {
                Text = "Первая метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Red
            };
            Label label2 = new Label()
            {
                Text = "Вторая метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Blue
            };
            Label label3 = new Label()
            {
                Text = "Третья метка",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.Green
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, label3 }
            };
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.Spacing = 8;
            this.Content = stackLayout;*/

            /*Установка вложеных элементов в С#*/
            /*Label label1 = new Label() { Text = "Первая метка" };
            Label label2 = new Label() { Text = "Вторая метка" };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2 }
            };

            this.Content = stackLayout;*/

            InitializeComponent();
        }

        /*Обработка нажатия*/
        private void Button_Click(){
            button1.Text = "Нажато!!!";
            photo.Source = "https://news.fergananews.com/photos/2012/10/bars.jpg";
            firstCell.Text = "Shut";
            secondCell.Text = "the";
            thirdCell.Text = "fuck";
            fourthCell.Text = "UP!";
        }
    }

    /*КЛасс для установки цвета*/
    public class color : IMarkupExtension{
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(Red, Green, Blue, Alpha);
        }
    }
}
