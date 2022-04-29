using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xxx
{
    public class Area : IComparable
    {
        //Fields
        private string _name;
        private int _length;
        private int _width;
        private MyColorEnum _color; 
        //Constructor
        public Area(){}
        public Area(MyColorEnum color,string name, int len,int wid)
        {
            this.setName(name);
            this.Length = len;
            this.Width= wid;
            this.Color = color;
        }

        //Properties
        public MyColorEnum Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        public int Length 
        {
            get { return this._length; }
            set
            {
                if (value > 0)
                {
                    this._length = value;
                }
                else
                {
                    this.Length = 0;
                }
            }
        }
        public int Width
        {
            get { return this._width; }
            set { 
                if (value > 0)
                {
                    this._width = value;
                }
                else
                {
                    this.Width = 0;
                }
            }
        }

        //Metoder
        public void setName(string name)
        {
            if (name.Length > 2 &&name.Length<50)
            {
                this._name = name;
            }
            else
            {
                this._name = "N/A";
            }
        }
        public string getName()
        {
            return _name;
        }
        public int GetSize()
        {
            return this.Width * this.Length;
        }
        //Override
        public override string ToString()
        {
            return ($"* Color:{this.Color,-8} Name:{this.getName(),-8} Size:{this.GetSize(),7} Width:{this.Width,7} Length:{ this.Length,7}  *");
            //return string.Format("{0,4} {1} {2} {3}",this.getName(),this,GetSize(),this.Width,this.Length);
        }

        public int CompareTo(object obj)
        {
            Area area = (Area)obj;
            return this.GetSize()-area.GetSize();
        }
    }
}
