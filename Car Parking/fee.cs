using System;
namespace Car_Parking 
{ 
    public class fees
    {
	    public float fee (string type,DateTime time)
	    {
            DateTime hourout;
            DateTime hourin;
            string vehicle;
            float charges, minc, maxc, minb, maxb;
            Int32 totaltime;
            vehicle = type;
            hourin = time;
            hourout = Convert.ToDateTime(DateTime.Now);
            totaltime = Convert.ToInt32(hourout.Subtract(hourin).TotalMinutes);
            minc = 3;
            maxc = 6;
            minb = 2;
            maxb = 4;

            if (vehicle == "car")
            {
            if (totaltime <= 60)
                {
                    charges = Convert.ToInt32(totaltime * minc);
                    return charges;
                }
                else if (totaltime > 60)
                {
                    charges = Convert.ToInt32(totaltime * maxc);
                    return charges;
                }
           
            }
            else if (vehicle == "bike")
            {

                if (totaltime <= 60)
                {
                    charges = Convert.ToInt32(totaltime * minb);
                    return charges;                  
                }
                else if (totaltime > 60)
                {
                    charges = Convert.ToInt32(totaltime * maxb);
                    return charges;
                }
            }

            return 0;
        }

    }
}

