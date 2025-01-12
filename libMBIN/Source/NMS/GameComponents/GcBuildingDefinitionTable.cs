using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x175C5070792E2044, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x1810 */ public List<GcBuildingClusterLayout> ClusterLayouts;
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1820 */ public GcBuildingFilenameList[] BuildingFiles;
    }
}
