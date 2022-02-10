using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Experiment1 : Form
    {
        Button b = null;

        int SceneCounter = default;
        int SubSceneCounter = 0;
        int SubSubSceneCounter = 0;
        bool NeedToChangeScene = false;
        bool NeedToChangeSubScene = false;
        ExpType _expType;
        Stopwatch timer = new Stopwatch();
        public Experiment1(ExpType expType)
        {
            InitializeComponent();
            _expType = expType;
            if (_expType == ExpType.Exp1)
                SceneCounter = Experiments.Exp1.S.Length;
            else if (_expType == ExpType.Exp2 || _expType == ExpType.Exp3)
                SceneCounter = Experiments.Exp2.D.Length;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Experiment1_Load(object sender, EventArgs e)
        {
        }

        private void Experiment1_Shown(object sender, EventArgs e)
        {
        }

        private void DrawScene()
        {
            int D = default;

            b = new Button();

            //this.Controls.Clear();
            if (_expType == ExpType.Exp1)
            {
                D = Experiments.Exp1.D;
                b.Location = GetPointOnCircle(Experiments.Exp1.S[Experiments.Exp1.S.Length - SceneCounter], 0, 0);
            }
            else if (_expType == ExpType.Exp2)
            {
                D = Experiments.Exp2.D[Experiments.Exp2.D.Length - SceneCounter];
                b.Location = GetPointOnCircle(Experiments.Exp2.S, 0, 0);
            }
            else if(_expType == ExpType.Exp3)
            {
                D = Experiments.Exp2.D[Experiments.Exp2.D.Length - SceneCounter];
                b.Location = GetPointOnCircle(Experiments.Exp1.S[SubSceneCounter], 0, 0);
            }
           

            b.Size = new Size(5 * D, 5 * D);
            b.ForeColor = Color.Black;
            b.BackColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.Visible = true;
            b.MouseClick += MyBtnClicked;
            this.Controls.Add(b);

            Cursor.Position = new Point(0, 0);
        }


        //кромешный ад из-за событийной модели
        private void ChangeScene()
        {
            if (_expType == ExpType.Exp1 || _expType == ExpType.Exp2)
            {
                if (NeedToChangeScene)
                {
                    SceneCounter--;
                    SubSceneCounter = 0;
                    NeedToChangeScene = false;
                }
                else
                {
                    SubSceneCounter++;
                    if (SubSceneCounter == 4)
                    {
                        NeedToChangeScene = true;
                    }
                }
            }
            else
            {

                if (SubSubSceneCounter == 2)
                {
                    SubSubSceneCounter = 0;
                    if (SubSceneCounter == 9)
                    {
                        SubSceneCounter = 0;
                        SceneCounter--;
                    }
                    else
                    {
                        SubSceneCounter++;
                    }
                }
                else
                {
                    SubSubSceneCounter++;
                }
            }

        }


        private void MyBtnClicked(object o, EventArgs e)
        {
            SuccessTextBox.BackColor = Color.Green;
            SuccessTextBox.Text = "Удачно";
            if ((_expType == ExpType.Exp1 || _expType == ExpType.Exp2) && SceneCounter == 0)
            {
                timer.Stop();
                this.Close();
                return;
            }
            else if (SceneCounter == 0 && SubSceneCounter == 0 && SubSubSceneCounter == 0)
            {
                timer.Stop();
                this.Close();
                return;
            }
            if (_expType == ExpType.Exp1)
                Experiments.Exp1.t[10 - SceneCounter, SubSceneCounter] = timer.ElapsedMilliseconds;
            else if (_expType == ExpType.Exp2)
                Experiments.Exp2.t[9 - SceneCounter, SubSceneCounter] = timer.ElapsedMilliseconds;
            else if (_expType == ExpType.Exp3)
                Experiments.Exp3.t[9 - SceneCounter, SubSceneCounter, SubSubSceneCounter] = timer.ElapsedMilliseconds;
            timer.Restart();
            this.Controls.Remove(b);
            DrawScene();
            ChangeScene();
        }
        private Point GetPointOnCircle(int R, int x0, int y0)
        {
            Random rnd = new Random();
            double rad = rnd.NextDouble()  * 2 * Math.PI;
            return new Point(Convert.ToInt32(Math.Abs(x0 + R * Math.Cos(rad))), Convert.ToInt32(Math.Abs(y0 + R * Math.Sin(rad))));
        }

        bool started = false;
        private void StartButton_Click(object sender, EventArgs e)
        {
            started = true;
            timer.Start();
            DrawScene();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Experiment1_MouseClick(object sender, MouseEventArgs e)
        {
            if (started)
            {
                if (_expType == ExpType.Exp1)
                    Experiments.Exp1.misses[10 - SceneCounter]++;
                else if (_expType == ExpType.Exp2)
                    Experiments.Exp2.misses[9 - SceneCounter]++;
                else if (_expType == ExpType.Exp3)
                    Experiments.Exp3.misses[9 - SceneCounter, SubSceneCounter]++;
                SuccessTextBox.BackColor = Color.Red;
                SuccessTextBox.Text = "Неудачно";
                timer.Restart();
                this.Controls.Remove(b);
                DrawScene();

            }
           
        }
    }
}
