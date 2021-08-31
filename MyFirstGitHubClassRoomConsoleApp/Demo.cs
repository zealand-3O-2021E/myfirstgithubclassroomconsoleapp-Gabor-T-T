using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp
{
    class Demo
    {
        private int _x;
        private int _y;

        public Demo(int x, int y)
        {
            x = _x;
            y = _y;

        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public  int Y { get; set; }

    }
}
