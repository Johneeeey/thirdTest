using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Test3{
	public partial class MainPage : ContentPage{
        Label label; //перменная для обработки DatePicker`a
        //Label header;//Переменные для
        // Picker pickeR;//обработки picker`a  
        Label actionLabel;//для всплывающего окна
        public const string someText = "Hello";

        /*массив для listView*/
        //public string[] Phones { get; set; }

        /*Свойство Phones, к которому привязан ListView (DataTemplate)*/
        //public ObservableCollection<Phone> Phones { get; set; }
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
            /*Массивы для использования в ListView в xaml*/
            /*Phones = new string[] { "iPhone 8", "Samsung Galaxy S9", "Huawei P10", "LG G6" };
            this.BindingContext = this;*/
            /*string[] phones = new string[] { "iPhone 7", "Samsung Galaxy S8", "Huawei P10", "LG G6", "Дудка" };
            phonesList.ItemsSource = phones;*/

            /*Список для свойства*/
            /*Phones = new ObservableCollection<Phone>{
                new Phone {Title="Galaxy S8", Company="Samsung", Price=48000, ImagePath="picture.jpg" },
                new Phone {Title="Huawei P10", Company="Huawei", Price=35000, ImagePath="picture.jpg" },
                new Phone {Title="HTC U Ultra", Company="HTC", Price=42000, ImagePath="picture.jpg" },
                new Phone {Title="iPhone 7", Company="Apple", Price=52000, ImagePath="picture.jpg" }
            };
            this.BindingContext = this;*/

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
        }*/

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

        /*ОБработка события ItemSelected*/
        /*private void phonesList_ItemSelected(object sender, SelectedItemChangedEventArgs e){
            if (e.SelectedItem != null)
                selected.Text = e.SelectedItem.ToString();
            ((ListView)sender).SelectedItem = null;
        }*/

        /*Обработка события ItemTapped*/
        /*private void PhonesList_ItemTapped(object sender, ItemTappedEventArgs e){
            if (e.Item != null)
                selected.Text = e.Item.ToString();
            ((ListView)sender).SelectedItem = null;
        }*/

        /*Обработчик нажатия на объект списка DataTemplate*/
        /*public async void OnItemTapped(object sender, ItemTappedEventArgs e){
            Phone selectedPhone = e.Item as Phone;
            if (selectedPhone != null)
                await DisplayAlert("Выбранная модель", $"{selectedPhone.Company} - {selectedPhone.Title}", "OK");
        }*/

        // добавление объекта
       /* private void AddItem(object sender, EventArgs e){
            Phones.Add(new Phone { Title = "Galaxy S8", Company = "Samsung", Price = 48000 });
        }*/
        // удаление выделенного объекта
        /*private void RemoveItem(object sender, EventArgs e){
            Phone phone = phonesList.SelectedItem as Phone;
            if (phone != null){
                Phones.Remove(phone);
                phonesList.SelectedItem = null;
            }
        }*/
    }

    /*КЛасс для установки цвета*/
    /*public class color : IMarkupExtension{
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(Red, Green, Blue, Alpha);
        }
    }*/

    /*Класс конвертера значений для DatePicker`a*/
    /*public class DateTimeToLocalDateConverter : IValueConverter{
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture){
             return ((DateTime)value).ToString("dd.MM.yyyy");
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture){
            return DateTime.Now.ToString("dd.MM.yyyy");
        }
    }*/

    /*Ковертер значений для вводимого текста*/
    /*public class StringToColorConverter : IValueConverter{
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture){
            Color color = Color.Black;
            string colorStr = value.ToString().ToLower();
            switch (colorStr){
                case "красный":
                    color = Color.Red;
                    break;
                case "желтый":
                    color = Color.Yellow;
                    break;
                case "зеленый":
                    color = Color.Green;
                    break;
                case "синий":
                    color = Color.Blue;
                    break;
            }
            return color;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture){
            return Color.White;
        }
    }*/

    /*Класс Phone*/
    /*public class Phone{
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
    }*/
}
