using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MD.MDCommon
{
    public class RegProperty : INotifyPropertyChanged
    {
        private string regAddress;
        private string reg_bfName;
        private string regData;
        public event PropertyChangedEventHandler PropertyChanged;

        public RegProperty(string _regAddr, string _reg_bfName, string _regVal)
        {
            this.regAddress = _regAddr;
            this.reg_bfName = _reg_bfName;
            this.regData = _regVal;
        }


        public event System.EventHandler GainChanged;
        protected virtual void OnGainChanged()
        {
            System.EventArgs e = new System.EventArgs();
            if (GainChanged != null) GainChanged(this, e);

        }

        public event System.EventHandler RegAddrChanged;
        protected virtual void OnRegAddrChanged()
        {
            System.EventArgs e = new System.EventArgs();
            if (RegAddrChanged != null) RegAddrChanged(this, e);
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        #region Register Properties
        public string RegAddr
        {
            get
            {
                return regAddress;
            }
        }

        public string Reg_bfName
        {
            get
            {
                return this.reg_bfName;
            }
        }

        public string RegData
        {
            get
            {
                return regData;
            }
            set
            {
                regData = value;
                NotifyPropertyChanged("RegData");
            }
        }
        #endregion
    }
}
