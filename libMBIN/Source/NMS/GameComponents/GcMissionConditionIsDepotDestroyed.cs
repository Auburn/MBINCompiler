using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x0000000000000000, NameHash = 0x2797515E3A43C26C)]
    public class GcMissionConditionIsDepotDestroyed : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string ControllingScanEvent;
    }
}
