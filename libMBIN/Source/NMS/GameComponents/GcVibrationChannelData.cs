using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AA44B1E51F4564C, NameHash = 0xAF919B46C646D940)]
    public class GcVibrationChannelData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x2
        public enum DataEnum {
            Left,
            Right,
        }
        [NMS(Size = 0x2, EnumType = typeof(DataEnum))]
        /* 0x10 */ public GcVibrationData[] Data;
        // size: 0x4
        public enum VRAffectedHandsEnum : uint {
            Both,
            LeftOnly,
            RightOnly,
            DisableInVR,
        }
        /* 0x40 */ public VRAffectedHandsEnum VRAffectedHands;
        /* 0x44 */ public bool VROnly;
        /* 0x45 */ public bool VRSwapHandForLeftHanded;
    }
}
