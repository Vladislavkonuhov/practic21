using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practic212
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

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Ошибка: Пожалуйста, заполните поля 'Имя' и 'Возраст'!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string gender = rbMale.IsChecked == true ? "Мужской" : "Женский";

            List<string> interests = new List<string>();
            if (cbSport.IsChecked == true) interests.Add("Спорт");
            if (cbMusic.IsChecked == true) interests.Add("Музыка");
            if (cbProg.IsChecked == true) interests.Add("Программирование");

            string interestsResult = interests.Count > 0 ? string.Join(", ", interests) : "Нет интересов";

            string resultMessage = $@"Имя: {txtName.Text}
            Возраст: {txtAge.Text}
            Пол: {gender}
            Интересы: {interestsResult}";

            MessageBox.Show(resultMessage, "Анкета успешно отправлена", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}