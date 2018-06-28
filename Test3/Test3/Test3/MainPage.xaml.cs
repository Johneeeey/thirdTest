using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test3{
	public partial class MainPage : ContentPage{
        //Label label; //перменная для обработки DatePicker`a
        //Label header;//Переменные для
        // Picker pickeR;//обработки picker`a  
        Label actionLabel;//для всплывающего окна
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

            /*всплыввающее окно*/
            /*Button alertButton = new Button
            {
                Text = "Alert",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center
            };
            alertButton.Clicked += AlertButton_Clicked;

            Content = alertButton;*/

            /*Всплывающее окно с выбором ряда действий*/
            /*Button alertButton = new Button { Text = "Alert" };
            alertButton.Clicked += AlertButton_Clicked;
            actionLabel = new Label();//что это?
            Content = new StackLayout { Children = { alertButton, actionLabel } };//что это?*/
        }

        /*обработка DatePicker`a*/
        /*private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if (label != null)
                label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }/*

        /*Обработка нажатия*/

        /*Обработка нажатия на кнопку*/
        /*private void Button_Click(){
            button1.Text = "Нажато!!!";
            photo.Source = "https://news.fergananews.com/photos/2012/10/bars.jpg";
        }*/

        /*Обработка Picker`a (ошибка необработаннго исключения)*/
        /* void picker_SelectedIndexChanged(object sender, EventArgs e){
             header.Text = "Вы выбрали: " + pickeR.Items[pickeR.SelectedIndex];
         }*/

        /*Обработка степпера*/
        /*private void OnStepperValueChanged(object sender, ValueChangedEventArgs e){
            if (header != null)
                header.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }*/

        /*Обработка слайдера*/
        /*void OnValueChanged(object sender, ValueChangedEventArgs e){
            if (header != null)
                header.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }*/

        /*обработка переключателя*/
        /*private void switcher_Toggled(object sender, ToggledEventArgs e){
            label.Text = String.Format("Значение {0}", e.Value);
        }*/

        /*Обработка webViewButtom(Не работает)*/
        /*void button_Clicked(object sender, EventArgs e){
            //webView.Source = new UrlWebViewSource { Url = urlEntry.Text };
            // или так
             webView.Source = urlEntry.Text;
        }*/

        /*Обработчик для всплывающего окна Display Alert*/
        /*private void AlertButton_Clicked(object sender, EventArgs e){
            DisplayAlert("Уведомление", "Пришло новое сообщение", "ОK");
        }*/

        /*Предоставление выбора при всплюывающем окне*/
        /*private async void AlertButton_Clicked(object sender, EventArgs e){
            bool result = await DisplayAlert("Подтвердить действие", "Вы хотите удалить элемент?", "Да", "Нет");
            await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Удалить" : "Отменить"), "OK");
        }*/

        /*Всплывающее окно с выбором ряда действий*/
        /*private async void AlertButton_Clicked(object sender, EventArgs e){
            var action = await DisplayActionSheet("Поделиться", "Отмена", "Удалить", "Вконтакте", "Твиттер", "Фейсбук");
            actionLabel.Text = action;
        }*/
        
        /*Обработка нажатия кнопки с ресурсом*/
        /*private void click(object sender, EventArgs e){
            clickButton.BackgroundColor = Color.Gray;
            clickButton.Text = "Нажато";
        }*/
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
