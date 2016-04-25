using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach1.Model
{
    public class Convoys
    {
        public List<Convoy> convoys = new List<Convoy>();


    }





    public class Convoy
    {
        public Prisoner Convoyed;
        public int SourceCell;
        public int DestinationCell;

        public int ConvoyersRequired;

        public DateTime StartedAt;
        public int MDuration;

        public DateTime FinishedAt
        {
            get
            {
                return StartedAt.AddMinutes(MDuration);
            }
        }

        public int DonePart
        {
            get
            {
                double part = DateTime.Now.Ticks - StartedAt.Ticks;
                double total = FinishedAt.Ticks - StartedAt.Ticks;
                return (int)Math.Ceiling((part / total) * 100.0);
            }
        }
        
    }
}
