using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24F1EB504C2DDDFF, NameHash = 0xD08C5A93AECF92B1)]
    public class GcHUDImageData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public GcHUDComponent Data;
        /* 0x38 */ public NMSString0x80 Image;
    }
}
