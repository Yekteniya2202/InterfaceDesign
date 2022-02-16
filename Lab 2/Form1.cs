using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        SceneTask1 st1 = null;
        Dictionary<Color, SceneTask2> st2 = new Dictionary<Color, SceneTask2>();
        Dictionary<Color, SceneTask3> st3 = new Dictionary<Color, SceneTask3>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workBook = app.Workbooks.Open(@"C:\Users\enigm\source\repos\InterfaceDesign\Lab 2\2.xlsx");
            app.DisplayAlerts = false;

            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            if (radioButton1.Checked)
            {
                WriteTimeInCells(sheet, st1._times, 3, 4);
                
            }
            else if (radioButton2.Checked)
            {
                if (radioButtonWhite.Checked)
                {
                    WriteTimeInCells(sheet, st2[Color.White]._times, 3, 15);
                }
                else if (radioButtonBlack.Checked)
                {
                    WriteTimeInCells(sheet, st2[Color.Black]._times, 4, 15);
                }
                else if (radioButtonGreen.Checked)
                {
                    WriteTimeInCells(sheet, st2[Color.Green]._times, 5, 15);
                }
                else if (radioButtonRed.Checked)
                {
                    WriteTimeInCells(sheet, st2[Color.Red]._times, 6, 15);

                }
                else if (radioButtonYellow.Checked)
                {
                    WriteTimeInCells(sheet, st2[Color.Yellow]._times, 7, 15);
                }
            }
            else if (radioButton3.Checked)
            {
                if (radioButtonBlack.Checked)
                {
                    WriteTimeInCells(sheet, st3[Color.Black]._times, 3, 26);
                }
                else if (radioButtonBlue.Checked)
                {
                    WriteTimeInCells(sheet, st3[Color.Blue]._times, 4, 26);
                }
                else if (radioButtonGreen.Checked)
                {
                    WriteTimeInCells(sheet, st3[Color.Green]._times, 5, 26);
                }
                else if (radioButtonRed.Checked)
                {
                    WriteTimeInCells(sheet, st3[Color.Red]._times, 6, 26);

                }
                else if (radioButtonYellow.Checked)
                {
                    WriteTimeInCells(sheet, st3[Color.Yellow]._times, 7, 26);
                }
            }

            app.ActiveWorkbook.Save();
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        private void WriteTimeInCells(Worksheet sheet, System.Collections.ArrayList _times, int offsetX, int offsetY)
        {
            for (int i = 0; i < _times.Count; i++)
            {
                sheet.Cells[i + offsetY, offsetX] = _times[i];
            }
        }

        private void WriteLogInformation(Scene st)
        {
            textBox1.Text += "==============================================\r\n";
            foreach(var time in st._times)
            {
                textBox1.Text += $"Сцена 1, среднее время (мс.) - {(long)time}\r\n";
            }
            textBox1.Text += "==============================================\r\n";
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            FormExperiment form = new FormExperiment();
            form.st = new SceneTask1(form);
            form.ShowDialog();
            st1 = (SceneTask1)form.st;
            WriteLogInformation(st1);
        }

        private void buttonTask2FontColor_Click(object sender, EventArgs e)
        {
            Color color = Color.AliceBlue;
            if (radioButtonBlack.Checked)
            {
                color = Color.Black;
            }
            else if (radioButtonWhite.Checked)
            {
                color = Color.White;
            }
            else if (radioButtonGreen.Checked)
            {
                color = Color.Green;
            }
            else if (radioButtonRed.Checked)
            {
                color = Color.Red;
            }
            else if (radioButtonYellow.Checked)
            {
                color = Color.Yellow;
            }
            else if (radioButtonBlue.Checked)
            {
                return;
            }
            FormExperiment form = new FormExperiment();
            form.st = new SceneTask2(form, color);
            form.ShowDialog();
            st2[color] = (SceneTask2)form.st;
            WriteLogInformation(st2[color]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color color = Color.AliceBlue;
            if (radioButtonBlack.Checked)
            {
                color = Color.Black;
            }
            else if (radioButtonBlue.Checked)
            {
                color = Color.Blue;
            }
            else if (radioButtonGreen.Checked)
            {
                color = Color.Green;
            }
            else if (radioButtonRed.Checked)
            {
                color = Color.Red;
            }
            else if (radioButtonYellow.Checked)
            {
                color = Color.Yellow;
            }
            else if (radioButtonWhite.Checked)
            {
                return;
            }
            FormExperiment form = new FormExperiment();
            form.st = new SceneTask3(form, color);
            form.ShowDialog();
            st3[color] = (SceneTask3)form.st;
            WriteLogInformation(st3[color]);
        }
    }
}
