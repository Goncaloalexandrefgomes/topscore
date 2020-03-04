using System;
using System.Drawing;
using System.Windows.Forms;

namespace topscore.Classes
{
    class mover
    {
        private bool _start = false;
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
    }
}
