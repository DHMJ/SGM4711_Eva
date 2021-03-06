﻿using System;
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

        bool RegWrite(byte _regAddr, byte[] data, bool ifTimeLog, bool ifPowerDown, bool ifPowerOn);

        bool RegWrite(byte _regAddr);

        bool RegWrite(byte _regAddr, bool ifTimeLog, bool ifPowerDown, bool ifPowerOn);

        bool RegWrite(byte[] _regAddr);

        bool RegWrite(byte[] _regAddr, bool ifTimeLog, bool ifPowerDown, bool ifPowerOn);

        bool RegWrite(Register _reg);

        bool RegWrite(Register _reg, bool ifTimeLog, bool ifPowerDown, bool ifPowerOn);

        bool RegWrite(Register[] _reg);

        bool RegWrite(Register[] _reg, bool ifTimeLog, bool ifPowerDown, bool ifPowerOn);

        bool RegWrite_NoAck(Register _reg);

        bool RegWrite_NoAck(byte _regAddr);

        bool RegWrite_NoAck(byte _regAddr, byte[] data);

        void UpdateRegSettingSource();

        void PowerOn();
    }
}
