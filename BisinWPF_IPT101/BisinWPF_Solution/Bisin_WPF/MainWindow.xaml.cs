using System.Collections.ObjectModel;
using System.Windows;

namespace MotorcycleCatalog
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Motorcycle> Motorcycles { get; set; } = new ObservableCollection<Motorcycle>();

        public MainWindow()
        {
            InitializeComponent();
            MotorcycleDataGrid.ItemsSource = Motorcycles;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BrandTextBox.Text) ||
                string.IsNullOrWhiteSpace(ModelTextBox.Text) ||
                string.IsNullOrWhiteSpace(ColorTextBox.Text) ||
                string.IsNullOrWhiteSpace(EngineNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(ChassisNumberTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Motorcycles.Add(new Motorcycle
            {
                Brand = BrandTextBox.Text.Trim(),
                Model = ModelTextBox.Text.Trim(),
                Color = ColorTextBox.Text.Trim(),
                EngineNumber = EngineNumberTextBox.Text.Trim(),
                ChassisNumber = ChassisNumberTextBox.Text.Trim()
            });

            BrandTextBox.Clear();
            ModelTextBox.Clear();
            ColorTextBox.Clear();
            EngineNumberTextBox.Clear();
            ChassisNumberTextBox.Clear();

            BrandTextBox.Focus();
        }
    }

    public class Motorcycle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
    }
}
