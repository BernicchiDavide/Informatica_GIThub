namespace Prova_strumenti
{
    public partial class Form1 : Form
    {
        int n = 0;
        int Cal1 = 0;
        int Cal2 = 0;
        int ris = 0;
        bool loona = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_utente = txtBoxNome.Text;
            lblSluti.Text = $"ciao {nome_utente}!";
        }

        private void pulisci_Click(object sender, EventArgs e)
        {
            string nome_utente = " ";
            lblSluti.Text = nome_utente;
            txtBoxNome.Text = nome_utente;
        }

        private void btmConti_Click(object sender, EventArgs e)
        {
            n++;
            lblConta.Text = n.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            n--;
            lblConta.Text = n.ToString();
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "1";

                loona = true;
            }
            else
            {
                lblN1.Text = "1";
            }
        }
        private void btm2_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "2";
                loona = true;
            }
            else
            {
                lblN1.Text = "2";
            }
        }

        private void btm3_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "3";
                loona = true;
            }
            else
            {
                lblN2.Text = "3";
            }
        }

        private void btm4_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "4";
                loona = true;
            }
            else
            {
                lblN2.Text = "4";
            }
        }

        private void btm5_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "5";
                loona = true;
            }
            else
            {
                lblN2.Text = "5";
            }
        }

        private void btm6_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "6";
                loona = true;
            }
            else
            {
                lblN2.Text = "6";
            }
        }

        private void btm7_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "7";
                loona = true;
            }
            else
            {
                lblN2.Text = "7";
            }
        }

        private void btm8_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN1.Text = "8";
                loona = true;
            }
            else
            {
                lblN2.Text = "8";
            }
        }

        private void btm9_Click(object sender, EventArgs e)
        {
            if (loona == false)
            {
                lblN2.Text = "9";
                loona = true;
            }
            else
            {
                lblN2.Text = "9";
            }
        }

        private void btm0_Click(object sender, EventArgs e)
        {
            if (loona == false  )
            {
                lblN1.Text = "0";
                loona = true;
            }
            else
            {
                lblN2.Text = "0";
            }
        }

        private void btmPiu_Click(object sender, EventArgs e)
        {
            lblOperazione.Text = "+";

        }

        private void btmMeno_Click(object sender, EventArgs e)
        {
            lblOperazione.Text = "-";

        }

        private void btmUguale_Click(object sender, EventArgs e)
        {
            if (lblOperazione.Text == "+")
            {
                Cal1 = int.Parse(lblN1.Text);
                Cal2 = int.Parse(lblN2.Text);
                ris = Cal1 + Cal2;
                txtRis.Text = ris.ToString();
            }
            else if (lblOperazione.Text == "-")
            {
                Cal1 = int.Parse(lblN1.Text);
                Cal2 = int.Parse(lblN2.Text);
                ris = Cal1 - Cal2;
                txtRis.Text = ris.ToString();
            }
        }
    }
}
