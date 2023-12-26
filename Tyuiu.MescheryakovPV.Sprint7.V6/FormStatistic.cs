using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MescheryakovPV.Sprint7.V6.Lib;

namespace Tyuiu.MescheryakovPV.Sprint7.V6
{
    public partial class FormStatistic : Form
    {
        public FormStatistic()
        {
            InitializeComponent();
        }

        public void ShowChart(string columnName)
        {
            var series = chart_MPV.Series.Add("Частота");
            List<string> xvalues = DataService.UniqueWords("Возраст");
            foreach (string val in xvalues)
            {
                series.Points.AddXY(Convert.ToDouble(val), Convert.ToDouble(DataService.StatFrequencyWord(val, "Возраст")));
            }
        }

        private void chart_MPV_Click(object sender, EventArgs e)
        {

        }
    }
}


