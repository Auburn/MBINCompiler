using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEF32A99A1BE66F73, NameHash = 0xE09F11724D654285)]
    public class TkLSystemRule : NMSTemplate
    {
        /* 0x00 */ public List<TkLSystemInnerRule> Rules;
        // size: 0x2
        public enum RuleTypeEnum : uint {
            Default,
            BaseRule,
        }
        /* 0x10 */ public RuleTypeEnum RuleType;
        /* 0x14 */ public NMSString0x80 Model;
        /* 0x94 */ public NMSString0x20 Name;
    }
}
