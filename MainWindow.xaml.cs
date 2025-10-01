using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Serialization;

namespace CertInstallerNreams
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Certificate Files (*.cer;*.crt;*.pem;*.pfx)|*.cer;*.crt;*.pem;*.pfx|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                // Mostrar o caminho do arquivo selecionado na TextBox
                CertificatePathTextBox.Text = openFileDialog.FileName;
                StatusLabel.Content = "";
            }
        }

        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            string certPath = CertificatePathTextBox.Text;

            if (string.IsNullOrWhiteSpace(certPath))
            {
                StatusLabel.Content = "Por favor selecione um arquivo de certificado '.cer' !";
                return;
            }

            try
            {
                // **MUDANÇA CRUCIAL**
                // Carrega o certificado público, sem senha.
                X509Certificate2 certificate = new X509Certificate2(certPath);

                // **MUDANÇA CRUCIAL**
                // Abre a loja "Autoridades de Certificação Raiz Confiáveis" (Root).
                X509Store store = new X509Store(StoreName.Root, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadWrite);

                store.Add(certificate);
                store.Close();

                StatusLabel.Foreground = Brushes.Green;
                StatusLabel.Content = "Certificado instalado com sucesso!";
                MessageBox.Show("O certificado raiz foi instalado com sucesso.\nReinicie o navegador para que as alterações tenham efeito.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                StatusLabel.Foreground = Brushes.Red;
                StatusLabel.Content = "Falha na instalação.";
                MessageBox.Show($"Ocorreu um erro: {ex.Message}\n\nLembre-se de executar o programa como administrador.", "Erro de Instalação", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}