using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public class SceneTask1 : Scene
    {
        public SceneTask1(Form Form) : base(Form)
        {
            int i = 0;
            foreach(var button in _all)
            {
                ((Button)button).Text = (++i).ToString();
            }
        }

        


    }
}
