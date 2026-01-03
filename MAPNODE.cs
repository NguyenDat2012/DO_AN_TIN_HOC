using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALLMAP_TANG2
{
    class MAPNODE
    {
        private string name;
        private float x, y;
        public MAPNODE(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
        public MAPNODE()
        {
            this.name = "";
            this.x = 0;
            this.y = 0; 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public override string ToString()
        {
            return name;
        }

    }
}
