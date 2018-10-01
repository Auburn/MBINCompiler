﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0xE02205656427F42D, Broken = true)]
    public class GcBaseBuildingGroup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string ParentGroup;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string Name;
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
