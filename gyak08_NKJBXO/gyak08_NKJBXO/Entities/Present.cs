using gyak08_NKJBXO.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak08_NKJBXO.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get;private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color bcolor,Color rcolor)
        {
            BoxColor = new SolidBrush(bcolor);
            RibbonColor = new SolidBrush(rcolor);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, 2*(Height/5), Width, Height / 5);
            g.FillRectangle(RibbonColor, 2*(Width/5), 0, Width / 5, Height);

        }
    }
}
