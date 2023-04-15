using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking
{
    public partial class cfinal : Form
    {
        public int slotid;
        public List<domins> addeddata { get; set; }
        public cfinal(List<domins> datalist, int slotId)
        {
            

            InitializeComponent();
            slotid = slotId;
            addeddata = datalist;
            fcok.Enabled = false;
        }
    
        private void cfinal_Load(object sender, EventArgs e)
        {
            time.Text = System.DateTime.Now.TimeOfDay.ToString();
        }

        private void fcok_Click(object sender, EventArgs e)
        {
            
            domins d = new domins();
            d.time = time.Text;
            d.vehiceNumber = maskedTextBox1.Text;
            if (radioButton1.Checked)
            {
                d.type = "car";
            }
            else if (radioButton2.Checked)
            {
                d.type = "bike";
            }
           
            d.prkingId = slotid;
            addeddata.Add(d);
            
            DialogResult m =  MessageBox.Show("Please Proceed To Parking Lot No...:" + d.prkingId,"Thank You",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            if (m == DialogResult.OK)
            {
                Cmap cpm = new Cmap(addeddata);               
                this.Close();
                cpm.ShowDialog();
            }
        }
        
    
        private void time_TextChanged(object sender, EventArgs e)
        {
                  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel(object sender, EventArgs e)
        {
            Cmap cmp = new Cmap(addeddata);
            this.Close();
            cmp.ShowDialog(); 
        }

     



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fcok.Enabled = true;
            }
            else
            {
                fcok.Enabled = false;
            }
        }

       
    }
}
