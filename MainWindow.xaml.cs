using System.Net.Http;
using System.Security.Cryptography;
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
        private const string CertificateUrl = "https://github.com/tago-dev/CertInstallerNreams/raw/refs/heads/master/acessointernet-celepar.cer";
        private static readonly HttpClient httpClient = new HttpClient();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task InstallCertificateAsync()
        {
            StatusLabel.Foreground = Brushes.Blue;
            StatusLabel.Content = "Baixando e instalando o certificado...";

            try
            {
                byte[] certificateBytes = await httpClient.GetByteArrayAsync(CertificateUrl);

                var certificate = new X509Certificate2(certificateBytes);

                using (var store = new X509Store(StoreName.Root, StoreLocation.CurrentUser))
                {
                    store.Open(OpenFlags.ReadWrite);
                    store.Add(certificate);
                }

                StatusLabel.Foreground = Brushes.Green;
                StatusLabel.Content = "Certificado instalado com sucesso!";
                MessageBox.Show(
                    "O certificado de rede foi baixado e instalado com sucesso.\nReinicie o navegador para que as alterações tenham efeito.",
                    "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (HttpRequestException ex)
            {
                StatusLabel.Foreground = Brushes.Red;
                StatusLabel.Content = "Falha ao baixar o certificado.";
                MessageBox.Show($"Erro de rede: {ex.Message}\nVerifique sua conexão com a internet.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CryptographicException ex)
            {
                StatusLabel.Foreground = Brushes.Red;
                StatusLabel.Content = "Falha ao instalar o certificado.";
                MessageBox.Show($"Erro ao instalar o certificado: {ex.Message}\nExecute o programa como administrador.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                StatusLabel.Foreground = Brushes.Red;
                StatusLabel.Content = "Falha na operação.";
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            InstallButton.IsEnabled = false;
            try
            {
                await InstallCertificateAsync();
            }
            finally
            {
                InstallButton.IsEnabled = true;
            }
        }
    }
}