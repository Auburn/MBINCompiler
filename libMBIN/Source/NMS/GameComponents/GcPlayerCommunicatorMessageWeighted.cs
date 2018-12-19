﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x46F2370C517ECE63)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        public GcPlayerCommunicatorMessage Message;
        public int Weighted;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
