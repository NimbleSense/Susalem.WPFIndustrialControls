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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class SampleData
        {
            public int No { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public DateTime Datetime { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            Datas = Enumerable.Range(1, 200).Select(n => new SampleData
            {
                No = n,
                Id = Guid.NewGuid().ToString(),
                Datetime = DateTime.Now,
                Name = "Data " + n
            }).ToArray();
            dg.ItemsSource = Datas;
        }

        public SampleData[] Datas { get; set; }
    }
}