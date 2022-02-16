using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public class SceneTask2 : Scene
    {
        Color _color;
        public SceneTask2(Form Form, Color color) : base(Form)
        {
            _color = color;
            int i = 0;
            foreach (var button in _all)
            {
                ((Button)button).Text = (++i).ToString();
            }
        }
        public override void PrintHintInTextBox(int num)
        {
        }

        //устанавливаем стиль для таргета
        public override void SetTargetStyle()
        {
            _target.ForeColor = _color;
        }
        public override void RemoveTargetStyle()
        {
            _target.ForeColor = Color.Blue;
        }
    }
}
