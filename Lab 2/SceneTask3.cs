using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public class SceneTask3 : Scene
    {
        Color _color;
        public SceneTask3(Form Form, Color color) : base(Form)
        {
            _color = color;
        }
        public override void PrintHintInTextBox(int num)
        {
        }

        //устанавливаем стиль для таргета
        public override void SetTargetStyle()
        {
            _target.BackColor = _color;
        }
        public override void RemoveTargetStyle()
        {
            _target.BackColor = Color.Transparent;
        }
    }
}
