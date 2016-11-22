using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            List<Control> controls = new List<Control>();
            Button button = new Button(0, 100, "Click Me");
            LsitBox listBox = new LsitBox(100, 300, new List<string>());
            Button cancelButton = new Button(150, 100, "Cancel");

            controls.Add(button);
            controls.Add(listBox);
            controls.Add(cancelButton);

            foreach (Control control in controls)
            {
                control.Draw();
            }

        }
    }
}
