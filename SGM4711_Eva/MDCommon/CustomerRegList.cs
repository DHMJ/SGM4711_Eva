using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MD.MDCommon
{
    public class CustomerRegList
    {
        private List<byte[]> regList = new List<byte[]> { };
        private List<string> regListName = new List<string> { };

        public CustomerRegList()
        {
            regList.Clear();
            regListName.Clear();
            regList.Add(Normal);
            regListName.Add("Normal Registers");
            regList.Add(Biquads);
            regListName.Add("Biquads");
            regList.Add(DRC1);
            regListName.Add("DRC1");
            regList.Add(DRC2);
            regListName.Add("DRC2");
            regList.Add(DRCs);
            regListName.Add("DRCs");
            regList.Add(CH1OutputMixer);
            regListName.Add("CH1OutputMixer");
            regList.Add(CH2OutputMixer);
            regListName.Add("CH2OutputMixer");
            regList.Add(CH1InputMixer);
            regListName.Add("CH1InputMixer");
            regList.Add(CH2InputMixer);
            regListName.Add("CH2InputMixer");
            regList.Add(CH3InputMixer);
            regListName.Add("CH3InputMixer");
            regList.Add(PostScale);
            regListName.Add("PostScale");
            regList.Add(PreScale);
            regListName.Add("PreScale");
            regList.Add(SubOutputMixer);
            regListName.Add("SubOutputMixer");
            regList.Add(SubInputMixer);
            regListName.Add("SubInputMixer");
            regList.Add(NoiseGate1);
            regListName.Add("NoiseGate1");
            regList.Add(NoiseGate2);
            regListName.Add("NoiseGate2");
        }

        public List<byte[]> RegList
        {
            get { return this.regList; }
        }

        public List<String> RegListName
        {
            get { return this.regListName; }
        }

        private byte[] Normal = new byte[] {0x00, 0x02, 0x05, 0x03, 0x04, 0x06, 0x07, 
            0x08, 0x09, 0x0A, 0x0B, 0x0C,  0x0E, 0x10, 0x11, 0x12, 0x13, 
            0x14, 0x19, 0x1A, 0x1B, 0x1C,  0x1D, 0x1E, 0x1F, 0x20, 0x21, 
            0x25 };

        private byte[] Biquads = new byte[] { 0x50, 0x29, 0x30, 0x2A, 0x2B, 
            0x2C, 0x2D, 0x2E, 0x2F, 0x58,  0x59, 0x31, 0x32, 0x33, 0x34, 
            0x35, 0x36, 0x5C, 0x5D, 0x5A,  0x5B, 0x5E };

        private byte[] DRC1 = new byte[] { 0x3A, 0x3B, 0x3C, 0x40, 0x41, 
            0x42/*, 0x47*/ };

        private byte[] DRC2 = new byte[] { 0x3D, 0x3E, 0x3F, 0x43, 0x44, 
            0x45/*, 0x48*/ };

        private byte[] DRCs = new byte[] { 0x46 };

        private byte[] CH1OutputMixer = new byte[] { 0x51 };

        private byte[] CH2OutputMixer = new byte[] { 0x52 };

        private byte[] CH1InputMixer = new byte[] { 0x53 };

        private byte[] CH2InputMixer = new byte[] { 0x54 };

        private byte[] CH3InputMixer = new byte[] { 0x55 };

        private byte[] PostScale = new byte[] { 0x56 };

        private byte[] PreScale = new byte[] { 0x57 };

        private byte[] SubOutputMixer = new byte[] { 0x60 };

        private byte[] SubInputMixer = new byte[] { 0x61 };

        private byte[] NoiseGate1 = new byte[] { 0x63 };

        private byte[] NoiseGate2 = new byte[] { 0x64 };
    }

}
