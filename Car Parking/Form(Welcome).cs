using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Parking
{
    public partial class welcome : Form
    {
        
        public welcome()
        {
            InitializeComponent();
            this.label1.BackColor = System.Drawing.Color.Transparent;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enter(object sender, EventArgs e)
        {
            Cmap pm = new Cmap();
            this.Hide();
            pm.Show();
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do You Really Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes) { System.Environment.Exit(0); }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Mini Software Is designed For Billing and Maintaining and keep record of Vehicle Flow In Small Parking Lots.\n\nCreated By Alabama Technologies Llc \n\nDevelopers: Muhammad Ahsan,Osama Shafqat.\n\nPublished On.:1/1/2020.\n\nVersion..:1.2.2.4\nAll Rights Reserved 1997-20.", "Info", MessageBoxButtons.OK);
        }



        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void close(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
            
        }
    }
}
