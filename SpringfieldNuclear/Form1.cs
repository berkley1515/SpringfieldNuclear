using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnableReactors_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
            player.Play();
            
            //changing colours (flashing)
            ReactorStatus.BackColor = Color.Red;
            ReactorStatus.Text = "Reactor Overheating";
            EnableReactors.BackColor = Color.Red;
            EnableReactors.Text = "Disable Reactors";
            ReactorStatus.BackColor = Color.White;
            EnableReactors.BackColor = Color.White;
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            ReactorStatus.BackColor = Color.Red;
            EnableReactors.BackColor = Color.Red;
            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            ReactorStatus.BackColor = Color.White;
            EnableReactors.BackColor = Color.White;
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            ReactorStatus.BackColor = Color.Red;
            EnableReactors.BackColor = Color.Red;
            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            ReactorStatus.BackColor = Color.White;
            EnableReactors.BackColor = Color.White;
            Reactor1.BackColor = Color.Red;
            Reactor2.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            ReactorStatus.BackColor = Color.Red;
            EnableReactors.BackColor = Color.Red;
            Reactor1.BackColor = Color.White;
            Reactor2.BackColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

        }

        private void Reactor1_Click(object sender, EventArgs e)
        {

        }
    }
}
