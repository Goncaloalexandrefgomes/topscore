using System;
using System.Windows.Forms;
using topscore.Classes;

namespace topscore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private mover Classe = new mover();

        private void Alvo_Click(object sender, EventArgs e)
        {
            pontos.Text = (Convert.ToInt32(pontos.Text) + 1).ToString();
            Classe.Mover(sender);
        }

        private void Start()
        {
            button1.Text = "STOP";
            tempo.Text = "10";
            alvo.Visible = true;
            timer1.Start();
            pontos.Text = "0";
        }

        private void Stop()
        {
            button1.Text = "START!";
            timer1.Stop();
            alvo.Visible = false;
            if (Convert.ToInt32(record.Text) < Convert.ToInt32(pontos.Text))
                record.Text = pontos.Text;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            int _tempo = Convert.ToInt32(tempo.Text);
            if (_tempo < 1) Stop();
            else
            {
                _tempo--;
            }
            tempo.Text = _tempo.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START!") Start();
            else Stop();
        }
    }
}
