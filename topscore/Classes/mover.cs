using System;
using System.Drawing;
using System.Windows.Forms;

namespace topscore.Classes
{
    class mover
    {
        private bool _start = true;
        private bool Start => _start;

        public void Mover(object sender)
        {
            Random r = new Random();
            int _x = int.Parse(r.Next(500).ToString());
            int _y = int.Parse(r.Next(250).ToString()) + 100;
            Point pt = new Point(_x, _y);

            Button btn = (Button)sender;
            btn.Location = pt;
        }

        public string Tempo(string tempo)
        {
            int _tempo = Convert.ToInt32(tempo);
            if (_tempo > 0) _tempo--; else _start = false;
            return _tempo.ToString();
        }

        public void Record(object pontos, object record)
        {
            TextBox _pontos = (TextBox)pontos;
            TextBox _record = (TextBox)record;

            int _rec = Convert.ToInt32(_record.Text);
            int _pts = Convert.ToInt32(_pontos.Text);
            if (_rec < _pts) _record.Text = _pontos.Text;
        }

        public void Pontos(object sender)
        {
            TextBox _pontos1 = (TextBox)sender;
            _pontos1.Text = (Convert.ToInt32(_pontos1.Text) + 1).ToString();
        }
    }
}
