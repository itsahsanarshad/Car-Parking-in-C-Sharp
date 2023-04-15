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
using System.Diagnostics;


namespace Car_Parking
{
    public partial class Cmap : Form
    {
        
        public List<domins> getData = new List<domins>();
        
        public Cmap()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.StandardDoubleClick ,true);
            this.SetStyle(ControlStyles.StandardClick, true);
            this.UpdateStyles();
            label3.Text = "0";
            label4.Text = "12";
            
        }
        string sym;


        public Cmap(List<domins> data) {
            getData = data;
            InitializeComponent();
            this.SetStyle(ControlStyles.StandardDoubleClick, true);
            this.SetStyle(ControlStyles.StandardClick, true);
            this.UpdateStyles();
        }
        

        private void Cmap_Load(object sender, EventArgs e)
        {

            label3.Text = "0";
            label4.Text = "12";
            pc1.Image = (getData.Where(x => x.prkingId == 1).Any()) ? pc1.Image = Car_Parking.Properties.Resources.Car : null;
            pc2.Image = (getData.Where(x => x.prkingId == 2).Any()) ? pc2.Image = Car_Parking.Properties.Resources.Car: null;
            pc3.Image = (getData.Where(x => x.prkingId == 3).Any()) ? pc3.Image = Car_Parking.Properties.Resources.Car: null;
            pc4.Image = (getData.Where(x => x.prkingId == 4).Any()) ? pc4.Image = Car_Parking.Properties.Resources.Car: null;
            pc5.Image = (getData.Where(x => x.prkingId == 5).Any()) ? pc5.Image = Car_Parking.Properties.Resources.Car: null;
            pc6.Image = (getData.Where(x => x.prkingId == 6).Any()) ? pc6.Image = Car_Parking.Properties.Resources.Car: null;
            pc7.Image = (getData.Where(x => x.prkingId == 7).Any()) ? pc7.Image = Car_Parking.Properties.Resources.Car: null;
            pc8.Image = (getData.Where(x => x.prkingId == 8).Any()) ? pc8.Image = Car_Parking.Properties.Resources.Car: null;
            pc9.Image = (getData.Where(x => x.prkingId == 9).Any()) ? pc9.Image = Car_Parking.Properties.Resources.Car: null;
            pc10.Image = (getData.Where(x => x.prkingId == 10).Any()) ? pc10.Image = Car_Parking.Properties.Resources.Car: null;
            pc11.Image = (getData.Where(x => x.prkingId == 11).Any()) ? pc11.Image = Car_Parking.Properties.Resources.Car: null;
            pc12.Image = (getData.Where(x => x.prkingId == 12).Any()) ? pc12.Image = Car_Parking.Properties.Resources.Car: null;
            if (getData.Where(x => x.prkingId == 1).Any())
            {
                var q = getData.Where(x => x.prkingId == 1).FirstOrDefault();
                tb1.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 2).Any())
            {
                var q = getData.Where(x => x.prkingId == 2).FirstOrDefault();
                tb2.Text = q.vehiceNumber;

            }
            if (getData.Where(x => x.prkingId == 3).Any())
            {
                var q = getData.Where(x => x.prkingId == 3).FirstOrDefault();
                tb3.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 4).Any())
            {
                var q = getData.Where(x => x.prkingId == 4).FirstOrDefault();
                tb4.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 5).Any())
            {
                var q = getData.Where(x => x.prkingId == 5).FirstOrDefault();
                tb5.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 6).Any())
            {
                var q = getData.Where(x => x.prkingId == 6).FirstOrDefault();
                tb6.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 7).Any())
            {
                var q = getData.Where(x => x.prkingId == 7).FirstOrDefault();
                tb7.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 8).Any())
            {
                var q = getData.Where(x => x.prkingId == 8).FirstOrDefault();
                tb8.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 9).Any())
            {
                var q = getData.Where(x => x.prkingId == 9).FirstOrDefault();
                tb9.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 10).Any())
            {
                var q = getData.Where(x => x.prkingId == 10).FirstOrDefault();
                tb10.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 11).Any())
            {
                var q = getData.Where(x => x.prkingId == 11).FirstOrDefault();
                tb11.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 12).Any())
            {
                var q = getData.Where(x => x.prkingId == 12).FirstOrDefault();
                tb12.Text = q.vehiceNumber;
            }
            if (getData.Where(x => x.prkingId == 1).Any())
            {
                
                var q = getData.Where(x => x.prkingId == 1).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text)+1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 2).Any())
            {

                var q = getData.Where(x => x.prkingId == 2).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 3).Any())
            {

                var q = getData.Where(x => x.prkingId == 3).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 4).Any())
            {

                var q = getData.Where(x => x.prkingId == 4).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";

                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 5).Any())
            {

                var q = getData.Where(x => x.prkingId == 5).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 6).Any())
            {

                var q = getData.Where(x => x.prkingId == 6).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 7).Any())
            {

                var q = getData.Where(x => x.prkingId == 7).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 8).Any())
            {

                var q = getData.Where(x => x.prkingId == 8).FirstOrDefault();
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
            }
            if (getData.Where(x => x.prkingId == 9).Any())
            {

                var q = getData.Where(x => x.prkingId == 9).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 10).Any())
            {

                var q = getData.Where(x => x.prkingId == 10).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 11).Any())
            {

                var q = getData.Where(x => x.prkingId == 11).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
            if (getData.Where(x => x.prkingId == 12).Any())
            {

                var q = getData.Where(x => x.prkingId == 12).FirstOrDefault();
                label3.Text = $"{Convert.ToInt32(label3.Text) + 1}";
                label4.Text = $"{Convert.ToInt32(label4.Text) - 1}";
            }
        }
         

        private void pkc1(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 1).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 1).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:"+q.prkingId
                        +"\n\nVehicle Number is..:"+q.vehiceNumber+       
                        "\n\nVehicle Type is...:"+q.type+   
                        "\n\nEntry Time is...: "+hourin.ToString()+   
                        "\n\nExit Time is..:"+hourout.ToString()+    
                        "\n\nTotal Time (In Minutes)..:"+totaltime.ToString()+ 
                        "\n\nYour Total Parking Fee is Rs."+sym+result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!","Exit Park Lot" );
                    if (result1 == DialogResult.OK) 
                    {
                        
                      getData.Remove(q);
                        pc1.Image = null; 
                        tb1.Text = null;
                        label3.Text = $"{Convert.ToInt32(label3.Text)-1}";
                        label4.Text = $"{Convert.ToInt32(label4.Text) + 1}";
                        using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:"+q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." +sym+ result.ToString()) ;
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 1);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc2(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 2).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 2).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc2.Image = null; tb2.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 2);
                this.Hide();
                fs.Show();
            }

        }

        private void pkc3(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 3).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 3).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc3.Image = null; tb3.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 3);
                this.Hide();
                fs.Show();
            }

        }

        private void pkc4(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 4).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 4).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc4.Image = null; tb4.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 4);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc5(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 5).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 5).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc5.Image = null; tb5.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 5);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc6(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 6).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 6).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc6.Image = null; tb6.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 6);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc7(object sender, EventArgs e)
        {
                    }

        private void pkc8(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 8).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 8).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc8.Image = null; tb8.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 8);
                this.Hide();
                fs.Show();
            }

        }

        private void pkc9(object sender, EventArgs e)
        {

            if (getData.Where(x => x.prkingId == 9).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 9).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc9.Image = null; tb9.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 9);
                this.Hide();
                fs.Show();
            }

        }

        private void pkc10(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 10).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 10).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc10.Image = null; tb10.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 10);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc11(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 11).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 11).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc11.Image = null; tb11.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 11);
                this.Hide();
                fs.Show();
            }
        }

        private void pkc12(object sender, EventArgs e)
        {
            if (getData.Where(x => x.prkingId == 12).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 12).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK) { getData.Remove(q); pc12.Image = null; tb12.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 12);
                this.Hide();
                fs.Show();
            }
        }

        private void pb1(object sender, EventArgs e)
        {
               
        }

        private void pb2(object sender, EventArgs e)
        {

        }

        private void pb3(object sender, EventArgs e)
        {

        }

        private void pb4(object sender, EventArgs e)
        {

        }

        private void pb5(object sender, EventArgs e)
        {

        }

     

        private void pb8(object sender, EventArgs e)
        {

        }

        private void pb9(object sender, EventArgs e)
        {

        }

        private void pb10(object sender, EventArgs e)
        {

        }

        private void pb11(object sender, EventArgs e)
        {

        }

        private void pb12(object sender, EventArgs e)
        {

        }

        private void pbs7(object sender, MouseEventArgs e)
        {
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void pr1_Click(object sender, EventArgs e)
        {

        }

        private void tbs1(object sender, EventArgs e)
        {
         
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Mini Software Is designed For Billing and Maintaining and Keeping Record of Vehicle Flow In Small Parking Lots.\n\nCreated By Alabama Technologies Llc \n\nDevelopers: Muhammad Ahsan Arshad Manzoor,Osama Shafqat.\n\nPublished On.:1/1/2020.\n\nVersion..:1.2.2.4\n\nAll Rights Reserved 1997-20.", "Info", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Do You Really Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes) { System.Environment.Exit(0); }
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {if (File.Exists("D:\\Log.txt"))

            { Process.Start("notepad.exe", "D:\\Log.txt"); }
          else { MessageBox.Show("No Log File Exists", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        { if (File.Exists("D:\\Log.txt"))
            {
                DialogResult cr = MessageBox.Show("Are You Sure You Want to Clear the Log.", "Clear Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cr == DialogResult.Yes)
                {
                    MessageBox.Show("Log Cleared", "Clear Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Delete("D:\\Log.txt");
                }
            }
            else
            {
                MessageBox.Show("No Log File Exists", "No File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void pkc7(object sender, MouseEventArgs e)
        {
            if (getData.Where(x => x.prkingId == 7).Any())
            {
                DialogResult r = MessageBox.Show("Are you sure you want to depark the car", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    fees f = new fees();
                    var q = getData.Where(x => x.prkingId == 7).FirstOrDefault();
                    var result = f.fee(q.type.ToString(), Convert.ToDateTime(q.time));
                    DateTime hourout;
                    DateTime hourin;
                    Int32 totaltime;
                    hourin = Convert.ToDateTime(q.time);
                    hourout = Convert.ToDateTime(DateTime.Now);
                    totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
                    DialogResult result1 = MessageBox.Show("Description as Follow...:\n\nThe Park Lot No..:" + q.prkingId
                        + "\n\nVehicle Number is..:" + q.vehiceNumber +
                        "\n\nVehicle Type is...:" + q.type +
                        "\n\nEntry Time is...: " + hourin.ToString() +
                        "\n\nExit Time is..:" + hourout.ToString() +
                        "\n\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\n\nYour Total Parking Fee is Rs." + result.ToString() +
                        "\n\nPlease Pay the above mentioned Fee at next Counter.\n\nThank You!!", "Exit Park Lot");
                    if (result1 == DialogResult.OK)
                    {
                        getData.Remove(q); pc7.Image = null; tb7.Text = null; label3.Text = $"{Convert.ToInt32(label3.Text) - 1}"; label4.Text = $"{Convert.ToInt32(label4.Text) + 1}"; using (StreamWriter log = File.AppendText("D:\\Log.txt"))
                        {
                            log.WriteLine("\n\nDescription as Follow...:\nThe Park Lot No..:" + q.prkingId
                        + "\nVehicle Number is..:" + q.vehiceNumber +
                        "\nVehicle Type is...:" + q.type +
                        "\nEntry Time is...: " + hourin.ToString() +
                        "\nExit Time is..:" + hourout.ToString() +
                        "\nTotal Time (In Minutes)..:" + totaltime.ToString() +
                        "\nYour Total Parking Fee is Rs." + result.ToString());
                        }
                    }
                }
            }
            else
            {
                cfinal fs = new cfinal(getData, 7);
                this.Hide();
                fs.Show();
            }

        }



        private void cls(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0); 
        }

        private void lb3(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dol = MessageBox.Show("Do you really Want To Change Currency Symbol To $ ", "Currency", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dol == DialogResult.Yes )
            { sym = "$";}
        }
    }
}
