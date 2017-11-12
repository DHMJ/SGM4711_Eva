using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MD.MDCommon;
using System.Runtime.Serialization;

namespace SGM4711_Eva.GUI
{
    [Serializable]
    public partial class ParameterEQCtrl : Form, ISerializable 
    {
        private int filterCount = 1;
        RegisterMap regMap;
        IRegOperation myRegOp;
        byte[] regAddr;
        EQCurveCtrl eqCurveCtrl = null;
        public ParameterEQCtrl(IRegOperation _myRegOp, int count, RegisterMap _regmap, byte[] _regAddr)
        {
            InitializeComponent();
            myRegOp = _myRegOp;
            filterCount = count;
            regMap = _regmap;
            regAddr = _regAddr;
            InitGUI(_myRegOp, filterCount, _regmap, _regAddr);
        }

        public void SerializableForm(SerializationInfo info, StreamingContext context) 
        { 
            //this.Name   =   info.GetString( "Name "); 
            //this.Size   =   (Size)info.GetValue( "Size ",   typeof(Size)); 
            //this.Location   =   (Point)info.GetValue( "Location ",   typeof(Point)); 
        } 

        public void GetObjectData(SerializationInfo   info,   StreamingContext   context) 
        {
            //info.AddValue(
            //info.AddValue( "Name ",   this.Name);
            //info.AddValue( "Size ",   this.Size);
            //info.AddValue( "Location ",   this.Location);
        } 

        public void UpdateRegMap(RegisterMap _regmap)
        {
            this.regMap = _regmap;
            if(eqCurveCtrl != null)
                eqCurveCtrl.UpdateRegMap(_regmap);
        }

        private void InitGUI(IRegOperation _myRegOp, int _filterCount, RegisterMap _regmap, byte[] _regAddr)
        {
            eqCurveCtrl = new EQCurveCtrl(_myRegOp, _filterCount, _regmap, _regAddr);
            this.Controls.Add(eqCurveCtrl);
            eqCurveCtrl.Location = new Point(12, 12);
            //this.eqCurveCtrl.InitSetting(filterCount);
            this.eqCurveCtrl.dgv_filterSetting.CellValueChanged += filterSetting_CellValueChanged;
        }

        private void filterSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test Successed");
        }


    }
}
