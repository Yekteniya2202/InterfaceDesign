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

namespace Lab_1
{
    public enum ExpType
    {
        Exp1,
        Exp2,
        Exp3
    }

    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exp1Button_Click(object sender, EventArgs e)
        {
            Experiments.Exp1.D = decimal.ToInt32(DNumericUpDown.Value);
            Experiment1 form = new Experiment1(ExpType.Exp1);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();

            LogTextBox.Text += "Эксперимент 1\r\n";
            foreach(var time in Experiments.Exp1.t)
            {
                LogTextBox.Text += $"Время клика (мс.) - {time}\r\n";
            }

        }

        private void Exp2Button_Click(object sender, EventArgs e)
        {
            Experiments.Exp2.S = decimal.ToInt32(SNumericUpDown.Value);
            Experiment1 form = new Experiment1(ExpType.Exp2);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();

            LogTextBox.Text += "Эксперимент 2\r\n";
            foreach (var time in Experiments.Exp2.t)
            {
                LogTextBox.Text += $"Время клика (мс.) - {time}\r\n";
            }
        }

        private void Exp3Button_Click(object sender, EventArgs e)
        {
            Experiment1 form = new Experiment1(ExpType.Exp3);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();

            LogTextBox.Text += "Эксперимент 3\r\n";
            foreach (var time in Experiments.Exp3.t)
            {
                LogTextBox.Text += $"Время клика (мс.) - {time}\r\n";
            }
        }

        private void ExcelSaveButton_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application
            {
                Visible = false,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workBook = app.Workbooks.Open(@"C:\Users\enigm\source\repos\InterfaceDesign\Lab 1\1.xlsx");
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);

            if (radioButton1.Checked)
            {
                double[] t1 = GetMiddleValuedArray(Experiments.Exp1.t);

                for (int i = 0; i < t1.Length; i++)
                {
                    sheet.Cells[i + 4, 4] = t1[i];
                    sheet.Cells[i + 4, 6] = Experiments.Exp1.misses[i];
                }
            }


            if (radioButton2.Checked)
            {
                double[] t2 = GetMiddleValuedArray(Experiments.Exp2.t);

                for (int i = 0; i < t2.Length; i++)
                {
                    sheet.Cells[i + 17, 4] = t2[i];
                    sheet.Cells[i + 17, 6] = Experiments.Exp2.misses[i];
                }
            }

            if (radioButton3.Checked)
            {
                double[,] t3 = GetMiddleValuedArray(Experiments.Exp3.t);

                int l1 = t3.GetLength(0);
                int l2 = t3.GetLength(1);
                for (int i = 0; i < l1; i++)
                {
                    for (int j = 0; j < l2; j++)
                    {
                        sheet.Cells[i * l2 + j + 29, 6] = t3[i, j];
                        sheet.Cells[i * l2 + j + 29, 8] = Experiments.Exp3.misses[i, j];
                    }
                }
            }
            

            app.ActiveWorkbook.Save();
            app.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
        }

        private double[,] GetMiddleValuedArray(long[,,] t)
        {
            int length1 = t.GetLength(0);
            int length2 = t.GetLength(1);
            int length3 = t.GetLength(2);
            double[,] t1 = new double[length1, length2];
            for(int k = 0; k < length1; k++)
            {
                for (int i = 0; i < length2; i++)
                {
                    long sum = 0;
                    for (int j = 0; j < length3; j++)
                    {
                        sum += t[k, i, j];
                    }
                    t1[k, i] = sum * 1.0 / length2;
                }
            }
            

            return t1;
        }

        private double[] GetMiddleValuedArray(long[,] t)
        {
            int length1 = t.GetLength(0);
            int length2 = t.GetLength(1);
            double[] t1 = new double[length1];

            for(int i = 0; i < length1; i++)
            {
                long sum = 0;
                for(int j = 0; j < length2; j++)
                {
                    sum += t[i, j];
                }
                t1[i] = sum * 1.0 / length2;
            }

            return t1;
        }
    }
}
