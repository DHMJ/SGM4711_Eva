using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MD.MDCommon
{
    public interface IRegOperation
    {
        bool RegRead(byte _regAddr, byte[] data, bool ifTimeLog);

        bool RegRead(byte _regAddr);

        bool RegRead(byte _regAddr, bool ifTimeLog);

        bool RegRead(byte[] _regAddr);

        bool RegRead(byte[] _regAddr, bool ifTimeLog);

        bool RegRead(Register _reg);

        bool RegRead(Register _reg, bool ifTimeLog);

        bool RegRead(Register[] _reg);

        bool RegRead(Register[] _reg, bool ifTimeLog);

        bool RegWrite(byte _regAddr, byte[] data, bool ifTimeLog);

        bool RegWrite(byte _regAddr);

        bool RegWrite(byte _regAddr, bool ifTimeLog);

        bool RegWrite(byte[] _regAddr);

        bool RegWrite(byte[] _regAddr, bool ifTimeLog);

        bool RegWrite(Register _reg);

        bool RegWrite(Register _reg, bool ifTimeLog);

        bool RegWrite(Register[] _reg);

        bool RegWrite(Register[] _reg, bool ifTimeLog);

        void UpdateRegSettingSource();
    }
}
