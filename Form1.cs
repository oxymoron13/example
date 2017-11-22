using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            plain_text.Text = "RSA (аббревиатура от фамилий Rivest, Shamir и Adleman) — криптографический алгоритм с открытым ключом, основывающийся на вычислительной сложности задачи факторизации больших целых чисел.\nКриптосистема RSA стала первой системой, пригодной и для шифрования, и для цифровой подписи. Алгоритм используется в большом числе криптографических приложений, включая PGP, S/MIME, TLS/SSL, IPSEC/IKE и других.";
            get_p.Text = "23";
            get_q.Text = "43";
        }
  

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (plain_text.Text == String.Empty)
                {
                    throw new Exception("Введите текст для шифрования.");
                }
                long p, q;
                if (!Int64.TryParse(get_p.Text, out p) || !Int64.TryParse(get_q.Text, out q))
                {
                    throw new Exception("Введите простые числа.");
                }
                if (!p.Prime() || !q.Prime())
                {
                    throw new Exception("Модуль должен состоять из двух простых чисел.");
                }
                long open_exp = RSA.create_open_exp(p, q);
                encrypted_text.Text = RSA.Encode(open_exp, p * q, plain_text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (encrypted_text.Text == String.Empty)
                {
                    throw new Exception("Введите текст для дешифрования.");
                }
                long p, q;
                if (!Int64.TryParse(get_p.Text, out p) || !Int64.TryParse(get_q.Text, out q))
                {
                    throw new Exception("Введите простые числа.");
                }
                if (!p.Prime() || !q.Prime())
                {
                    throw new Exception("Модуль должен состоять из двух простых чисел.");
                }
                long open_exp = RSA.create_open_exp(p, q);
                long secret_exp = RSA.ModPow(1, (p - 1) * (q - 1), open_exp) + (p - 1) * (q - 1);
                decrypted_text.Text = RSA.Decode(secret_exp, p * q, encrypted_text.Text);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void set_data_Click(object sender, EventArgs e)
        {
            encrypted_text.ResetText();
            decrypted_text.ResetText();
            try
            {
                long p, q;
                if (!Int64.TryParse(get_p.Text, out p) || !Int64.TryParse(get_q.Text, out q))
                {
                    throw new Exception("Введите простые числа.");
                }
                if (!p.Prime() || !q.Prime())
                {
                    throw new Exception("Модуль должен состоять из двух простых чисел.");
                }
                long module = p * q;
                long open_exp = RSA.create_open_exp(p, q);
                long secret_exp = RSA.ModPow(1, (p - 1) * (q - 1), open_exp) + (p - 1) * (q - 1);
                show_module.Text = module.ToString();
                show_open_exp.Text = open_exp.ToString();
                show_secret_exp.Text = (secret_exp/open_exp).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
