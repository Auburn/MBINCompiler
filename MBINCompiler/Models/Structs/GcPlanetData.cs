using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcPlanetData : NMSTemplate
    {
        /* 0x000 */
        private string Name; // 0x80
                             /* 0x080 */
        private int LifeSetting; // Dead / Low / Mid / Full

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x78)]
        /* 0x088 */
        public byte[] Hazard; // todo: GcPlanetHazardData

                              /* 0x100 */
        public int ResourceLevel; // Low / High
                                  /* 0x104 */
        public int BuildingDensity; // todo: GcBuildingDensityLevels
    }
}