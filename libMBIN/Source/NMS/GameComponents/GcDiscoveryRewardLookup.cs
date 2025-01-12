using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x214EA4354D0DD100, NameHash = 0xA2280C1D273E7644)]
    public class GcDiscoveryRewardLookup : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public NMSString0x10[] BiomeSpecific;
        /* 0x100 */ public NMSString0x10 Id;
        /* 0x110 */ public NMSString0x10 Secondary;
    }
}
