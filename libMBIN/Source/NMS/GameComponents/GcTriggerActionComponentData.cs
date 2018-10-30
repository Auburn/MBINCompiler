﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x56EA2AB09A126A9C)]
    public class GcTriggerActionComponentData : NMSTemplate
    {
        /* 0x00 */ public bool HideModel;
        /* 0x01 */ public bool StartInactive;
        [NMS(Size = 0x6, Ignore =true)]
        /* 0x02 */ public byte[] Padding2;
        /* 0x08 */ public List<GcActionTriggerState> States;
        /* 0x18 */ public bool Persistent;
        [NMS(Size = 7, Ignore = true)]
        /* 0x19 */ public byte[] Padding19;
        [NMS(Size = 0x10)]
        /* 0x20 */ public string PersistentState;
        /* 0x30 */ public bool ResetShotTimeOnStateChange;
        [NMS(Size = 7, Ignore = true)]
        /* 0x31 */ public byte[] EndPadding;
    }
}
