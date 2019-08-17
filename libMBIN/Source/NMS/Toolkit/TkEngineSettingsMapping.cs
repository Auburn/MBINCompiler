﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0x5F0D049CCD180588, SubGUID = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        public float ShadowMultiplierLow;
        public float ShadowMultiplierNormal;
        public float ShadowMultiplierHigh;
        public float ShadowMultiplierUltra;
        public float ReflectionMultiplierLow;
        public float ReflectionMultiplierNormal;
        public float ReflectionMultiplierHigh;

        // boolean describing whether or not the game needs to restant when the specific setting has been changed... I think...
        [NMS(Size = 0x21, EnumValue = new[]{ "FullScreen", "Borderless", "ResolutionWidth", "ResolutionHeight", "Monitor",
           "FoVOnFoot", "FoVInShip", "VSync", "GSync", "ShadowDetail", "TextureDetail", "GenerationDetail", "ReflectionsQuality",
           "AntiAliasing", "MotionBlurQuality", "AnisotropyLevel", "Brightness", "AvailableMonitors", "MaxFrameRate", "NumLowThreads",
           "NumHighThreads", "TextureStreaming", "TexturePageSizeKb", "MotionBlurStrength", "ShowRequirementsWarnings", "AmbientOcclusion",
           "UseLightshafts", "MaxTextureMemoryMb", "FixedTextureMemory", "EnableTessellation", "UseArbSparseTexture", "TerrainQuality",
           "UseTerrainTextureCache"})]
        public bool[] NeedsGameRestart;
    }
}
