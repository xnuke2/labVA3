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


namespace labVA3
{
    public partial class Form1 : Form
    {
        int numOfRepeat = 100;
        public Form1()
        { 
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            AlRezLabel.Text = string.Empty;
            labelTimeNewton.Text = string.Empty;
            labelDivisionByHalf.Text = string.Empty;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            double start =Convert.ToDouble( numericUpDownStart.Value);
            double end = Convert.ToDouble( numericUpDownEnd.Value);
            try
            {
                if (SolveEquation.analyticalWayToSeparateRoots(start, end))
                {
                    AlRezLabel.Text = "На промежутке есть корень";
                }
                else
                {
                    AlRezLabel.Text = "На промежутке нет корня";
                }
            }catch (Exception ex)
            {
                AlRezLabel.Text=ex.Message;
            }
        }

        private void buttonDivisionByHalf_Click(object sender, EventArgs e)
        {
            dataDivisionByHalf.Rows.Clear();
            double start = Convert.ToDouble(numericUpDownStart.Value);
            double end = Convert.ToDouble(numericUpDownEnd.Value);
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                List<string> strings = new List<string>();
                stopwatch.Start();
                for (int i = 0; i < numOfRepeat; i++)
                {
                    strings = SolveEquation.MethodByDivisionOnHalf(start, end);
                }
                stopwatch.Stop();
                for (int i = 0; i < strings.Count; i++)
                {
                    dataDivisionByHalf.Rows.Add(i + 1, strings[i]);
                }
                labelDivisionByHalf.Text =Convert.ToString( stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                AlRezLabel.Text = ex.Message;
            }

        }

        private void buttonNewton_Click(object sender, EventArgs e)
        {
            dataGridViewNewton.Rows.Clear();
            double start = Convert.ToDouble(numericUpDownStart.Value);
            double end = Convert.ToDouble(numericUpDownEnd.Value);
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                List<string> strings = new List<string>();
                stopwatch.Start();
                for (int i=0; i < numOfRepeat; i++) 
                {
                    strings = SolveEquation.MethodNewton(start, end);
                }
                stopwatch.Stop();
                for (int i = 0; i < strings.Count; i++)
                {
                    dataGridViewNewton.Rows.Add(i + 1, strings[i]);
                }
                labelTimeNewton.Text = Convert.ToString(stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                AlRezLabel.Text = ex.Message;
            }
        }
    }
}
