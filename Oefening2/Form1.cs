using Opdracht2;
using System.Media;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_laat_horen_Click(object sender, EventArgs e)
        {
            Koe eersteKoe = new Koe();
            Slang eersteSlang = new Slang();
            Varken eersteVarken = new Varken();

            if (cb_koe.Checked)
            {
                MessageBox.Show(eersteKoe.Zegt());
            } else if (cb_slang.Checked)
            {
                MessageBox.Show(eersteSlang.Zegt());
            } else if (cb_varken.Checked)
            {
                MessageBox.Show(eersteVarken.Zegt());
            }

        }
    }
}