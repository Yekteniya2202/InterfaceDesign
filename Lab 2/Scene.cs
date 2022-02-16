using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public abstract class Scene
    {
        Random rnd = new Random();

        Form form;
        //все кнопки
        protected ArrayList _all = new ArrayList(9);

        //отрисовать
        protected ArrayList _toDraw = new ArrayList(9);

        //время клика
        public ArrayList _times = new ArrayList(9);

        ArrayList _misses = new ArrayList(9);

        ArrayList _subTimes = new ArrayList(5);

        Stopwatch timer = new Stopwatch();

        int SubSceneCount = 0;
        int SceneCount = 0;
        bool End = false;
        bool Updated = false;
        //нужная кнопка
        protected Button _target;


        Rectangle _buttonsArea = new Rectangle(50, 45, 0, 0);

        //позиция курсора
        Point _cursorPos;

        //первичная инициализация
        public Scene(Form Form)
        {
            form = Form;
            for (int i = 0; i < 9; i++)
            {
                Button buttonToAdd = new Button();
                buttonToAdd.Size = new Size(100, 40);
                buttonToAdd.Location = new Point(50, (i+1) * 45);
                buttonToAdd.Font = new Font("Times New Roman", 14, FontStyle.Regular);
                buttonToAdd.Click += nonTargetButton_Clicked;
                buttonToAdd.ForeColor = Color.Blue;
                _all.Add(buttonToAdd);
            }
            _toDraw.Add(_all[0]);
            _toDraw.Add(_all[1]);
            _target = (Button)_toDraw[0];
        }

        public void Start()
        {
            timer.Start();
        }

        private void Update()
        {
            Updated = false;
            SubSceneCount++;
            if (SubSceneCount == 5)
            {
                Updated = true;
                SubSceneCount = 0;
                SceneCount++;
                if(SceneCount == 8)
                {
                    form.Close();
                    End = true;
                }
            }
        }   
        protected void targetButton_Clicked(object o, EventArgs e)
        {
            Clear();
            Update();
            _subTimes.Add(timer.ElapsedMilliseconds);
            timer.Restart();
            if (Updated)
            {
                long total = 0;
                foreach (var subtime in _subTimes)
                {
                    total += (long)subtime;
                }
                _subTimes.Clear();
                _times.Add(total);
                if (!End)
                {
                    _toDraw.Add(_all[1 + SceneCount]);
                }
            }
            Draw();
        }

        protected void nonTargetButton_Clicked(object o, EventArgs e)
        {
            timer.Restart();
            Draw();
            //Добавить промахи
        }

        public void Clear()
        {
            foreach (var button in _toDraw)
            {
                if (form.Controls.Contains((Button)button))
                    form.Controls.Remove((Button)button);
            }
        }
        public void Draw()
        {
            var positions = ShuffleActiveButtons();

            int num = SelectTargetRandom();
            PrintHintInTextBox(num);
            _buttonsArea.Height = 85;
            int i = 0;
            //Рисуем в рандомном порядке
            foreach (var button in _toDraw)
            {

                _buttonsArea.Height += ((Button)button).Height + 5;
                if (!form.Controls.Contains((Button)button))
                {
                    ((Button)button).Location = (Point)positions[i];
                    form.Controls.Add((Button)button);
                    i++;
                }
            }
            Cursor.Position = new Point(200, _buttonsArea.Height / 2);



        }

        public virtual void PrintHintInTextBox(int num)
        {
            form.Controls.Find("textBox1", false)[0].Text = $"{num + 1}";
        }

        private ArrayList ShuffleActiveButtons()
        {
            ArrayList positions = new ArrayList(9);
            foreach(var button in _toDraw)
            {
                positions.Add(((Button)button).Location);
            }
            for(int i = 0; i < positions.Count - 1; i++)
            {
                var tmp = positions[i];
                var rind = rnd.Next(0, _toDraw.Count);
                positions[i] = positions[rind];
                positions[rind] = tmp;
            }
            return positions;
        }

        public int SelectTargetRandom()
        {
            RemoveTargetStyle();
            _target.Click += nonTargetButton_Clicked;
            _target.Click -= targetButton_Clicked;
            int i = rnd.Next(0, _toDraw.Count);
            _target = (Button)_toDraw[i];
            _target.Click -= nonTargetButton_Clicked;
            _target.Click += targetButton_Clicked;
            SetTargetStyle();
            return i;
        }
        public virtual void SetTargetStyle()
        {

        }
        public virtual void RemoveTargetStyle()
        {

        }

    }
}
