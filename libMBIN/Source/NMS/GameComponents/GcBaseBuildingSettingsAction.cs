using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7932103D79C6EBB, NameHash = 0x1250AC356CE3B7B)]
    public class GcBaseBuildingSettingsAction : NMSTemplate
    {
        /* 0x0 */ public TkGraphicsDetailTypes MaxAffectedDetail;
        // size: 0x3
        public enum UseCorePartsOnlyEnum : uint {
            False,
            True,
            DontCare,
        }
        /* 0x4 */ public UseCorePartsOnlyEnum UseCorePartsOnly;
    }
}
