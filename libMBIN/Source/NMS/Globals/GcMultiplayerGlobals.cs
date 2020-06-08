﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x310, GUID = 0x471C421AC7E960BD)]
    public class GcMultiplayerGlobals : NMSTemplate
    {
        /* 0x000 */ public Vector2f FullSimHandUpdateDistance;
        /* 0x008 */ public Vector2f FullSimHandUpdateInterval;
        /* 0x010 */ public float DistanceBetweenTeleportMovementEffects;
        /* 0x014 */ public float FullSimHandUpdateDisabledDistance;
        /* 0x018 */ public float FullSimUpdateInterval;
        /* 0x01C */ public float JoinInteractionTimeout;
        /* 0x020 */ public float InviteInteractionTimeout;
        /* 0x024 */ public int MaxDownloadableBases;
        /* 0x028 */ public float BlobHeightOffset;
        /* 0x02C */ public int TransactionTimeout;
        /* 0x030 */ public int MessageQueueSize;
        /* 0x034 */ public int MessageQueueSizeDropUnreliable;
        /* 0x038 */ public float PlayerMarkerDisplayDistance;
        /* 0x03C */ public bool VoiceChatEnabled;
        /* 0x03D */ public bool FullSimHostMigration;
        /* 0x040 */ public float DisconnectionDisplayTime;
        /* 0x044 */ public float UpdatePeriod;
        /* 0x048 */ public float UpdatePeriodSteam;
        /* 0x04C */ public float VoiceUpdatePeriod;
        /* 0x050 */ public float VoiceUpdatePeriodSteam;
        /* 0x054 */ public float UpdateSlerpModifier;
        /* 0x058 */ public float ShipDirectionLerpModifier;
		/* 0x5C */ public float CharacterDirectionLerpModifier;
		/* 0x60 */ public float ShipSyncConvervengeMultiplier;
		/* 0x64 */ public float ShipLandShakeMaxDist;
		/* 0x68 */ public float VehicleStickLerpModifier;
		/* 0x6C */ public float VehicleThrottleLerpModifier;
		/* 0x70 */ public float PlayerMarkerScreenOffsetY;
		/* 0x74 */ public float PlayerMarkerSmallIconSize;
		/* 0x78 */ public float PlayerMarkerLargeIconDist;
		/* 0x7C */ public float PlayerMarkerLargeIconFarSize;
		/* 0x80 */ public float PlayerMarkerLargeIconCloseSize;
		/* 0x84 */ public float PlayerMarkerMinShowDistance;
		/* 0x88 */ public bool PlayerMarkerCenteredName;
		/* 0x90 */ public ulong AbandonedEntityWaitPeriod;
		/* 0x98 */ public float HostOnConnectedTimeout;
		/* 0x9C */ public int MaxSyncResponsesPerHash;
		/* 0xA0 */ public float MinScore;
		/* 0xA4 */ public float HostBiasScore;
		/* 0xA8 */ public float UsefulSyncResponseScore;
		/* 0xAC */ public float UselessSyncResponseScore;
        /* 0xB0 */ public float ConstantScoreDepletionRate;
		/* 0xB4 */ public float FactorScoreDepletionRate;
		/* 0xB8 */ public float HashCheckMessageInterval;
		/* 0xBC */ public float SyncMessageInterval;
		/* 0xC0 */ public float EditMessageInterval;
		/* 0xC4 */ public float NewBlockMessageInterval;
		/* 0xC8 */ public float EditMessageSentSyncBackOffTime;
		/* 0xCC */ public float EditMessageReceivedSyncBackOffTime;
		/* 0xD0 */ public float NewBlockMessageOverdueDistanceDivisor;
		/* 0xD4 */ public float HashCheckMessageOverdueDistanceDivisor;
		/* 0xD8 */ public int NewBlockMessageSentCooldown;
		/* 0xDC */ public int HashReceivedCooldown;
		/* 0xE0 */ public int HashMessageSentCooldown;
		/* 0xE4 */ public int UsefulSyncResponseCooldown;
		/* 0xE8 */ public int UselessSyncResponseCooldown;
		/* 0xEC */ public int NewerHashReceivedCooldown;
		/* 0xF0 */ public float BaseHeaderBroadcastInterval;
		/* 0xF4 */ public float PlaceholderBroadcastInterval;
		/* 0xF8 */ public float StatSyncRadiusPlanet;
		/* 0xFC */ public float StatSyncRadiusSpace;
		/* 0x100 */ public float NPCInteractionTimeout;
		/* 0x104 */ public float NPCReplicateStartDistance;
		/* 0x108 */ public float NPCReplicateEndDistance;
		/* 0x10C */ public int MissionRecurrenceTime;
		/* 0x110 */ public float MissionWaitOnceAllPlayersReadyTime;
		/* 0x114 */ public float ChanceMissionEpic;
		/* 0x118 */ public float RemoveDuplicateChatMessageTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x11C */ public byte[] Padding11C;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string StandardMissionSecondReward;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string QuicksilverMissionSecondReward;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string EpicMissionSecondReward;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string WeekendMissionSecondReward;
        [NMS(Size = 0x10)]
        /* 0x160 */ public string EpicMissionRewardOverride;
        /* 0x170 */ public TkTextureResource EpicMissionIcon;
        /* 0x1F4 */ public TkTextureResource EpicMissionIconSelected;
        /* 0x278 */ public TkTextureResource EpicMissionIconNotSelected;
        /* 0x2FC */ public float PlanetLocalEnitityInterestStart;
        /* 0x300 */ public float PlanetLocalEnitityInterestEnd;
        /* 0x304 */ public float EntityUpdateMaxRateDist;
        /* 0x308 */ public float EntityUpdateMinRateDist;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x30C */ public byte[] EndPadding;
    }
}
