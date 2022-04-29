using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    internal class Cubic : Area, IComparable
    {
        private int _height;
        Area area = new Area();
        public Cubic()
        {

        }
        public Cubic(int height,object obj)
        {
            Height = height;
            area = (Area)obj;
        }
        public Cubic(MyColorEnum color,int hei,int wid,int len,string name)
        {
            this.Height=hei;
            this.Width = wid;
            this.Length = len;
            this.setName(name);
            this.Color = color;
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Get3dSize()
        {
            if (area.getName() == null)
            {
                return 2 * (this.Width*this.Length*this.Height);
            }
            else {
                return 2 * (area.Width * this.Height * area.Length);
            }
        }
        public override string ToString()
        {
            if (area.getName() == null)
            {
                return ($"* Color:{this.Color,-8} Name:{this.getName(),-8} Size2D: {this.GetSize(),7} Width:{this.Width,7} Length:{ this.Length,7} Height:{this.Height,7} Size3D:{this.Get3dSize(),7} *");
            }
            else
            {
                return ($"* Color:{area.Color,-8} Name:{area.getName(),-8} Size2D: {area.GetSize(),7} Width:{area.Width,7} Length:{ area.Length,7} Height:{this.Height,7} Size3D:{this.Get3dSize(),7} *");
            }
        }
        public int CompareTo(object obj)
        {
            Cubic cubic = (Cubic)obj;
            return this.Get3dSize() - cubic.Get3dSize();
        }

    }
}
