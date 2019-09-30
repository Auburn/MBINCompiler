﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24, GUID = 0x69B0DB0BE1574A11, SubGUID = 0x88FA9D134F35E97B)]
    public class GcPunctuationDelay : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Punctuation;
        public float Delay;
    }
}