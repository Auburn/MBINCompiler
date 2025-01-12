using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC8CD57827D81843, NameHash = 0x28A143D89E217108)]
    public class GcTerrainEditsBuffer : NMSTemplate
    {
        [NMS(Size = 0x100)]
        /* 0x00000 */ public Vector3f[] BufferAnchors;
        [NMS(Size = 0x100)]
        /* 0x01000 */ public ulong[] GalacticAddresses;
        [NMS(Size = 0x7530)]
        /* 0x01800 */ public GcTerrainEdit[] Edits;
        [NMS(Size = 0x100)]
        /* 0x3C180 */ public int[] BufferSizes;
        [NMS(Size = 0x100)]
        /* 0x3C580 */ public byte[] BufferAges;
        [NMS(Size = 0x100)]
        /* 0x3C680 */ public bool[] BufferProtected;
    }
}
