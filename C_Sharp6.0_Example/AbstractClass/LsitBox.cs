using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class LsitBox: Control
    {
        private List<string> list = new List<string>();

        public LsitBox(int xPos, int yPos, List<string> content) : base(xPos, yPos)
        {
            this.list = content;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing List.....");
        }
    }
}
