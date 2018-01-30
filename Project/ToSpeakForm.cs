using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Speaker
{
    public partial class ToSpeakForm : Form
    {
        public ToSpeakForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {

        }
        private void SayText()
        {
            Speak.Say(textBox1.Text);
        }

        private void buttonSayIt_Click(object sender, EventArgs e)
        {
            SayText();
        }
    }
}
