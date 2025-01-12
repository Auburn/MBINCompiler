using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB9D61CFC45A85BA, NameHash = 0x80538FB9394B74CA)]
    public class GcBaseBuildingFamily : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public List<NMSString0x10> ObjectIDs;
        // size: 0x2
        public enum FamilyTypeEnum : uint {
            Replacements,
            Extras,
        }
        /* 0x20 */ public FamilyTypeEnum FamilyType;
    }
}
