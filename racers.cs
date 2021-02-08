using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RaceGameAmrit
{
    public class Car
    {
        private static int StartsPosition;
        private static int RaceLength;
        public PictureBox carPictureBox = null;
        public int Location = 0;
       

        public static int StartPosition1 { get => StartsPosition; set => StartsPosition = value; }
        public static int RacetrackLength1 { get => RaceLength; set => RaceLength = value; }

        // generation across all Bull objects
        public static Random MyRandom = new Random(); //declared random object
        public static bool Run(Car obj)
        {
            int distance = MyRandom.Next(1, 10);
            if (obj.carPictureBox != null)
                obj.MovehorsePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MovehorsePictureBox(-Location); //reset location 
            Location = 0;

        }

        public void MovehorsePictureBox(int distance)
        {
            Point p = carPictureBox.Location;
            p.X += distance;
            carPictureBox.Location = p; //move Cars
        }
    }
}
