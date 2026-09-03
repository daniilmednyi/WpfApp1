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
using System.Xml.Linq;

namespace WpfApp1
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
        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string ageText=txtAge.Text;

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Возраст должен быть числом", "Ошибка");
                return;
            }

            if (string.IsNullOrWhiteSpace(name)||string.IsNullOrWhiteSpace(ageText))
            {
                MessageBox.Show("Поля не заполнены");
                return;
            }
            string gender ="";
            if (genderman.IsChecked == true)
                gender = "Мужской";
            else if (gendergirl.IsChecked == true)
                gender ="Женский";

            string interests = "";
            if (sport.IsChecked == true)
                interests = "Спорт";
            if (musiс.IsChecked == true)
            { if( interests!= "")
                    interests += ",Музыка";
            }    
                
            if (coding.IsChecked == true)
            {
                    if (interests != "")
                        interests += ",Программирование";
                
            }
            if (interests == " ")
                interests ="Не выбрано";

            MessageBox.Show($"Имя: {name}\nВозраст: " +
                $"{age}\nПол: {gender}" +
                $"\nИнтересы: {interests} ");
            
        }
        
    }
}