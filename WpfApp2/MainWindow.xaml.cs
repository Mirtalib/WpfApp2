using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Veiw;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private List<Message> messages = new List<Message>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // txtBoxMessage

            messages.Add(new Message(txtBoxMessage.Text, DateTime.Now));

            Message  message = new Message(txtBoxMessage.Text, DateTime.Now);

            listView.ItemsSource = null;
            listView.ItemsSource = messages;
            txtBoxMessage.Text = null;
        }

    }
}
