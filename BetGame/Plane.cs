using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetGame
{
    /// <summary>
    /// This class is representing Plane and its Graphic Details
    /// </summary>
    public class Plane
    {
        // Name of Plane
        public string Name { get; set; }

        // Picture of Plane
        public PictureBox Picture { get; set; }

        // Track Length
        public int TrackLength { get; set; }
    }
}
