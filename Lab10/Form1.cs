using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationTokenSource _hashCancellationTokenSource;
        private CancellationTokenSource _streamCipherCancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonEncrypt_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            await Task.Run(() => EncryptWithCRABInLoop("Ukraine", _cancellationTokenSource.Token));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }

        private async void buttonHash_Click(object sender, EventArgs e)
        {
            _hashCancellationTokenSource = new CancellationTokenSource();
            await Task.Run(() => ComputeHashInLoop(_hashCancellationTokenSource.Token));
        }

        private void buttonHashStop_Click(object sender, EventArgs e)
        {
            _hashCancellationTokenSource?.Cancel();
        }

        private void buttonMaurerStop_Click(object sender, EventArgs e)
        {
            _streamCipherCancellationTokenSource?.Cancel();
        }

        private async void buttonStreamCipher_Click(object sender, EventArgs e)
        {
            _streamCipherCancellationTokenSource = new CancellationTokenSource();
            await Task.Run(() => OtherCryptoMethodsInLoop(_streamCipherCancellationTokenSource.Token));
        }

        private void buttonStreamCipherStop_Click(object sender, EventArgs e)
        {
            _streamCipherCancellationTokenSource?.Cancel();
        }


        private void EncryptWithCRABInLoop(string plainText, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                string key = GenerateRandomKey();

                string encrypted = EncryptWithCRAB(plainText, key);
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBoxCRABResult.AppendText($"Encrypted: {encrypted}\n");
                });
                Thread.Sleep(1000); // Delay 1 second
            }
        }

        private void ComputeHashInLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                string input = GenerateRandomInput();  // Згенерувати новий ввід для хешування
                string hash = ComputeHash(input);
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBoxHashResult.AppendText($"Hash: {hash}\n");
                });
                Thread.Sleep(1000); // Delay 1 second
            }
        }

        private void OtherCryptoMethodsInLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                string result = OtherCryptoMethods();
                this.Invoke((MethodInvoker)delegate
                {
                    richTextBoxStreamCipherResult.AppendText($"{result}\n");
                });
                Thread.Sleep(1000); // Delay 1 second
            }
        }

        private string GenerateRandomKey()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder key = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 16; i++) // Key size is 16 characters
            {
                key.Append(chars[random.Next(chars.Length)]);
            }
            return key.ToString();
        }

        private string EncryptWithCRAB(string plainText, string key)
        {
            char[] keyChars = key.ToCharArray();
            char[] inputChars = plainText.ToCharArray();
            char[] outputChars = new char[inputChars.Length];

            for (int i = 0; i < inputChars.Length; i++)
            {
                outputChars[i] = (char)(inputChars[i] ^ keyChars[i % keyChars.Length]);
            }

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(outputChars));
        }

        private string ComputeHash(string input)
        {
            using (RIPEMD160 ripeMd = RIPEMD160.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = ripeMd.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private string OtherCryptoMethods()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomNumber = new byte[32];
            rng.GetBytes(randomNumber);
            string randomString = Convert.ToBase64String(randomNumber);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes("RSA Encryption Example");
                byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);
                string encryptedString = Convert.ToBase64String(encryptedData);

                return $"Random Number: {randomString}\nRSA Encrypted: {encryptedString}";
            }
        }

        private string GenerateRandomInput()
        {
            // Згенерувати випадковий рядок для хешування
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder input = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 16; i++) // Розмір введення - 16 символів
            {
                input.Append(chars[random.Next(chars.Length)]);
            }
            return input.ToString();
        }
    }
}
