using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60F6BD031CCE4EB8, NameHash = 0x3246DB9846FF8B70)]
    public class GcPlayerCommunicatorMessageWeighted : NMSTemplate
    {
        /* 0x00 */ public GcPlayerCommunicatorMessage Message;
        /* 0x50 */ public int Weight;
    }
}
