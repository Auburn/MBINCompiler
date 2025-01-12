using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EFF0072813E9A12, NameHash = 0xBCDA670B36E2534)]
    public class GcExperienceDebugTriggerInput : NMSTemplate
    {
        /* 0x00 */ public List<GcExperienceDebugTriggerAction> Actions;
        // size: 0xD
        public enum KeyPressEnum : uint {
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            PadUp,
            PadDown,
            PadLeft,
            PadRight,
        }
        /* 0x10 */ public KeyPressEnum KeyPress;
    }
}
