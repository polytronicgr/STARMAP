﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAR.Model {
    class WriteCommandPacket : DataPacket {
        public WriteCommandPacket(byte entryPort, byte exitPort, string dateString, List<byte> packetBytes, string endCode)
                : base(entryPort, exitPort, dateString, packetBytes, endCode) {
            // Parse m_remainingBytes (List<byte>)
        }
    }
}
