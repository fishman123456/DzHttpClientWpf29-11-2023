using System.Net.Http;
using System.Windows;
using System.Windows.Controls;

namespace DzHttpClientWpf29_11_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        // установить программу postman ---- 28-11-2023
        // // 1.создание http - клиента
        //HttpClient httpClient = new HttpClient();
        // // 2.выполнение запроса
        // HttpResponseMessage respons = await httpClient.GetAsync("http://numbersapi.com/random");
        // // 3. считать
        // string responsBody =  await respons.Content.ReadAsStringAsync();
        // Console.WriteLine(responsBody);
        //HttpClient httpClient = new HttpClient();

        private void ButtGet_Click(object sender, RoutedEventArgs e)
        {
            TextBoxDataHttp.Text = "gdfgdsdsg";
           // Thread.Sleep(1000);
            TextBoxDataHttp.Text = string.Empty;
        }
        // HttpResponseMessage respons = httpClient.GetAsync($"http://numbersapi.com/{10}");
        //string responsBody = Respons.Content.ReadAsStringAsync();







        //   Console.WriteLine(responsBody);
        //Console.WriteLine($"Код ответа: {(int)respons.StatusCode}");
    }
}