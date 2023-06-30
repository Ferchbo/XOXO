namespace XOXO
{
    public partial class Form1 : Form
    {
        private bool _circulo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;
            PTexto((Button)sender);
            CheckResult(((Button)sender).Text);
        }

        private void PTexto(Button btn)
        {
            btn.Text = _circulo ? "O" : "X";
            _circulo = !_circulo;
            btn.Enabled = false;

        }

        private void CheckResult(string jugador)
        {
            bool ganador = false;
            if(!string.IsNullOrEmpty(button1.Text) && button1.Text == button2.Text && button1.Text == button3.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button1.Text) && button1.Text == button5.Text && button1.Text == button9.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button1.Text) && button1.Text == button4.Text && button1.Text == button7.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button2.Text) && button2.Text == button5.Text && button2.Text == button8.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button3.Text) && button3.Text == button6.Text && button3.Text == button9.Text)
            {
                ganador = true;
            }
            
            if (!string.IsNullOrEmpty(button3.Text) && button3.Text == button5.Text && button3.Text == button7.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button4.Text) && button4.Text == button5.Text && button4.Text == button6.Text)
            {
                ganador = true;
            }
            if (!string.IsNullOrEmpty(button7.Text) && button7.Text == button8.Text && button7.Text == button9.Text)
            {
                ganador = true;
            }

            if (ganador)
                Pganador(jugador);
        }

        private void Pganador(string jugador)
        {
            var respuesta = MessageBox.Show($"Jugador {jugador} Ganó!! ¿Quieres jugar otra vez??", "XOXO Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        
                if(respuesta == DialogResult.Yes) 
            {
                Reset();

            
            }
                else
            {
                this.Close();
            }
        }

        private void Reset()
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button3.Text = string.Empty;
            button4.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button7.Text = string.Empty;
            button8.Text = string.Empty;
            button9.Text = string.Empty;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
    }
}