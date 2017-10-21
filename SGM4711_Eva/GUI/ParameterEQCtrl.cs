using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;

namespace SGM4711_Eva.GUI
{
    public partial class ParameterEQCtrl : Form
    {
        private int filterCount = 1;
        RegisterMap regmap;
        byte[] regAddr;
        public ParameterEQCtrl(int count, RegisterMap _regmap, byte[] _regAddr)
        {
            InitializeComponent();
            filterCount = count;
            regmap = _regmap;
            regAddr = _regAddr;
            InitGUI(filterCount);
        }

        private void InitGUI(int filterCount)
        {
            this.eqCurveCtrl1.InitSetting(filterCount);
            this.eqCurveCtrl1.dgv_filterSetting.CellValueChanged += filterSetting_CellValueChanged;
        }

        private void filterSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test Successed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 200;

            double[] den = {1.0, 0.0, 0.9};  
            double[] num = {0.0, -1.0};  
            double[] x_out, y_out;  
            int i;  
            double f;  
            //gain(num, den, 1, 2, x_out, y_out, N, 1);  
            for(i = 0; i < N; i ++)  
            {  
                f = 0.5 * i / (N - 1);  
                //printf("%f, %f, %f\n", f, x_out[i], y_out[i]);  
            }  
   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
