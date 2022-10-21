using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8D9ECBBBB009F22D, NameHash = 0x95C306B1A90F3E08)]
    public class GcUIGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool ShowDifficultyForBases;
        /* 0x0001 */ public bool ShowPadlockForLockedSettings;
        /* 0x0004 */ public int DebugMedalRank;
        /* 0x0008 */ public TkCurveType PadCursorUICurve;
        /* 0x0010 */ public Colour JoaoBoxCompletedObjectiveColour;
        /* 0x0020 */ public Colour InvSlotGradientBaseColour;
        /* 0x0030 */ public float InvSlotGradientFactorMin;
        /* 0x0034 */ public float InvSlotGradientFactor;
        /* 0x0038 */ public float InvSlotGradientTime;
        /* 0x0040 */ public Colour SuperchargePopupColour;
        /* 0x0050 */ public Colour SuperchargeGradientBaseColour;
        /* 0x0060 */ public Colour SuperchargeGradientBlendColour;
        /* 0x0070 */ public Colour SuperchargeGradientTechColour;
        /* 0x0080 */ public float SuperchargeGradientFactorMin;
        /* 0x0084 */ public float SuperchargeGradientFactor;
        /* 0x0088 */ public float SuperchargeGradientTime;
        /* 0x008C */ public float GridDecayRateSwitchValue;
        /* 0x0090 */ public float PadCursorUICurveStrength;
        /* 0x0094 */ public bool ReplaceItemBarWithNumbers;
        /* 0x0098 */ public NMSString0x10 DebugInventoryHint;
        /* 0x00A8 */ public int MaxSubstanceMaxAmountForAmountFraction;
        /* 0x00AC */ public bool UseSquareSlots;
        /* 0x00AD */ public bool BigPicking;
        /* 0x00AE */ public bool BigPickingUsesNumbers;
        /* 0x00B0 */ public float FreighterMegaWarpTransitionTime;
        /* 0x00B4 */ public bool EnablePopupUses;
        /* 0x00B5 */ public bool TechBoxesCanStack;
        /* 0x00B8 */ public int UnknownWordsToShowInCatalogue;
        /* 0x00BC */ public bool UseIntermediateMissionGiverOptions;
        /* 0x00C0 */ public float SentinelsDisabledHUDMessageTime;
        /* 0x00C4 */ public float UseZoomedOutBuildCamRadius;
        /* 0x00C8 */ public float ParagraphAutoScrollSpeed;
        /* 0x00CC */ public bool AutoScrollParagraphs;
        /* 0x00D0 */ public float EggModifiyAnimMaxSize;
        /* 0x00D4 */ public float EggModifiyAnimLoopTime;
        /* 0x00D8 */ public int SeasonFinalStageIndex;
        /* 0x00E0 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        /* 0x00F0 */ public float SeasonalRingMultiplier;
        /* 0x00F4 */ public float SeasonalRingPulseTime;
        /* 0x00F8 */ public float SeasonalRingChangeTime;
        /* 0x00FC */ public float MinSeasonPlayTimeInDays;
        /* 0x0100 */ public float ExpeditionStageChangeTime;
        /* 0x0104 */ public float MilestoneStingDisplayTime;
        /* 0x0108 */ public float StageStingDisplayTime;
        /* 0x010C */ public float EndOfSeasonAlertDelay;
        /* 0x0110 */ public int ShowHoursIfLessThan;
        /* 0x0114 */ public int ShowDaysIfLessThan;
        /* 0x0118 */ public int ShowWeeksIfLessThan;
        /* 0x0120 */ public NMSString0x10 ExplorationLogMissionID;
        /* 0x0130 */ public int ForceOpenHazardProtInventoryThreshold;
        /* 0x0134 */ public float PlanetDataExtraRadius;
        /* 0x0138 */ public float StackSizeRateChangeRate;
        /* 0x013C */ public float StackSizeChangeMinRate;
        /* 0x0140 */ public float StackSizeChangeMaxRate;
        /* 0x0144 */ public float ClosestDoorMarkerBuffer;
        /* 0x0148 */ public bool SkipShopIntro;
        /* 0x014C */ public float ZoomFactorOverride;
        /* 0x0150 */ public float HandheldZoomFactor;
        /* 0x0154 */ public float PlacedMarkerFadeTime;
        /* 0x0158 */ public float LoadingTravelDistance;
        /* 0x015C */ public float LoadingScreenTravelSpeed;
        /* 0x0160 */ public float LoadingScreenTime;
        /* 0x0164 */ public float OSDMessagePauseOffscreenAngle;
        /* 0x0168 */ public float QuickMenuCentrePos;
        /* 0x016C */ public float QuickMenuSideOffset;
        /* 0x0170 */ public float QuickMenuCentreSideOffset;
        /* 0x0174 */ public float InWorldInteractLabelScale;
        /* 0x0178 */ public float InWorldScreenScaleDistance;
        /* 0x017C */ public Vector2f InWorldInteractLabelAlignment;
        /* 0x0190 */ public Vector3f InWorldInteractLabelCentreOffset;
        /* 0x01A0 */ public Vector3f InWorldInteractLabelTopOffset;
        /* 0x01B0 */ public Vector3f InWorldInteractLabelLineOffset;
        /* 0x01C0 */ public float InWorldInteractLabelMinHeadOffset;
        /* 0x01C4 */ public float InWorldInteractLabelNearDistance;
        /* 0x01C8 */ public float InWorldInteractLabelNearRange;
        /* 0x01CC */ public float InWorldInteractLabelFarDistance;
        /* 0x01D0 */ public float InWorldInteractLabelFarRange;
        /* 0x01D4 */ public float ShipHUDMarkerHideDistance;
        /* 0x01D8 */ public float ShipHUDMarkerOffset;
        /* 0x01DC */ public float ExocraftHUDMarkerHideDistance;
        /* 0x01E0 */ public float ExocraftHUDMarkerOffset;
        /* 0x01E4 */ public float PetSlotUnlockBounceTime;
        /* 0x01E8 */ public float PetHUDMarkerExtraFollowInfoDistance;
        /* 0x01EC */ public float PetHUDMarkerHideDistance;
        /* 0x01F0 */ public float PetHUDMarkerHideDistanceShort;
        /* 0x01F4 */ public float PetHUDMarkerOffset;
        /* 0x01F8 */ public float PetMoodMarkerOffset;
        /* 0x01FC */ public float BeaconHUDMarkerOffset;
        /* 0x0200 */ public Vector2f BinocularEdgeFade;
        /* 0x0208 */ public float BinocularScreenOffset;
        /* 0x020C */ public float BinocularScreenScale;
        /* 0x0210 */ public float BinocularMarkerSideAngle;
        /* 0x0214 */ public float BinocularMarkerUpAngle;
        /* 0x0218 */ public bool BinocularScanScreen;
        /* 0x021C */ public float BinocularsNearIconOpacity;
        /* 0x0220 */ public float BinocularsNearIconDist;
        /* 0x0224 */ public float BinocularsNearIconFadeDist;
        /* 0x0228 */ public float BinocularsMidIconOpacity;
        /* 0x022C */ public float BinocularsFarIconOpacity;
        /* 0x0230 */ public float BinocularsFarIconDist;
        /* 0x0234 */ public float BinocularsFarIconFadeDist;
        /* 0x0238 */ public float AlignmentRequiredToDisableFrostedGlass;
        /* 0x0240 */ public Vector3f BinocularPanelLinePointOffset;
        /* 0x0250 */ public float FrontendOffsetVR;
        /* 0x0254 */ public float ProjectorScale;
        /* 0x0258 */ public float CockpitGlassFrostTime;
        /* 0x025C */ public float CockpitGlassDefrostTime;
        /* 0x0260 */ public float TextPrintoutMultiplier;
        /* 0x0264 */ public float TextPrintoutMultiplierAlien;
        /* 0x0268 */ public bool EnableHandMenuButtons;
        /* 0x0269 */ public bool AllowInWorldDebugBorders;
        /* 0x026C */ public Vector2f MarkerDistanceVRAlignment;
        /* 0x0274 */ public float CompassIconOffsetVR;
        /* 0x0278 */ public float LowerHelmetScreenScale;
        /* 0x027C */ public float LowerHelmetScreenPitch;
        /* 0x0280 */ public Vector3f LowerHelmetScreenOffset;
        /* 0x0290 */ public float InWorldScreenMinScreenDistance;
        /* 0x0294 */ public float InWorldScreenForwardOffset;
        /* 0x0298 */ public float InWorldNGuiScreenScale;
        /* 0x02A0 */ public Vector3f InWorldNGuiScreenRotation;
        /* 0x02B0 */ public Vector2f InWorldNGuiParallax;
        /* 0x02B8 */ public Vector2f InWorldGameGuiAlignment;
        /* 0x02C0 */ public int InWorldInteractLabelWidth;
        /* 0x02C4 */ public int InWorldInteractLabelHeight;
        /* 0x02C8 */ public NMSString0x20 VRDistanceWarningUIFile;
        /* 0x02E8 */ public bool ShowVRDistanceWarning;
        /* 0x02F0 */ public Vector3f FaceLockedScreenOffset;
        /* 0x0300 */ public int VRFaceLockedScreenWidth;
        /* 0x0304 */ public int VRFaceLockedScreenHeight;
        /* 0x0308 */ public bool OnlyShowEjectHandlesInVR;
        /* 0x030C */ public int CompassScreenWidth;
        /* 0x0310 */ public int CompassScreenHeight;
        /* 0x0314 */ public float CompassLineContractionStartAngle;
        /* 0x0318 */ public float CompassLineContractionEndAngle;
        /* 0x031C */ public float CompassLineContractionTargetAngle;
        /* 0x0320 */ public int CompassLineNumNotches;
        /* 0x0324 */ public float CompassLineThickness;
        /* 0x0328 */ public float CompassLineOffset;
        /* 0x032C */ public float CompassLineNotchAngleRange;
        /* 0x0330 */ public float CompassLineNotchThickness;
        /* 0x0334 */ public float CompassLineNotchLength;
        /* 0x0338 */ public bool EnableHandMenuDebug;
        /* 0x033C */ public float HandControlMenuCursorScale;
        /* 0x0340 */ public float QuickMenuCursorScale;
        /* 0x0344 */ public float QuickMenuAlpha;
        /* 0x0348 */ public float HandScreenGraphicsWidth;
        /* 0x034C */ public float HandScreenGraphicsHeight;
        /* 0x0350 */ public float HandScreenNearActivateDistance;
        /* 0x0354 */ public float HandButtonRadius;
        /* 0x0358 */ public float HandButtonRadiusTouch;
        /* 0x035C */ public float HandButtonRadiusTouchNear;
        /* 0x0360 */ public float HandButtonRadiusTouchNearActive;
        /* 0x0364 */ public float HandButtonPostClickTime;
        /* 0x0368 */ public float HandButtonReleaseThreshold;
        /* 0x036C */ public float HandButtonReleaseThresholdInit;
        /* 0x0370 */ public float HandButtonCursorScale;
        /* 0x0374 */ public float HandButtonPushDistance;
        /* 0x0378 */ public float HandButtonNearDistance;
        /* 0x037C */ public float HandButtonRadiusClick;
        /* 0x0380 */ public float HandButtonClickTime;
        /* 0x0384 */ public float HandButtonTouchReturnTime;
        /* 0x0388 */ public float HandButtonFrontendCursorScale;
        /* 0x038C */ public float HandButtonThickness;
        /* 0x0390 */ public float HandButtonDotRadius;
        /* 0x0394 */ public float HandButtonPulseRadius;
        /* 0x0398 */ public float HandButtonPulseThickness;
        /* 0x039C */ public float ShipSideScreenHeight;
        /* 0x03A0 */ public float SolidPointerScale;
        /* 0x03A4 */ public float SolidPointerLengthScale;
        /* 0x03A8 */ public float SolidPointerMaxLength;
        /* 0x03AC */ public float InWorldInteractionScreenScale;
        /* 0x03B0 */ public float InWorldNPCInteractionScreenScale;
        /* 0x03B4 */ public bool EnableCraftingTree;
        /* 0x03B5 */ public bool QuickMenuEnableSwipe;
        /* 0x03B8 */ public float QuickMenuSwipeHeightMin;
        /* 0x03BC */ public float QuickMenuSwipeHeightMax;
        /* 0x03C0 */ public float BuildMenuItemNavAnimTime;
        /* 0x03C4 */ public float BuildMenuItemNextNavAnimTime;
        /* 0x03C8 */ public float BuildMenuItemNextNavAnimWait;
        /* 0x03CC */ public float QuickMenuInteractAdjustX;
        /* 0x03D0 */ public float QuickMenuInteractAdjustY;
        /* 0x03D4 */ public int QuickMenuScreenWidth;
        /* 0x03D8 */ public int QuickMenuScreenHeight;
        /* 0x03DC */ public float QuickMenuHighlightRate;
        /* 0x03E0 */ public float HandControlButtonSize;
        /* 0x03E4 */ public float HandControlPointMargin;
        /* 0x03E8 */ public float HandControlPointActiveMargin;
        /* 0x03EC */ public float HandControlMenuMoveDistance;
        /* 0x03F0 */ public float HandControlMenuMoveDistanceScroll;
        /* 0x03F4 */ public float HandControlMenuMoveDistanceVertical;
        /* 0x03F8 */ public float HandControlMenuMoveActionDistance;
        /* 0x03FC */ public float HandControlMenuAngle;
        /* 0x0400 */ public float HandControlMenuSurfaceOffset;
        /* 0x0404 */ public float HandControlMenuSelectRadius;
        /* 0x0408 */ public float HandControlMenuSelectRadius1;
        /* 0x040C */ public float HandControlMenuSelectRadius2;
        /* 0x0410 */ public float HandControlTopMenuSelectRadius;
        /* 0x0414 */ public int HandScreenWeaponWidth;
        /* 0x0418 */ public int HandScreenWeaponHeight;
        /* 0x041C */ public int HandScreenWidth;
        /* 0x0420 */ public int HandScreenHeight;
        /* 0x0430 */ public Colour DebugEditorAxisColourUpInactive;
        /* 0x0440 */ public Colour DebugEditorAxisColourUpActive;
        /* 0x0450 */ public Colour DebugEditorAxisColourRightInactive;
        /* 0x0460 */ public Colour DebugEditorAxisColourRightActive;
        /* 0x0470 */ public Colour DebugEditorAxisColourAtInactive;
        /* 0x0480 */ public Colour DebugEditorAxisColourAtActive;
        /* 0x0490 */ public Colour QuickMenuSelectedItemColour1;
        /* 0x04A0 */ public Colour QuickMenuSelectedItemColour2;
        /* 0x04B0 */ public TkModelRendererData ShipThumbnailModelView;
        /* 0x0560 */ public TkModelRendererData PetThumbnailModelView;
        /* 0x0610 */ public TkModelRendererData MultitoolThumbnailModelView;
        /* 0x06C0 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        /* 0x0770 */ public Colour FrontendCursorBackgroundColour;
        /* 0x0780 */ public float NGuiHmdOffset;
        /* 0x0784 */ public float HmdFramerateScreenPitch;
        /* 0x0790 */ public Vector3f HmdFramerateScreenOffset;
        /* 0x07A0 */ public float CrosshairScaleHmd;
        /* 0x07A4 */ public float CrosshairOffsetHmd;
        /* 0x07A8 */ public float CrosshairOffsetHmdUp;
        /* 0x07AC */ public int CrosshairScreenWidth;
        /* 0x07B0 */ public int CrosshairScreenHeight;
        /* 0x07B4 */ public float HUDMarkerHoverAngleTestGroundHmd;
        /* 0x07B8 */ public float HUDMarkerWideHoverAngleTestHmd;
        /* 0x07BC */ public bool InteractionInWorldPlayerCamAlways;
        /* 0x07C0 */ public float InteractionInWorldPitchDistance;
        /* 0x07C4 */ public float InteractionInWorldMinScreenDistance;
        /* 0x07C8 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        /* 0x07CC */ public float TravelTargetRadius;
        /* 0x07D0 */ public float TravelLineThickness;
        /* 0x07E0 */ public Colour TravelLineColour;
        /* 0x07F0 */ public Colour TravelLineTooFarColour;
        /* 0x0800 */ public Colour TravelLineTooSteepColour;
        /* 0x0810 */ public Colour TravelLineInvalidColour;
        /* 0x0820 */ public Colour TravelLineNotAllowedColour;
        /* 0x0830 */ public Colour TravelTargetColour;
        /* 0x0840 */ public bool AlwaysCloseQuickMenu;
        /* 0x0841 */ public bool UseWorldNodesForRepair;
        /* 0x0842 */ public bool RepairTechUseTechIcon;
        /* 0x0843 */ public bool DebugMissionLogText;
        /* 0x0844 */ public bool DebugShowMaintenanceScreenCentre;
        /* 0x0845 */ public bool DebugPopupSizes;
        /* 0x0846 */ public bool DebugInventoryIndices;
        /* 0x0847 */ public bool FixedInventoryIconPositions;
        /* 0x0850 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        /* 0x08B0 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        /* 0x0910 */ public float OSDMessageQueueSpeedMultiplier;
        /* 0x0914 */ public int OSDMessageQueueMin;
        /* 0x0918 */ public int OSDMessageQueueMax;
        /* 0x091C */ public float PopupValueSectionBaseHeight;
        /* 0x0920 */ public float PopupValueSectionHeight;
        /* 0x0930 */ public Colour ProcProductColourCommon;
        /* 0x0940 */ public Colour ProcProductColourUncommon;
        /* 0x0950 */ public Colour ProcProductColourRare;
        /* 0x0960 */ public List<Vector2f> InventoryIconPositions;
        /* 0x0970 */ public Colour PickedItemBorderColour;
        /* 0x0980 */ public Colour MultiplayerMissionParticipantsColour;
        /* 0x0990 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        /* 0x09A0 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        /* 0x09B0 */ public float NotificationHazardMinTimeAfterRecharge;
        /* 0x09B4 */ public float LoadFadeInDefaultTime;
        /* 0x09B8 */ public float DroneIndicatorRadius;
        /* 0x09BC */ public float DroneIndicatorCentreRadiusMax;
        /* 0x09C0 */ public float DroneIndicatorCentreRadiusMin;
        /* 0x09C4 */ public float DroneIndicatorFadeRange;
        /* 0x09C8 */ public float WantedDetectMessageTime;
        /* 0x09CC */ public float WantedDetectMinTimeout;
        /* 0x09D0 */ public float TakeoffFuelMessageTime;
        /* 0x09D4 */ public float MarkerHorizonOffsetAngle;
        /* 0x09D8 */ public float MarkerHorizonMinOffset;
        /* 0x09DC */ public float MarkerHorizonApproachAngle;
        /* 0x09E0 */ public float MarkerOffsetTypeAngle;
        /* 0x09E4 */ public float MarkerOffsetTypeAngleBattle;
        /* 0x09E8 */ public float MarkerOffsetTypeAngleBounty;
        /* 0x09EC */ public float MarkerOffsetTypeAnglePlayerShip;
        /* 0x09F0 */ public float MarkerOffsetTypeAngleAsteroid;
        /* 0x09F4 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        /* 0x09F8 */ public float MarkerHorizonShipApproachOffset;
        /* 0x09FC */ public float TransferPopupCursorOffsetFactor;
        /* 0x0A00 */ public float ScannableIconMergeAngle;
        /* 0x0A04 */ public float CreatureIconMergeAngle;
        /* 0x0A08 */ public int MaxNumMessageBeaconIcons;
        /* 0x0A0C */ public float MissionObjectiveBaseHeight;
        /* 0x0A10 */ public float MissionObjectiveDoneHeight;
        /* 0x0A14 */ public float MissionDetailsPageBaseHeight;
        /* 0x0A18 */ public float MarkerTagAppearDelay;
        /* 0x0A1C */ public Vector2f CompassCentre;
        /* 0x0A24 */ public float CompassHeight;
        /* 0x0A28 */ public float CompassWidth;
        /* 0x0A2C */ public float CompassDistanceScaleMin;
        /* 0x0A30 */ public float CompassDistanceScaleRange;
        /* 0x0A34 */ public float CompassDistanceSpaceScaleMin;
        /* 0x0A38 */ public float CompassDistanceSpaceScaleRange;
        /* 0x0A3C */ public float CompassDistanceScale;
        /* 0x0A40 */ public float CompassDistanceShipMinScale;
        /* 0x0A44 */ public float CompassDistanceMaxAngle;
        /* 0x0A48 */ public float CompassDistanceYOffset;
        /* 0x0A4C */ public float CompassAngleClamp;
        /* 0x0A50 */ public float CompassAngleFade;
        /* 0x0A54 */ public TkCurveType CompassCurve;
        /* 0x0A58 */ public float CompassAngleClampSpace;
        /* 0x0A5C */ public float BaseComplexityDangerFactor;
        /* 0x0A60 */ public float BaseComplexityWarningFactor;
        /* 0x0A70 */ public Colour BaseComplexityDefaultColour;
        /* 0x0A80 */ public Colour BaseComplexityWarningColour;
        /* 0x0A90 */ public Colour BaseComplexityDangerColour;
        /* 0x0AA0 */ public float BuildMenuActionMessageDuration;
        // size: 0x10
        public enum BuildMenuOnActionLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionLocIDsEnum))]
        /* 0x0AA8 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        // size: 0x10
        public enum BuildMenuOnActionDisabledLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionDisabledLocIDsEnum))]
        /* 0x0CA8 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        // size: 0x10
        public enum BuildMenuOnActionErrorLocIDsEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuOnActionErrorLocIDsEnum))]
        /* 0x0EA8 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        // size: 0x10
        public enum BuildMenuUseSmallIconOnPadEnum {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode
        }
        [NMS(Size = 0x10, EnumType = typeof(BuildMenuUseSmallIconOnPadEnum))]
        /* 0x10A8 */ public bool[] BuildMenuUseSmallIconOnPad;
        /* 0x10C0 */ public Colour BuildMenuPassiveErrorTextColour;
        /* 0x10D0 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        /* 0x10E0 */ public Colour BuildMenuErrorTextColour;
        /* 0x10F0 */ public Colour BuildMenuErrorTextOutlineColour;
        /* 0x1100 */ public Colour BuildMenuErrorTextFlashColour;
        /* 0x1110 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        /* 0x1120 */ public Colour BuildMenuInfoTextColour;
        /* 0x1130 */ public Colour BuildMenuInfoTextOutlineColour;
        /* 0x1140 */ public float IconGlowStrengthError;
        /* 0x1144 */ public float IconGlowStrengthActive;
        /* 0x1148 */ public float IconGlowStrengthNeutral;
        /* 0x114C */ public float IconGlowStrengthHighlight;
        /* 0x1150 */ public Colour IconGlowColourError;
        /* 0x1160 */ public Colour IconGlowColourActive;
        /* 0x1170 */ public Colour IconGlowColourNeutral;
        /* 0x1180 */ public Colour IconGlowColourHighlight;
        /* 0x1190 */ public float BaseBuildingPinHighlightDuration;
        /* 0x1194 */ public float BaseBuildingInputHighlightDuration;
        /* 0x1198 */ public float BaseBuildingInputHighlightAlpha;
        /* 0x119C */ public float BaseBuildingScaleSpeed;
        /* 0x11A0 */ public float BaseBuildingMinFreeRotateSpeed;
        /* 0x11A4 */ public float BaseBuildingMaxFreeRotateSpeed;
        /* 0x11A8 */ public float BaseBuildingTimeToMaxRotationSpeed;
        /* 0x11AC */ public float BaseBuildingRotationResetRate;
        /* 0x11B0 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        /* 0x11B4 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        /* 0x11B8 */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        /* 0x11BC */ public bool BaseBuildingSmoothMenuWhileSnapped;
        /* 0x11C0 */ public float BaseBuildingUIHorizontalSafeArea;
        /* 0x11C4 */ public float BaseBuildingUIVerticalSafeArea;
        /* 0x11C8 */ public float BaseBuildingUIVerticalPosWiring;
        /* 0x11CC */ public float BaseBuildingUIVerticalOffset;
        /* 0x11D0 */ public float BaseBuildingUIVerticalOffsetEdit;
        /* 0x11D4 */ public float BaseBuildingUIVerticalOffsetFromBB;
        /* 0x11D8 */ public float BaseBuildingUIErrorFadeTime;
        /* 0x11DC */ public float BaseBuildingUIAdjustTime;
        /* 0x11E0 */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        /* 0x11E4 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        /* 0x11E8 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        /* 0x11EC */ public float BaseBuildingPartsGridScrollSpeed;
        /* 0x11F0 */ public float BaseBuildingPartsGridPopupDelay;
        /* 0x11F4 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        /* 0x1278 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        /* 0x12FC */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        /* 0x1380 */ public float MarkerRingInnerRadius;
        /* 0x1384 */ public float MarkerRingOuterRadius;
        /* 0x1390 */ public Colour MarkerRingBGColour;
        /* 0x13A0 */ public float RepairTechRepairedWaitTime1;
        /* 0x13A4 */ public float RepairTechRepairedWaitTime2;
        /* 0x13A8 */ public float RepairTechRepairedMessageTime;
        /* 0x13AC */ public float TechPopupRepairLayerHeight;
        /* 0x13B0 */ public float TechPopupBuildLayerHeight;
        /* 0x13B4 */ public float TechPopupRequirementHeight;
        /* 0x13B8 */ public float DamageTrackArrowTime;
        /* 0x13BC */ public bool EnableBlackouts;
        /* 0x13C0 */ public float HUDMarkerObjectMinScreenDistance;
        /* 0x13C4 */ public float HUDMarkerDistanceOrTimeDistance;
        /* 0x13C8 */ public float MarkerComponentOffset;
        /* 0x13CC */ public float RepairTechLabelOffset;
        /* 0x13D0 */ public float MaintenanceIconFadeStart;
        /* 0x13D4 */ public float MaintenanceIconFadeTime;
        /* 0x13E0 */ public TkModelRendererData RepairCamera;
        /* 0x1490 */ public TkModelRendererData RepairWeaponCamera;
        /* 0x1540 */ public TkModelRendererData RepairBackpackCamera;
        /* 0x15F0 */ public TkModelRendererData RepairShipCameraInWorld;
        /* 0x16A0 */ public TkModelRendererData RepairShipCameraModelView;
        /* 0x1750 */ public TkModelRendererData RepairShipCameraVR;
        /* 0x1800 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        /* 0x1810 */ public Vector2f BinocularsDiscoveryPos;
        /* 0x1820 */ public Colour InteractionLabelCostColour;
        /* 0x1830 */ public Colour InteractionLabelPickupColour;
        /* 0x1840 */ public Colour InteractionLabelPickupFillColour;
        /* 0x1850 */ public Vector2f PersonalRefinerInputPos;
        /* 0x1858 */ public Vector2f PersonalRefinerOutputPos;
        /* 0x1860 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        /* 0x18E4 */ public float RefinerPadStartTime;
        /* 0x18E8 */ public float RefinerPadStartDecayTime;
        /* 0x18EC */ public float RefinerBeginDialInnerRadius;
        /* 0x18F0 */ public float RefinerProgressDialInnerRadius;
        /* 0x1900 */ public Vector3f DefaultRefinerOffsetIn;
        /* 0x1910 */ public Vector3f DefaultRefinerOffsetOut;
        /* 0x1920 */ public Vector2f RefinerParallax;
        /* 0x1928 */ public Vector2f ModelViewWorldParallax;
        /* 0x1930 */ public Vector2f HUDPlayerSentinelPulseFreq;
        /* 0x1938 */ public Vector2f HUDPlayerSentinelPulseSize;
        /* 0x1940 */ public float HUDPlayerSentinelPulseWidth;
        /* 0x1944 */ public float HUDPlayerSentinelRangeFactor;
        /* 0x1948 */ public float HUDPlayerSentinelPulseScanFreq;
        /* 0x194C */ public float HUDPlayerPhonePulseScanFreq;
        /* 0x1950 */ public float RefinerAutoCloseTime;
        /* 0x1960 */ public Colour RefinerBackgroundColour;
        /* 0x1970 */ public Colour RefinerErrorBackgroundColour;
        /* 0x1980 */ public Colour GridDisconnectedColour;
        /* 0x1990 */ public Colour GridOnlineColour;
        /* 0x19A0 */ public Colour GridOfflineColour;
        /* 0x19B0 */ public Colour GridBackgroundNeutralColour;
        /* 0x19C0 */ public Colour GridBackgroundPositiveColour;
        /* 0x19D0 */ public Colour GridBackgroundNegativeColour;
        /* 0x19E0 */ public Colour TransferSendPopupColour;
        /* 0x19F0 */ public float BountyMarkerOffset;
        /* 0x19F4 */ public float PlanetRaidMarkerOffset;
        /* 0x19F8 */ public float TransitionOffset;
        /* 0x19FC */ public float PageTurnTime;
        /* 0x1A00 */ public TkCurveType PageTurnCurve;
        /* 0x1A04 */ public TkCurveType PageTurnFadeCurve;
        /* 0x1A08 */ public float LowHealthShieldMin;
        /* 0x1A0C */ public float LowHealthShieldFactor;
        /* 0x1A10 */ public int MaxDialogCharSizeRoman;
        /* 0x1A14 */ public NMSString0x20 MaxDialogCharSizeRomanString;
        /* 0x1A34 */ public int MaxDialogCharSizeIdeographic;
        /* 0x1A38 */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        /* 0x1A58 */ public float ShipOverheatSwitchMessageWait;
        /* 0x1A5C */ public float ShipOverheatSwitchMessageTime;
        /* 0x1A60 */ public bool LeadTargetEnabled;
        /* 0x1A61 */ public bool SpaceOnlyLeadTargetEnabled;
        /* 0x1A64 */ public Vector2f SaveIconPosition;
        /* 0x1A6C */ public float MissionStartEndTime;
        /* 0x1A70 */ public float MissionStartEndOSDTime;
        /* 0x1A74 */ public float MissionStartEndOSDTimeProcedural;
        /* 0x1A78 */ public float StandingRewardOSDTime;
        /* 0x1A80 */ public Colour MissionOSDMessageBarColour;
        /* 0x1A90 */ public Colour NotificationDefaultColour;
        /* 0x1AA0 */ public Colour NotificationDangerColour;
        /* 0x1AB0 */ public Colour NotificationInfoColour;
        /* 0x1AC0 */ public Colour NotificationUrgentColour;
        /* 0x1AD0 */ public float ShipDamageDirectionIndicatorRadius;
        /* 0x1AD4 */ public float ShipDamageDirectionIndicatorFadeRange;
        /* 0x1AD8 */ public float OnFootDamageDirectionIndicatorRadius;
        /* 0x1ADC */ public float OnFootDamageDirectionIndicatorFadeRange;
        /* 0x1AE0 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        /* 0x1AE4 */ public Vector2f DialogPageCursorOffset;
        /* 0x1AEC */ public Vector2f IntermediateInteractionPageCursorOffset;
        /* 0x1AF4 */ public Vector2f CursorlessDialogPageCursorOffset;
        /* 0x1AFC */ public int MissionSpecificMissionPercent;
        /* 0x1B00 */ public int MissionLoopCount;
        /* 0x1B04 */ public int MissionSeedOffset;
        /* 0x1B10 */ public Vector3f SpaceMapCockpitOffset;
        /* 0x1B20 */ public float SpaceMapCockpitScale;
        /* 0x1B24 */ public float SpaceMapCockpitScaleAdjustDropShip;
        /* 0x1B28 */ public float SpaceMapCockpitScaleAdjustFighter;
        /* 0x1B2C */ public float SpaceMapCockpitScaleAdjustScientific;
        /* 0x1B30 */ public float SpaceMapCockpitScaleAdjustShuttle;
        /* 0x1B34 */ public float SpaceMapCockpitScaleAdjustRoyal;
        /* 0x1B38 */ public float SpaceMapCockpitScaleAdjustSail;
        /* 0x1B3C */ public float SpaceMapCockpitScaleAdjustAlien;
        /* 0x1B40 */ public float SpaceMapCockpitAngle;
        /* 0x1B44 */ public float TargetDisplayScale;
        /* 0x1B48 */ public float TargetDisplayShipScale;
        /* 0x1B50 */ public Vector3f TargetDisplayShipOffset;
        /* 0x1B60 */ public float TargetDisplayDamageFlashTime;
        /* 0x1B70 */ public GcScanEffectData TargetDisplayScanEffect;
        /* 0x1BC0 */ public bool ProgressiveDialogStyle;
        /* 0x1BC4 */ public float CommunicatorMessageTime;
        /* 0x1BD0 */ public Colour CommunicatorMessageColour;
        /* 0x1BE0 */ public float GridFlickerBaseAlpha;
        /* 0x1BE4 */ public float GridFlickerFreq;
        /* 0x1BE8 */ public float GridFlickerAmp;
        /* 0x1BEC */ public float HUDMarkerLabelWidthMultiplier;
        /* 0x1BF0 */ public float HUDMarkerLabelBaseWidth;
        /* 0x1BF4 */ public float HUDMarkerLabelArriveDistance;
        /* 0x1BF8 */ public float HUDMarkerLabelDisplayDistance;
        /* 0x1BFC */ public float HUDMarkerNonActiveMissionAlpha;
        /* 0x1C00 */ public bool DebugMarkerLabels;
        /* 0x1C10 */ public GcScanEffectData DebugEditorPreviewEffect;
        /* 0x1C60 */ public bool ShowDamageNumbers;
        /* 0x1C64 */ public float QuickMenuCloseTime;
        /* 0x1C68 */ public float QuickMenuErrorTime;
        /* 0x1C6C */ public float FrontendWaitResponse;
        /* 0x1C70 */ public float FrontendWaitInitial;
        /* 0x1C74 */ public float FrontendWaitInitialTerminal;
        /* 0x1C78 */ public float FrontendWaitFadeTextOut;
        /* 0x1C7C */ public float FrontendWaitFadeTextFrameOut;
        /* 0x1C80 */ public float FrontendWaitFadeProgressiveDialogOut;
        /* 0x1C84 */ public float FrontendWaitResponseOffset;
        /* 0x1C88 */ public float TalkBoxAlienTextSpeed;
        /* 0x1C8C */ public float TalkBoxAlienTextTimeMin;
        /* 0x1C90 */ public float TalkBoxAlienTextTimeMax;
        /* 0x1C94 */ public float DescriptionTextDelay;
        /* 0x1C98 */ public float DescriptionTextSpeed;
        /* 0x1C9C */ public float DescriptionTextSpeedProgressive;
        /* 0x1CA0 */ public float DescriptionTextTimeMin;
        /* 0x1CA4 */ public float DescriptionTextTimeMax;
        /* 0x1CA8 */ public float ConsoleTextSpeed;
        /* 0x1CAC */ public float ConsoleTextTimeMin;
        /* 0x1CB0 */ public float ConsoleTextTimeMax;
        /* 0x1CB4 */ public float HoverOffscreenBorder;
        /* 0x1CB8 */ public float HoverOffscreenBorderVR;
        /* 0x1CBC */ public float TransferSendOffscreenBorder;
        /* 0x1CC0 */ public float TimedEventLookTime;
        /* 0x1CC4 */ public float CreatureDistanceSize;
        /* 0x1CC8 */ public float CreatureDistanceOffsetY;
        /* 0x1CCC */ public float CreatureDistanceShadowOffset;
        /* 0x1CD0 */ public float CreatureDistanceDisplayAngle;
        /* 0x1CD4 */ public float CreatureDistanceFadeTime;
        /* 0x1CD8 */ public float CreatureDistanceAlpha;
        /* 0x1CDC */ public bool ShowOnscreenPredatorMarkers;
        /* 0x1CE0 */ public float DamageImpactMergeTime;
        /* 0x1CE4 */ public float DamageImpactTimeBetweenNumbers;
        /* 0x1CE8 */ public float DamageImpactMinDistance;
        /* 0x1CEC */ public float DamagePerSecondSampleTime;
        /* 0x1CF0 */ public float DamageNumberTime;
        /* 0x1CF4 */ public float DamageNumberSizeInShip;
        /* 0x1CF8 */ public float DamageNumberSize;
        /* 0x1CFC */ public float DamageNumberSizeCritMultiplier;
        /* 0x1D00 */ public float DamageNumberSizeLaserMultiplier;
        /* 0x1D04 */ public float DamageNumberLaserMinDamage;
        /* 0x1D08 */ public float DamageNumberLaserMaxDamage;
        /* 0x1D0C */ public float DamageNumberBlackAlpha;
        /* 0x1D10 */ public float DamageNumberOutline;
        /* 0x1D14 */ public float DamageNumberOutline2;
        /* 0x1D18 */ public float DamageNumberOffsetX;
        /* 0x1D1C */ public float DamageNumberOffsetY;
        /* 0x1D20 */ public Vector2f DamageNumberSideSpeed;
        /* 0x1D28 */ public float DamageNumberFadeIn;
        /* 0x1D2C */ public float DamageNumberFadeOut;
        /* 0x1D30 */ public float DamageNumberUpOffset;
        /* 0x1D34 */ public TkCurveType DamageNumberUpCurve;
        /* 0x1D40 */ public Colour DamageNumberCriticalColour;
        /* 0x1D50 */ public Colour DamageNumberIneffectiveColour;
        /* 0x1D60 */ public Colour DamageNumberIneffectiveWarningColour;
        /* 0x1D70 */ public Colour PhotoModeSelectedColour;
        /* 0x1D80 */ public Colour PhotoModeUnselectedColour;
        /* 0x1D90 */ public Colour FuelBgColour;
        /* 0x1DA0 */ public float PhotoModeValueAlpha;
        /* 0x1DA4 */ public float PhotoModeTimeofDayChange;
        /* 0x1DA8 */ public float FrigateIconOffset;
        /* 0x1DAC */ public float CreatureIconOffset;
        /* 0x1DB0 */ public float CreatureIconOffsetPhysics;
        /* 0x1DB4 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        /* 0x1DB8 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        /* 0x1DBC */ public float FreighterSummonTurn;
        /* 0x1DC0 */ public float FreighterSummonPitch;
        /* 0x1DC4 */ public float FreighterSummonOffset;
        /* 0x1DC8 */ public float FreighterSummonOffsetPulse;
        /* 0x1DCC */ public float FreighterSummonDelay;
        /* 0x1DD0 */ public int FreighterSummonTurnNumTries;
        /* 0x1DD4 */ public float FreighterSummonTurnAngleIncrement;
        /* 0x1DD8 */ public float FreighterSummonGridSize;
        /* 0x1DDC */ public float FreighterCommanderMarkerMinDistance;
        /* 0x1DE0 */ public float FreighterSurfaceMinAngle;
        /* 0x1DE4 */ public float FreighterSummonPulseRate;
        /* 0x1DE8 */ public float FreighterSummonPulseFadeAmount;
        /* 0x1DEC */ public float FreighterSummonPlanetOffset;
        /* 0x1DF0 */ public float FreighterSummonLookTime;
        /* 0x1DF4 */ public float FreighterHighlightRange;
        /* 0x1E00 */ public GcScanEffectData FreighterSummonScanEffect;
        /* 0x1E50 */ public Colour FreighterSummonScanEffectColourBlocked;
        /* 0x1E60 */ public Colour FreighterSummonScanEffectColourHighlight;
        /* 0x1E70 */ public float PirateCountdownTime;
        /* 0x1E74 */ public float PirateAttackIndicatorWidth;
        /* 0x1E78 */ public float PirateAttackIndicatorRadius;
        /* 0x1E7C */ public float PirateAttackProbeDisplayFinishFactor;
        /* 0x1E80 */ public float HazardArrowsLevel2Threshold;
        /* 0x1E84 */ public float HazardArrowsLevel3Threshold;
        /* 0x1E88 */ public float ArrowBounceLength;
        /* 0x1E8C */ public float ArrowBounceRate;
        /* 0x1E90 */ public float ArrowBounceRightRate1;
        /* 0x1E94 */ public float ArrowBounceRightRate2;
        /* 0x1E98 */ public TkCurveType ArrowBounceRightCurve;
        /* 0x1E9C */ public float ArrowBounceLeftRate1;
        /* 0x1EA0 */ public float ArrowBounceLeftRate2;
        /* 0x1EA4 */ public float ArrowBounceLeftRate3;
        /* 0x1EA8 */ public TkCurveType ArrowBounceLeftCurve;
        /* 0x1EAC */ public float PlanetScanDelayTime;
        /* 0x1EB0 */ public float AlwaysShowIconFadeDistance;
        /* 0x1EB4 */ public float AlwaysShowIconFadeRange;
        /* 0x1EB8 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        /* 0x1EBC */ public float FrigateDamageIconVisibilityDistance;
        /* 0x1EC0 */ public float FreighterLeaderIconDistance;
        /* 0x1EC4 */ public float FreighterEntranceOffset;
        /* 0x1EC8 */ public float ShipHeadsUpDisplayDistance;
        /* 0x1ECC */ public float ShipHeadsUpLineFadeTime;
        /* 0x1ED0 */ public float CrosshairAimTime;
        /* 0x1ED4 */ public float CrosshairAimOffTime;
        /* 0x1ED8 */ public float CrosshairInnerMinFade;
        /* 0x1EDC */ public float CrosshairInnerMinFadeRange;
        /* 0x1EE0 */ public float CrosshairLeadScaleIn;
        /* 0x1EE4 */ public float CrosshairLeadInDelay;
        /* 0x1EE8 */ public float CrosshairLeadInTime;
        /* 0x1EEC */ public float CrosshairLeadCornerOffset;
        /* 0x1EF0 */ public float CrosshairLeadTopOffset;
        /* 0x1EF4 */ public float CrosshairLeadTopLock;
        /* 0x1EF8 */ public float CrosshairLeadPulseSize;
        /* 0x1EFC */ public TkCurveType CrosshairLeadScaleCurve;
        /* 0x1F00 */ public float CrosshairSpringTime;
        /* 0x1F04 */ public float CrosshairSpringAimTime;
        /* 0x1F08 */ public float CrosshairLeadSpring;
        /* 0x1F0C */ public float CrosshairLeadSpringOff;
        /* 0x1F10 */ public float CrosshairLeadFadeRange;
        /* 0x1F14 */ public float CrosshairLeadFadeSize;
        /* 0x1F20 */ public Colour CrosshairLeadThreatColour;
        /* 0x1F30 */ public Colour CrosshairLeadPassiveColour;
        /* 0x1F40 */ public float CrosshairInterceptSize;
        /* 0x1F44 */ public float CrosshairInterceptBaseSize;
        /* 0x1F48 */ public float CrosshairInterceptCentreBaseSize;
        /* 0x1F4C */ public float CrosshairInterceptSpringTime;
        /* 0x1F50 */ public float CrosshairInterceptAlpha;
        /* 0x1F54 */ public float CrosshairInterceptLockRange;
        /* 0x1F58 */ public float CrosshairTargetLockSize;
        [NMS(Size = 0x13)]
        /* 0x1F5C */ public float[] CrosshairTargetLockSizeSpecific;
        /* 0x1FA8 */ public TkCurveType CrosshairTargetLockCurve;
        /* 0x1FAC */ public TkCurveType CrosshairTargetLockAlphaCurve;
        /* 0x1FB0 */ public Colour CrosshairColour;
        /* 0x1FC0 */ public TkHitCurveData CrosshairLeadHitCurve;
        /* 0x1FD0 */ public TkHitCurveData ShootableHitCurve;
        /* 0x1FE0 */ public int ControlScrollSteps;
        /* 0x1FE4 */ public float ControlScrollDistance;
        /* 0x1FF0 */ public Colour SelectedControlColour;
        /* 0x2000 */ public Colour RemappedControlColour;
        /* 0x2010 */ public float MissionCompassIconScaler;
        /* 0x2014 */ public float MissionMarkerSize;
        /* 0x2018 */ public float CreatureRoutineMarkerTime;
        /* 0x201C */ public int CreatureRoutineRegionsPerFrame;
        /* 0x2020 */ public float SpaceMarkersOffset;
        /* 0x2024 */ public float SpaceMarkersBattleOffset;
        /* 0x2028 */ public float LargeSpaceIconSize;
        /* 0x202C */ public float SmallSpaceIconSize;
        /* 0x2030 */ public float PetHoverIconSize;
        /* 0x2034 */ public float PetIconSize;
        /* 0x2038 */ public Vector2f TrackTypeIconOffset;
        /* 0x2040 */ public float TrackTypeIconSize;
        /* 0x2044 */ public float TrackPrimaryCentreOffset;
        /* 0x2048 */ public float TrackTimerAlpha;
        /* 0x204C */ public float TrackTimerRadarPulseSize;
        /* 0x2050 */ public float TrackTimerIconOuterRadius;
        /* 0x2054 */ public float TrackTimerIconInnerRadius;
        /* 0x2058 */ public float TrackTimerIconExclaimRadius;
        /* 0x205C */ public float MissileCentreOffset;
        /* 0x2060 */ public float TrackMissileTargetPulseRate;
        /* 0x2064 */ public float TrackScaleCritical;
        /* 0x2068 */ public float TrackScaleHit;
        /* 0x206C */ public float TrackLeadTargetInScale;
        /* 0x2070 */ public float TrackReticuleScale;
        /* 0x2074 */ public float TrackReticuleAngle;
        /* 0x2078 */ public float TrackReticuleInTime;
        /* 0x207C */ public float TrackReticuleInactiveTime;
        /* 0x2080 */ public float TrackReticuleRandomTime;
        /* 0x2084 */ public float TrackReticuleRandomDelay;
        /* 0x2088 */ public TkCurveType TrackReticuleInCurve;
        /* 0x208C */ public TkCurveType TrackReticuleInAngleCurve;
        /* 0x2090 */ public float CreatureReticuleScale;
        /* 0x2094 */ public TkCurveType CreatureReticuleScaleCurve;
        /* 0x2098 */ public TkCurveType CreatureReticuleAlphaCurve;
        /* 0x209C */ public bool CreatureInteractLabelUseBB;
        /* 0x20A0 */ public float CreatureInteractLabelOffsetY;
        /* 0x20A4 */ public float HUDDroneHealingPulse;
        /* 0x20A8 */ public float HUDDroneSummoningPulse;
        /* 0x20AC */ public float HUDDroneCombatPulse;
        /* 0x20B0 */ public float HUDPlayerTrackNoSightPulse;
        /* 0x20B4 */ public float HUDPlayerTrackTimerStart;
        /* 0x20B8 */ public float HUDPlayerTrackTimerStartFade;
        /* 0x20BC */ public float HUDPlayerTrackTimerEnd;
        /* 0x20C0 */ public float HUDPlayerTrackTimerPulseRate;
        /* 0x20C4 */ public TkCurveType TrackCritCurve;
        /* 0x20C8 */ public Vector2f TrackCriticalHitOffset;
        /* 0x20D0 */ public float TrackCriticalHitSize;
        /* 0x20D4 */ public float TrackCriticalPulseTime;
        /* 0x20D8 */ public float ThirdPersonCrosshairDistance;
        /* 0x20DC */ public float ThirdPersonCrosshairCircle1Distance;
        /* 0x20E0 */ public float ThirdPersonCrosshairCircle2Distance;
        /* 0x20E4 */ public float HUDPlayerTrackArrowShipLabelOffset;
        /* 0x20E8 */ public float HUDPlayerTrackArrowIconPulseTime;
        /* 0x20EC */ public float HUDPlayerTrackArrowIconShowTime;
        /* 0x20F0 */ public float HUDPlayerTrackArrowIconFadeTime;
        /* 0x20F4 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        /* 0x20FC */ public float HUDPlayerTrackArrowIconPulseWidth1;
        /* 0x2100 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        /* 0x2104 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        /* 0x2108 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        /* 0x210C */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        /* 0x2110 */ public float HUDPlayerTrackArrowIconFadeDist;
        /* 0x2114 */ public float HUDPlayerTrackArrowIconFadeRange;
        /* 0x2118 */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        /* 0x211C */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        /* 0x2120 */ public float HUDPlayerTrackArrowPulseOffset;
        /* 0x2124 */ public float HUDPlayerTrackArrowPulseRate;
        /* 0x2128 */ public Vector2f HUDPlayerTrackIconOffset;
        /* 0x2130 */ public float ShipFullscreenDamperMin;
        /* 0x2134 */ public float ShipFullscreenDamper;
        /* 0x2138 */ public float ShipDesatDamper;
        /* 0x213C */ public float ScanEventArrowShipFadeRange;
        /* 0x2140 */ public float ScanEventArrowShipFadeDistance;
        /* 0x2144 */ public float ScanEventArrowPlayerFadeRange;
        /* 0x2148 */ public float ScanEventArrowPlayerFadeDistance;
        /* 0x214C */ public float ScanEventArrowOffsetMultiplier;
        /* 0x2150 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        /* 0x2154 */ public float ScanEventArrowSecondaryAlpha;
        /* 0x2158 */ public GcAudioWwiseEvents ScanEventIconAudio;
        /* 0x215C */ public TkNGuiRectanglePulseEffect PulseBarData;
        /* 0x2170 */ public TkNGuiRectanglePulseEffect PulseIconData;
        /* 0x2190 */ public Colour PulseDamageColour;
        /* 0x21A0 */ public Colour PulseAlertColour;
        /* 0x21B0 */ public float TechDisplayDelayTime;
        /* 0x21B4 */ public float CriticalMessageTime;
        /* 0x21B8 */ public int NumDeathQuotes;
        /* 0x21C0 */ public NMSString0x10 ShowStatWithDeathQuote;
        /* 0x21D0 */ public bool EnableKanaConversion;
        /* 0x21D4 */ public float HUDDisplayTime;
        /* 0x21D8 */ public float HUDPlayerTrackDangerPulse;
        /* 0x21DC */ public float HUDPlayerTrackArrowTextOffset;
        /* 0x21E0 */ public float HUDPlayerTrackArrowTextHeight;
        /* 0x21F0 */ public Colour HUDPlayerTrackArrowTextColour;
        /* 0x2200 */ public float HUDPlayerTrackArrowHealthOffset;
        /* 0x2204 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        /* 0x2210 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        /* 0x2220 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        /* 0x2230 */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        /* 0x2234 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        /* 0x2238 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        /* 0x2240 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        /* 0x2244 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        /* 0x2248 */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        /* 0x2250 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        /* 0x2260 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        /* 0x2270 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        /* 0x2274 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        /* 0x2280 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        /* 0x2290 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        /* 0x22A0 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        /* 0x22A4 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        /* 0x22AC */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        /* 0x22B0 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        /* 0x22B8 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        /* 0x22BC */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        /* 0x22C0 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        /* 0x22D0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        /* 0x22E0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        /* 0x22F0 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        /* 0x22F4 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        /* 0x22F8 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        /* 0x2300 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        /* 0x2310 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        /* 0x2320 */ public float HUDPlayerTrackArrowTargetDistShip;
        /* 0x2324 */ public float HUDPlayerTrackArrowTargetDist;
        /* 0x2328 */ public float HUDPlayerTrackArrowOffset;
        /* 0x232C */ public float HUDPlayerTrackArrowScreenBorder;
        /* 0x2330 */ public float HUDPlayerTrackArrowSize;
        /* 0x2334 */ public float HUDPlayerTrackArrowSizeMin;
        /* 0x2338 */ public float HUDPlayerTrackArrowSizeMax;
        /* 0x233C */ public float HUDPlayerTrackArrowIconSize;
        /* 0x2340 */ public float HUDPlayerTrackArrowSmallIconSize;
        /* 0x2344 */ public float HUDPlayerTrackArrowArrowSize;
        /* 0x2348 */ public float HUDPlayerTrackArrowDotSize;
        /* 0x2350 */ public Colour HUDPlayerTrackArrowDotColour;
        /* 0x2360 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        /* 0x2370 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        /* 0x2380 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        /* 0x2390 */ public Colour HUDWarningColour;
        /* 0x23A0 */ public Colour HUDNotifyColour;
        /* 0x23B0 */ public float HUDPlayerTrackArrowMinFadeDist;
        /* 0x23B4 */ public float HUDPlayerTrackArrowFadeRange;
        // size: 0x4
        public enum SystemHooverLEDColoursEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(SystemHooverLEDColoursEnum))]
        /* 0x23C0 */ public Colour[] SystemHooverLEDColours;
        // size: 0x4
        public enum SystemHooverStatusBarColoursEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        [NMS(Size = 0x4, EnumType = typeof(SystemHooverStatusBarColoursEnum))]
        /* 0x2400 */ public Colour[] SystemHooverStatusBarColours;
        /* 0x2440 */ public float GalaxyMapRadialBorder;
        /* 0x2444 */ public float GalaxyMapRadialTargetDist;
        /* 0x2448 */ public float IconBackgroundAlpha;
        /* 0x244C */ public float WantedLevelWitnessPulseRate;
        /* 0x2450 */ public float WantedLevelWitnessOffset;
        /* 0x2454 */ public float WantedLevelTimeoutPulseRate;
        /* 0x2458 */ public float WantedLevelWitnessAlpha;
        /* 0x245C */ public float WantedLevelScanAlpha;
        /* 0x2460 */ public float WantedLevelScannedRate;
        /* 0x2468 */ public List<NMSString0x80> StatIcons;
        /* 0x2478 */ public bool ShowJetpackNotificationForNonTerrain;
        /* 0x247C */ public float StatsMessageDelayTime;
        /* 0x2480 */ public float SeasonMessageDelayTime;
        /* 0x2484 */ public bool HideExtremePlanetNotifications;
        /* 0x2488 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        /* 0x248C */ public float NotificationBackgroundGradientAlphaInShip;
        /* 0x2490 */ public int NotificationsResourceExtractHintCount;
        /* 0x2494 */ public float NotificationStaminaHintDistanceWalked;
        /* 0x2498 */ public float NotificationMinVisibleTime;
        /* 0x249C */ public float NotificationHazardSafeThreshold;
        /* 0x24A0 */ public float NotificationHazardTimer;
        /* 0x24A4 */ public float NotificationInteractHintStartTime;
        /* 0x24A8 */ public float NotificationBuildHintStartTime;
        /* 0x24AC */ public float NotificationJetpackTime;
        /* 0x24B0 */ public float NotificationShieldTime;
        /* 0x24B4 */ public float NotificationShipBoostTime;
        /* 0x24B8 */ public float NotificationShipBoostTimeVR;
        /* 0x24BC */ public float NotificationCantFireTime;
        /* 0x24C0 */ public float NotificationDangerTime;
        /* 0x24C4 */ public float NotificationScanTime;
        /* 0x24C8 */ public float NotificationScanTimeCutoff;
        /* 0x24CC */ public float NotificationMessageCycleTime;
        /* 0x24D0 */ public float NotificationMaxPageHintTime;
        /* 0x24D4 */ public float NotificationShipJumpMinTime;
        /* 0x24D8 */ public float NotificationShipJumpReminderTime;
        /* 0x24DC */ public float NotificationShipJumpReminderTutorial;
        /* 0x24E0 */ public float NotificationShipBoostMinTime;
        /* 0x24E4 */ public float NotificationShipBoostReminderTime;
        /* 0x24E8 */ public float NotificationShipBoostReminderTimeTutorial;
        /* 0x24EC */ public float LandNotifySpeedThreshold;
        /* 0x24F0 */ public float LandNotifyHeightThreshold;
        /* 0x24F4 */ public float LandNotifyTimeThreshold;
        /* 0x24F8 */ public float NotificationTimeBeforeHeridiumMarker;
        /* 0x24FC */ public float NotificationUrgentMessageTime;
        /* 0x2500 */ public float NotificationGoToSpaceStationWait;
        /* 0x2504 */ public float NotificationMonolithMissionWait;
        /* 0x2508 */ public float NotificationFinalMissionWait;
        /* 0x250C */ public float NotificationWaypointReachDistance;
        /* 0x2510 */ public float NotificationBridgeReachDistance;
        /* 0x2514 */ public float NotificationDiscoveryIdleTime;
        /* 0x2518 */ public float NotificationInfoIdleTime;
        /* 0x251C */ public float NotificationNewTechIdleTime;
        /* 0x2520 */ public float NotificationScanEventMissionIdleTime;
        /* 0x2524 */ public float NotificationDeviceIdleTime;
        /* 0x2528 */ public float NotificationMissionHintTime;
        /* 0x252C */ public float NotificationMissionHintTimeCritical;
        /* 0x2530 */ public float NotificationMissionHintTimeSecondary;
        /* 0x2534 */ public Vector2f NotificationMissionHintPauseTime;
        /* 0x253C */ public Vector2f NotificationMissionHintPauseTimeCritical;
        /* 0x2544 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        /* 0x254C */ public float TooltipTime;
        /* 0x2550 */ public float InventoryIconTime;
        /* 0x2554 */ public float MessageNotificationTime;
        /* 0x2558 */ public float MessageTimeQuick;
        /* 0x255C */ public float ItemReceivedMessageTimeToAdd;
        /* 0x2560 */ public float DeathMessageSwitchTime;
        /* 0x2564 */ public float DeathMessageTotalTime;
        /* 0x2570 */ public Colour DeathMessageColour;
        /* 0x2580 */ public Colour PinnedRecipeBorder;
        /* 0x2590 */ public NMSString0x20 DistanceUnitM;
        /* 0x25B0 */ public NMSString0x20 DistanceUnitKM;
        /* 0x25D0 */ public NMSString0x20 DistanceUnitMpS;
        /* 0x25F0 */ public float ZoomHUDElementsOffsetX;
        /* 0x25F4 */ public float ZoomHUDElementsOffsetY;
        /* 0x25F8 */ public float ZoomHUDElementTime;
        /* 0x25FC */ public float HUDElementsOffsetHMDSide;
        /* 0x2600 */ public float HUDElementsOffsetHMDTop;
        /* 0x2604 */ public float HUDElementsOffsetHMDBottom;
        /* 0x2608 */ public float HUDElementsOffsetX_0;
        /* 0x260C */ public float HUDElementsOffsetY_0;
        /* 0x2610 */ public float HUDElementsOffsetX_1;
        /* 0x2614 */ public float HUDElementsOffsetY_1;
        /* 0x2618 */ public float HUDElementsOffsetX_2;
        /* 0x261C */ public float HUDElementsOffsetY_2;
        /* 0x2620 */ public float HUDElementsOffsetX_3;
        /* 0x2624 */ public float HUDElementsOffsetY_3;
        /* 0x2628 */ public float HUDElementsOffsetX_4;
        /* 0x262C */ public float HUDElementsOffsetY_4;
        /* 0x2630 */ public float HUDElementsOffsetX_5;
        /* 0x2634 */ public float HUDElementsOffsetY_5;
        /* 0x2638 */ public GcWorldUISettings WorldUISettings;
        /* 0x266C */ public float PauseMenuHoldTime;
        /* 0x2670 */ public Vector2f PlanetLabelOffset;
        /* 0x2678 */ public Vector2f PlanetMeasureOffset;
        /* 0x2680 */ public Vector2f PlanetLineOffset;
        /* 0x2688 */ public float PlanetLabelTime;
        /* 0x268C */ public float PlanetLabelAngle;
        /* 0x2690 */ public Colour ItemSlotColourSubstance;
        /* 0x26A0 */ public Colour ItemSlotColourTech;
        /* 0x26B0 */ public Colour ItemSlotColourTechCharge;
        /* 0x26C0 */ public Colour ItemSlotColourTechDamage;
        /* 0x26D0 */ public Colour ItemSlotColourPartiallyInstalled;
        /* 0x26E0 */ public float ItemSlotColourTechChargeRate;
        /* 0x26F0 */ public Colour ItemSlotColourProduct;
        /* 0x2700 */ public Colour ItemSlotTextColourSubstance;
        /* 0x2710 */ public Colour ItemSlotTextColourTech;
        /* 0x2720 */ public Colour ItemSlotTextColourProduct;
        /* 0x2730 */ public float InteractionScanScanTime;
        /* 0x2734 */ public float InteractionScanMinTime;
        /* 0x2738 */ public float InteractionScanDisplayTime;
        /* 0x273C */ public float InteractionScanSlapTime;
        /* 0x2740 */ public float InteractionScanSlapScale;
        /* 0x2744 */ public float InteractionScanSlapOverallTime;
        /* 0x2748 */ public TkCurveType InteractionScanSlapCurve;
        /* 0x274C */ public float ShipHUDMissileLockSizeMin;
        /* 0x2750 */ public float ShipHUDMissileLockSizeMax;
        /* 0x2754 */ public float ShipHUDMissileLockSpringSlow;
        /* 0x2758 */ public float ShipHUDMissileLockSpringFast;
        /* 0x275C */ public float ShipHUDMaxOffscreenTargetDist;
        /* 0x2760 */ public float ShipHUDTargetRadius;
        /* 0x2764 */ public float ShipHUDTargetTriangleRadius;
        /* 0x2768 */ public float ShipHUDTargetAlpha;
        /* 0x276C */ public float ShipHUDTargetArrowLength;
        /* 0x2770 */ public float ShipHUDTargetMinDist;
        /* 0x2774 */ public float ShipHUDTargetRange;
        /* 0x2778 */ public float ShipHUDTargetScale;
        /* 0x277C */ public float ShipHUDTargetArrowsRotationRate;
        /* 0x2780 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        /* 0x2790 */ public Colour ShipHUDTargetArrowsColourThreat;
        /* 0x27A0 */ public Colour ShipHUDTargetArrowsColourLocal;
        /* 0x27B0 */ public List<Colour> ShipHUDTargetArrowsColour;
        /* 0x27C0 */ public Colour ShipHUDAimTargetColour;
        /* 0x27D0 */ public Colour ShipHUDAimTargetCritColour;
        /* 0x27E0 */ public float ShipHUDHitPointTime;
        /* 0x27E4 */ public float ShipHUDHitPointSize;
        /* 0x27E8 */ public float TargetScreenFoV;
        /* 0x27EC */ public float TargetScreenDistance;
        /* 0x27F0 */ public Vector2f TargetScreenCamOffset;
        /* 0x27F8 */ public float InventoryFullMessageRepeatTime;
        /* 0x27FC */ public float HoldTimerResetTime;
        /* 0x2800 */ public bool ModelRendererBGPass;
        /* 0x2801 */ public bool ModelRendererPass1;
        /* 0x2802 */ public bool ModelRendererPass2;
        /* 0x2804 */ public float HazardScreenEffectPulseRate;
        /* 0x2808 */ public float KeepHazardBarActiveTime;
        /* 0x280C */ public float KeepSecondHazardBarActiveTime;
        /* 0x2810 */ public float HazardBarPulseTime;
        /* 0x2814 */ public float HazardScreenEffectPulseTime;
        /* 0x2818 */ public float HazardScreenEffectStrength;
        /* 0x281C */ public float HazardWarningPulseTime;
        /* 0x2820 */ public float HazardWarningPulseStrength;
        /* 0x2824 */ public float HazardPainPulseStrength;
        /* 0x2828 */ public float ShieldSpringTime;
        /* 0x282C */ public float ShieldPulseTime;
        /* 0x2830 */ public float ShieldHazardPulseRate;
        /* 0x2834 */ public bool ShieldHUDAlwaysOn;
        /* 0x2838 */ public float ShieldHazardPulseThreshold;
        /* 0x283C */ public float AlwaysOnHazardThreshold;
        /* 0x2840 */ public float AlwaysOnHazardStrengthTox;
        /* 0x2844 */ public float AlwaysOnHazardStrengthHeat;
        /* 0x2848 */ public float AlwaysOnHazardStrengthRad;
        /* 0x284C */ public float AlwaysOnHazardStrengthCold;
        /* 0x2850 */ public float AlwaysOnHazardMultiplierTox;
        /* 0x2854 */ public float AlwaysOnHazardMultiplierHeat;
        /* 0x2858 */ public float AlwaysOnHazardMultiplierRad;
        /* 0x285C */ public float AlwaysOnHazardMultiplierCold;
        /* 0x2860 */ public float HazardPulseRate;
        /* 0x2868 */ public List<NMSString0x80> HazardTextures;
        /* 0x2878 */ public List<NMSString0x80> HazardNormalMaps;
        /* 0x2888 */ public List<NMSString0x80> HazardHeightmaps;
        /* 0x2898 */ public NMSString0x80 CamoTexture;
        /* 0x2918 */ public NMSString0x80 CamoNormalTexture;
        /* 0x2998 */ public float IconPulseRate;
        /* 0x29A0 */ public Colour EnergyBgColour;
        /* 0x29B0 */ public Colour EnergyBgPulseColour;
        /* 0x29C0 */ public Colour HazardBgPulseColour;
        /* 0x29D0 */ public Colour HazardDamagePulseColour;
        /* 0x29E0 */ public Colour ShieldColour;
        /* 0x29F0 */ public Colour ShieldDamageColour;
        /* 0x2A00 */ public Colour ShieldBgColour;
        /* 0x2A10 */ public Colour ShieldDamageBgColour;
        /* 0x2A20 */ public Vector2f ScanLabelOffset;
        /* 0x2A28 */ public Vector2f InteractionLabelOffset;
        /* 0x2A30 */ public Vector2f InteractionLabelOffset_1;
        /* 0x2A38 */ public Vector2f InteractionLabelSize;
        /* 0x2A40 */ public Vector2f InteractionLabelLineOffset;
        /* 0x2A48 */ public float InteractionLabelRadiusScaler;
        /* 0x2A4C */ public float InteractionLabelHeight;
        /* 0x2A50 */ public float InteractionLabelLineAlpha;
        /* 0x2A54 */ public float InteractionIconInnerRadius;
        /* 0x2A58 */ public float InteractionIconOuterRadius;
        /* 0x2A5C */ public float InteractionLabelPixelHeightMin;
        /* 0x2A60 */ public float InteractionLabelPixelHeightMax;
        /* 0x2A64 */ public float ScanTime;
        /* 0x2A70 */ public GcModelViewCollection ModelViews;
        /* 0x4120 */ public Colour CursorColour;
        /* 0x4130 */ public Colour CursorConfirmColour;
        /* 0x4140 */ public Colour CursorTransferUploadColour;
        /* 0x4150 */ public Colour CursorDeleteColour;
        /* 0x4160 */ public float CursorHoverSlowFactor;
        /* 0x4164 */ public float CursorHoverSlowFactorMin;
        /* 0x4168 */ public float FrontendBGAlpha;
        /* 0x416C */ public float FrontendConfirmTimeMouseMultiplier;
        /* 0x4170 */ public float FrontendConfirmTimeFast;
        /* 0x4174 */ public float FrontendTouchConfirmTimeFastMultiplier;
        /* 0x4178 */ public float FrontendConfirmTime;
        /* 0x417C */ public float FrontendConfirmTimeSlow;
        /* 0x4180 */ public TkCurveType FrontendConfirmCurve;
        /* 0x4184 */ public float FrontendCursorSize;
        /* 0x4188 */ public float FrontendCursorOffset;
        /* 0x418C */ public float PopupXClampOffset;
        /* 0x4190 */ public float PopupXClampOffsetRightAligned;
        /* 0x4194 */ public float PopupSlotWidthOffset;
        /* 0x4198 */ public float FrontendCursorWidth;
        /* 0x419C */ public float FrontendDeactivateTime;
        /* 0x41A0 */ public float FrontendDeactivateSplit;
        /* 0x41A4 */ public float FrontendActivateTime;
        /* 0x41A8 */ public float FrontendActivateSplit;
        /* 0x41AC */ public float FrontendStatCircleWidth;
        /* 0x41B0 */ public float FrontendStatCircleWidthExtra;
        /* 0x41B4 */ public float FrontendBootTime;
        /* 0x41B8 */ public float FrontendBootBarTime;
        /* 0x41BC */ public TkCurveType FrontendBootBarCurve;
        /* 0x41C0 */ public float PopupDebounceTime;
        /* 0x41C4 */ public float PopupActivateTime;
        /* 0x41C8 */ public float PopupDeactivateTime;
        /* 0x41CC */ public TkCurveType PopupActivateCurve1;
        /* 0x41D0 */ public TkCurveType PopupActivateCurve2;
        /* 0x41D4 */ public float ByteBeatTreeLineWidth;
        /* 0x41E0 */ public Colour ByteBeatTreeLineColour;
        /* 0x41F0 */ public float ByteBeatVisLineWidth;
        /* 0x4200 */ public Colour ByteBeatVisLineColour;
        /* 0x4210 */ public Colour ByteBeatVisGridColour;
        /* 0x4220 */ public float ByteBeatIconLineWidth;
        /* 0x4224 */ public float ByteBeatIconPad;
        /* 0x4228 */ public float ByteBeatArpLineWidth;
        /* 0x422C */ public float ByteBeatArpRadius;
        /* 0x4230 */ public float ByteBeatArpPad;
        /* 0x4240 */ public Colour ByteBeatArpGridInactiveColour;
        /* 0x4250 */ public Colour ByteBeatArpGridActiveColour;
        /* 0x4260 */ public Colour ByteBeatArpPipInactiveColour;
        /* 0x4270 */ public Colour ByteBeatArpPipActiveColour;
        /* 0x4280 */ public float ByteBeatSequencerLineWidth;
        /* 0x4284 */ public float ByteBeatSequencerPad;
        /* 0x4288 */ public float ByteBeatPartSequencerPad;
        /* 0x428C */ public float ByteBeatSequencerCornerRadius;
        /* 0x4290 */ public float ByteBeatRhythmBeatPad;
        /* 0x4294 */ public float ByteBeatSequencerInactiveSaturation;
        /* 0x4298 */ public float ByteBeatSequencerActiveSaturation;
        /* 0x429C */ public float ByteBeatRhythmSequencerInactiveSaturation;
        /* 0x42A0 */ public float ByteBeatRhythmSequencerActiveSaturation;
        /* 0x42A4 */ public float ByteBeatSequencerUnpoweredTintStrength;
        /* 0x42B0 */ public Colour ByteBeatSequencerUnpoweredTint;
        /* 0x42C0 */ public Colour ByteBeatSequencerBGColourActive;
        /* 0x42D0 */ public Colour ByteBeatSequencerBGColourInactive;
        /* 0x42E0 */ public Colour ByteBeatSequencerRimColourActive;
        /* 0x42F0 */ public Colour ByteBeatSequencerRimColourInactive;
        /* 0x4300 */ public Colour ByteBeatRhythmColour0Active;
        /* 0x4310 */ public Colour ByteBeatRhythmColour0Inactive;
        /* 0x4320 */ public Colour ByteBeatRhythmColour1Active;
        /* 0x4330 */ public Colour ByteBeatRhythmColour1Inactive;
        /* 0x4340 */ public Colour ByteBeatRhythmColour2Active;
        /* 0x4350 */ public Colour ByteBeatRhythmColour2Inactive;
        /* 0x4360 */ public Colour ByteBeatSequencerHighlightColour;
        /* 0x4370 */ public float ByteBeatSequencerHighlightLineWidth;
        /* 0x4374 */ public float ByteBeatSliderLineWidth;
        /* 0x4378 */ public float ByteBeatSliderPad;
        /* 0x437C */ public float ByteBeatSliderCornerRadius;
        /* 0x4380 */ public Colour ByteBeatSliderFGColour;
        /* 0x4390 */ public Colour ByteBeatSliderTextActiveColour;
        /* 0x43A0 */ public Colour ByteBeatSliderTextInactiveColour;
        /* 0x43B0 */ public float ByteBeatSwitchPanelAlpha;
        /* 0x43B4 */ public float ByteBeatSwitchPanelSplit;
        /* 0x43C0 */ public Colour RadialMenuInnerColourSelected;
        /* 0x43D0 */ public Colour RadialMenuOuterColourSelected;
        /* 0x43E0 */ public Colour RadialMenuInnerColourUnselected;
        /* 0x43F0 */ public Colour RadialMenuOuterColourUnselected;
        /* 0x4400 */ public Colour RadialMenuInnerColourDisabled;
        /* 0x4410 */ public Colour RadialMenuOuterColourDisabled;
        /* 0x4420 */ public float RadialMenuInnerRadius;
        /* 0x4424 */ public float RadialMenuInnerRadiusCursor;
        /* 0x4428 */ public float RadialMenuWedgeOffset;
        /* 0x442C */ public float HatchPulseSpeed;
        /* 0x4430 */ public float HatchPulseWidth;
        /* 0x4434 */ public float HatchPulsePauseTime;
        /* 0x4438 */ public int HatchCount;
        /* 0x443C */ public float HatchCursorRadius;
        /* 0x4440 */ public float HatchAlphaMain;
        /* 0x4444 */ public float HatchAlphaBase;
        /* 0x4448 */ public float HatchAlphaCursor;
        /* 0x444C */ public float FrontendDoFNearPlaneMin;
        /* 0x4450 */ public float FrontendDoFNearPlaneMax;
        /* 0x4454 */ public float FrontendDoFFarPlaneMin;
        /* 0x4458 */ public float FrontendDoFFarPlaneMax;
        /* 0x445C */ public float FrontendDoFFarPlaneFadeMin;
        /* 0x4460 */ public float FrontendDoFFarPlaneFadeMax;
        /* 0x4464 */ public float FrontendDoFBlurMultiplier;
        /* 0x4468 */ public bool FrontendDoFEnableBokeh;
        /* 0x446C */ public TkCurveType FrontendDoFCurve;
        /* 0x4470 */ public float FrontendShineSpeed;
        /* 0x4474 */ public float FrontendToolbarTextHeight;
        /* 0x4478 */ public float FrontendToolbarTextHeightSelected;
        /* 0x447C */ public float FrontendTitleFontSpacing;
        /* 0x4480 */ public float NGuiPadSensitivity;
        /* 0x4484 */ public float NGuiMouseSensitivity;
        /* 0x4488 */ public Vector2f NGuiTouchPadSensitivity;
        /* 0x4490 */ public Colour TargetMarkerColour;
        /* 0x44A0 */ public Colour TargetMarkerHighlightColour;
        /* 0x44B0 */ public float TargetMarkerScaleStart;
        /* 0x44B4 */ public float TargetMarkerScaleEnd;
        /* 0x44B8 */ public float TargetMarkerFadeAngleMin;
        /* 0x44BC */ public float TargetMarkerFadeAngleRange;
        /* 0x44C0 */ public float HitMarkerPulseSize;
        /* 0x44C4 */ public float HitMarkerPulseSizeStatic;
        /* 0x44C8 */ public float HitMarkerPulseTime;
        /* 0x44D0 */ public Colour WantedColour;
        /* 0x44E0 */ public Colour UnseenItemColour;
        /* 0x44F0 */ public float PlanetPoleMaxDotProduct;
        /* 0x44F4 */ public float SpaceMapLineWidth;
        /* 0x44F8 */ public float SpaceMapLineBaseScale;
        /* 0x44FC */ public float SpaceMapLineBaseFade;
        /* 0x4500 */ public float SpaceMapShipCombineDistance;
        /* 0x4504 */ public bool SpaceMapShowPlanets;
        /* 0x4505 */ public bool SpaceMapShowPlanetLines;
        /* 0x4506 */ public bool SpaceMapShowStation;
        /* 0x4507 */ public bool SpaceMapShowStationLines;
        /* 0x4508 */ public bool SpaceMapShowAnomaly;
        /* 0x4509 */ public bool SpaceMapShowAnomalyLines;
        /* 0x450A */ public bool SpaceMapShowNexus;
        /* 0x450B */ public bool SpaceMapShowNexusLines;
        /* 0x450C */ public bool SpaceMapShowShips;
        /* 0x450D */ public bool SpaceMapShowShipLines;
        /* 0x450E */ public bool SpaceMapShowFrieghters;
        /* 0x450F */ public bool SpaceMapShowFrieghterLines;
        /* 0x4510 */ public bool SpaceMapShowPulseEncounters;
        /* 0x4511 */ public bool SpaceMapShowPulseEncounterLines;
        /* 0x4514 */ public float SpaceMapFoV;
        /* 0x4518 */ public float SpaceMapAspectRatio;
        /* 0x451C */ public float SpaceMapDistanceScale;
        /* 0x4520 */ public float SpaceMapDistanceLogScaler;
        /* 0x4524 */ public TkCurveType SpaceMapDistanceCurve;
        /* 0x4528 */ public float SpaceMapScaleMin;
        /* 0x452C */ public float SpaceMapScaleRangeMin;
        /* 0x4530 */ public float SpaceMapScaleRangeMax;
        /* 0x4534 */ public float SpaceMapObjectScale;
        /* 0x4538 */ public float SpaceMapFreighterScale;
        /* 0x453C */ public float SpaceMapStationScale;
        /* 0x4540 */ public float SpaceMapAnomalyScale;
        /* 0x4544 */ public float SpaceMapPlanetScale;
        /* 0x4548 */ public float SpaceMapPlanetLineOffset;
        /* 0x454C */ public float SpaceMapMoonScale;
        /* 0x4550 */ public float SpaceMapActionScale;
        /* 0x4554 */ public float SpaceMapShipScale;
        /* 0x4558 */ public float SpaceMapMarkerScale;
        /* 0x455C */ public float SpaceMapDistance;
        /* 0x4560 */ public float SpaceMapMaxTraderDistance;
        /* 0x4564 */ public float SpaceMapDistanceMultiplier;
        /* 0x4568 */ public float SpaceMapHorizonThickness;
        /* 0x456C */ public float SpaceMapFadeAngleMin;
        /* 0x4570 */ public float SpaceMapFadeAngleMax;
        /* 0x4574 */ public float SpaceMapCamHeight;
        /* 0x4578 */ public float SpaceMapCamAngle;
        /* 0x457C */ public float SpaceMapCamDistance;
        /* 0x4580 */ public float SpaceMapShipScaleMin;
        /* 0x4584 */ public float SpaceMapLightPitch;
        /* 0x4588 */ public float SpaceMapLightYaw;
        /* 0x4590 */ public Colour SpaceFriendlyShipLineColour;
        /* 0x45A0 */ public Colour SpaceEnemyShipLineColour;
        /* 0x45B0 */ public Vector3f SpaceMapPosScaler;
        /* 0x45C0 */ public Colour SpaceMapAttackColour;
        /* 0x45D0 */ public Colour SpaceMapOtherPlayerColour;
        /* 0x45E0 */ public Colour SpaceMapThreatColour;
        /* 0x45F0 */ public Colour SpaceMapNeutralColour;
        /* 0x4600 */ public Colour SpaceMapSquadronColour;
        /* 0x4610 */ public Colour SpaceMapDeathPointColour;
        /* 0x4620 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        /* 0x4650 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        /* 0x4680 */ public GcSpaceMapObjectData SpaceMapStationData;
        /* 0x46B0 */ public GcSpaceMapObjectData SpaceMapNexusData;
        /* 0x46E0 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        /* 0x4710 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        /* 0x4740 */ public GcSpaceMapObjectData SpaceMapShipData;
        /* 0x4770 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        /* 0x47A0 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        /* 0x47D0 */ public Vector2f HUDTargetHealthOffset;
        /* 0x47D8 */ public Vector2f HUDTargetHealthSize;
        /* 0x47E0 */ public Vector2f HUDTargetHealthIconOffset;
        /* 0x47E8 */ public float HUDTargetHealthIconSize;
        /* 0x47EC */ public float HUDTargetHealthDangerTime;
        /* 0x47F0 */ public float HUDTargetMarkerOffset;
        /* 0x47F4 */ public float HUDTargetMarkerSize;
        /* 0x47F8 */ public float HUDTargetIconOffset;
        /* 0x47FC */ public float HUDTargetIconSize;
        /* 0x4800 */ public float HUDMarkerOffset;
        /* 0x4810 */ public Colour HUDMarkerColour;
        /* 0x4820 */ public Colour HUDSpaceshipColour;
        /* 0x4830 */ public Colour HUDRelicMarkerColourDiscovered;
        /* 0x4840 */ public Colour HUDRelicMarkerColourUnknown;
        /* 0x4850 */ public Colour HUDOutpostColour;
        /* 0x4860 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        /* 0x4868 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        /* 0x4870 */ public NMSString0x100 HUDMarkerIcon;
        /* 0x4970 */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        /* 0x4A70 */ public NMSString0x100 HUDMarkerColourIcon;
        /* 0x4B70 */ public NMSString0x100 HUDPointIcon;
        /* 0x4C70 */ public NMSString0x100 HUDSpaceshipIcon;
        /* 0x4D70 */ public NMSString0x100 HUDSaveIcon;
        /* 0x4E70 */ public NMSString0x100 HUDDeathPointIcon;
        /* 0x4F70 */ public NMSString0x100 HUDHexAnimIcon;
        /* 0x5070 */ public NMSString0x100 HUDCircleAnimIcon;
        /* 0x5170 */ public float HUDMarkerAnimSpeed;
        /* 0x5174 */ public float HUDMarkerAnimScale;
        /* 0x5178 */ public float HUDMarkerAnimOffset;
        /* 0x517C */ public float HUDMarkerAnimLoopTime;
        /* 0x5180 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        /* 0x5184 */ public TkCurveType HUDMarkerAnimCurve;
        /* 0x5188 */ public float HUDMarkerPrimaryIndicatorSize;
        /* 0x518C */ public float HUDPetMarkerAngleTest;
        /* 0x5190 */ public float HUDMarkerHoverAngleTestGround;
        /* 0x5194 */ public float HUDPetCentreScreenAngle;
        /* 0x5198 */ public float HUDNetworkMarkerHoverAngleTestGround;
        /* 0x519C */ public float HUDMarkerWideHoverAngleTest;
        /* 0x51A0 */ public float HUDMarkerHoverAngleTestShip;
        /* 0x51A4 */ public float HUDMarkerHoverShowLargeAngleTest;
        /* 0x51A8 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        /* 0x51AC */ public float HUDMarkerShipOffsetMaxDist;
        /* 0x51B0 */ public float HUDMarkerShipOffsetMinDist;
        /* 0x51B4 */ public float HUDMarkerNearFadeDistance;
        /* 0x51B8 */ public float HUDMarkerNearFadeRange;
        /* 0x51BC */ public float HUDMarkerFarDistance;
        /* 0x51C0 */ public float HUDMarkerFarFadeRange;
        /* 0x51C4 */ public float HUDMarkerScalerMin;
        /* 0x51C8 */ public float HUDMarkerScalerRange;
        /* 0x51CC */ public float HUDMarkerScalerSizeMin;
        /* 0x51D0 */ public float HUDMarkerScalerSizeMax;
        /* 0x51D4 */ public float HUDMarkerHorizonBlendRange;
        /* 0x51D8 */ public float HUDMarkerAlpha;
        /* 0x51DC */ public float HUDMarkerModelFadeRange;
        /* 0x51E0 */ public float HUDMarkerModelFadeMinHeight;
        /* 0x51E4 */ public float HUDMarkerShowActualIconDistance;
        /* 0x51E8 */ public float HUDMarkerShowActualSpaceIconDistance;
        /* 0x51EC */ public float HUDMarkerActiveTime;
        /* 0x51F0 */ public TkCurveType HUDMarkerActiveCurve;
        /* 0x51F4 */ public float HUDMarkerIconHoverMinScale;
        /* 0x51F8 */ public float AltimeterResolution;
        /* 0x51FC */ public float AltimeterLineSpacing;
        /* 0x5200 */ public float AltimeterWidth;
        /* 0x5204 */ public float AltimeterMin;
        /* 0x5208 */ public float AltimeterMax;
        /* 0x520C */ public float AltimeterTextSize;
        /* 0x5210 */ public float AltimeterMinValue;
        /* 0x5220 */ public Colour AltimeterBandColour1;
        /* 0x5230 */ public Colour AltimeterBandColour2;
        /* 0x5240 */ public Colour AltimeterColour1;
        /* 0x5250 */ public Colour AltimeterColour2;
        /* 0x5260 */ public float LockOnMarkerSize;
        /* 0x5264 */ public float LockOnMarkerSizeLock;
        /* 0x5270 */ public Colour LockOnMarkerActiveColour;
        /* 0x5280 */ public float AsteroidMarkerMinDisplayDistance;
        /* 0x5284 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        /* 0x5288 */ public float MissileIconAttackPulseTime;
        /* 0x528C */ public float MissileIconAttackPulseAmount;
        /* 0x5290 */ public float NGuiModelRotationDegreesX;
        /* 0x5294 */ public float NGuiModelRotationDegreesY;
        /* 0x5298 */ public float NGuiModelRotationDegreesZ;
        /* 0x529C */ public float NGuiModelViewDistanceGlobal;
        /* 0x52A0 */ public float NGuiModelViewDistanceSuitPage;
        /* 0x52A4 */ public float NGuiModelViewDistanceWeaponPage;
        /* 0x52A8 */ public float NGuiModelViewDistanceShipPage;
        /* 0x52AC */ public float NGuiModelViewDistanceDiscoveryPage;
        /* 0x52B0 */ public float NGuiModelViewFov;
        /* 0x52B4 */ public float NGuiModelViewCdSmoothTime;
        /* 0x52B8 */ public float NGuiAltPlacementDistanceScrollSpeed;
        /* 0x52BC */ public float NGuiPlacementAngleScrollSpeed;
        /* 0x52C0 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        /* 0x52D0 */ public Vector3f NGuiModelTranslationFactors;
        /* 0x52E0 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        /* 0x52F0 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        /* 0x5300 */ public float NGuiThumbnailModelRotationDegreesY;
        /* 0x5304 */ public float NGuiThumbnailModelViewDistance;
        /* 0x5308 */ public float NGuiCursorOffsetMultiplier;
        /* 0x530C */ public float NGuiActiveAreaOffsetTime;
        /* 0x5310 */ public Vector2f NGuiMin2DParallax;
        /* 0x5318 */ public Vector2f NGuiMax2DParallax;
        /* 0x5320 */ public Vector2f NGuiModelParallax;
        /* 0x5328 */ public Vector2f NGuiShipInteractParallax;
        /* 0x5330 */ public Vector2f InteractionWorldParallax;
        /* 0x5338 */ public float TargetParallaxMouseMultiplier;
        /* 0x533C */ public float TargetParallaxMaintenancePageMultiplier;
        /* 0x5340 */ public float NGuiModelViewFadeInAfterRenderTime;
        /* 0x5344 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        /* 0x5348 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        /* 0x534C */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        /* 0x5358 */ public GcHUDStartupTable IntroTiming;
        /* 0x54A8 */ public GcHUDStartupTable IntroTimingFreighter;
        /* 0x55F8 */ public GcInventorySlotActionData InstallTechSlotAction;
        /* 0x5614 */ public GcInventorySlotActionData BuildProductSlotAction;
        /* 0x5630 */ public GcInventorySlotActionData ChargeSlotAction;
        /* 0x564C */ public GcInventorySlotActionData RepairSlotAction;
        /* 0x5668 */ public GcInventorySlotActionData NewSlotRevealAction;
        /* 0x5684 */ public GcInventorySlotActionData NewSlotPulseAction;
        /* 0x56A0 */ public GcInventorySlotActionData InventoryHintAction;
        /* 0x56BC */ public float ReportBaseFlashTime;
        /* 0x56C0 */ public float ReportBaseFlashIntensity;
        /* 0x56C4 */ public float ReportBaseFlashDelay;
        /* 0x56C8 */ public int ReportBaseTexWidth;
        /* 0x56CC */ public int ReportBaseTexHeight;
        /* 0x56D0 */ public float ReportCameraSpeed;
        /* 0x56D4 */ public float AmbientModeFadeTime;
        /* 0x56D8 */ public bool HideQuickMenuControls;
        /* 0x56D9 */ public bool QuickMenuAllowCycle;
        /* 0x56DC */ public float TextChatMaxDisplayTime;
        /* 0x56E0 */ public float TextChatStayBigAfterTextInput;
        /* 0x56E4 */ public int BuildingShopMaxItems;
        /* 0x56E8 */ public float ShipScreenTexScale;
        /* 0x56EC */ public float MultiplayerTeleportEffectDisappearTime;
        /* 0x56F0 */ public float MultiplayerTeleportEffectAppearTime;
        /* 0x56F4 */ public int AbandonedFreighterAirlockRoomNumber;
        /* 0x56F8 */ public float SettlementStatInnerRadius;
        /* 0x56FC */ public float SettlementStatOuterRadius;
        /* 0x5700 */ public Colour SettlementStatColour;
        /* 0x5710 */ public Colour SettlementStatBackgroundColour;
        // size: 0x7
        public enum SettlementStatLocEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatLocEnum))]
        /* 0x5720 */ public NMSString0x20A[] SettlementStatLoc;
        // size: 0x7
        public enum SettlementStatFormatLocEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatFormatLocEnum))]
        /* 0x5800 */ public NMSString0x20A[] SettlementStatFormatLoc;
        // size: 0x7
        public enum SettlementStatBasicImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatBasicImagesEnum))]
        /* 0x58E0 */ public TkTextureResource[] SettlementStatBasicImages;
        // size: 0x7
        public enum SettlementStatPositiveImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatPositiveImagesEnum))]
        /* 0x5C7C */ public TkTextureResource[] SettlementStatPositiveImages;
        // size: 0x7
        public enum SettlementStatNegativeImagesEnum {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert
        }
        [NMS(Size = 0x7, EnumType = typeof(SettlementStatNegativeImagesEnum))]
        /* 0x6018 */ public TkTextureResource[] SettlementStatNegativeImages;
        /* 0x63B4 */ public float MinimumHoldFill;
        /* 0x63B8 */ public bool EnableAccessibleUI;
        /* 0x63BC */ public float AccessibleUIPopupScale;
        /* 0x63C0 */ public float DetailMessageDismissTime;
        /* 0x63C4 */ public float TouchScrollMaxDelta;
        /* 0x63C8 */ public float TextTouchScrollCap;
        /* 0x63CC */ public float TouchScrollChangePageThreshold;
        /* 0x63D0 */ public float ManualScrollChangePerInputMin;
        /* 0x63D4 */ public float ManualScrollChangePerInputMax;
        /* 0x63D8 */ public float InfoPortalGuideCycleTime;
        /* 0x63DC */ public float InfoPortalMilestonesCycleTime;
        /* 0x63E0 */ public float FeedFrigateAnimPeriod;
        /* 0x63E4 */ public int FeedFrigateAnimNumPeriods;
        /* 0x63E8 */ public float FeedFrigateAnimScaleChange;
        /* 0x63EC */ public float FeedFrigateAnimAlphaChange;
    }
}
