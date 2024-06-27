// useful stuff from Deobfuscation.cs

// allows you to give weapons to players using GameServer.ForceGiveWeapon
// also used for respawning players, particularlly GameServer.Instance.QueueRespawn and GameServer.PlayerSpawnRequest
// and for killing players, with GameServer.PlayerDied
// and also for getting the current gamemode under GameServer.Instance.gameMode.GetScriptClassName
using GameServer = MonoBehaviourPublicObInCoIE85SiAwVoFoCoUnique;

// lets you send messages in chat using ServerSend.SendChatMessage
// also has player spawning as ServerSend.GameSpawnPlayer
using ServerSend = MonoBehaviourPublicInInUnique;

// allows you to kick and ban players using LobbyManager.Instance.KickPlayer and LobbyManager.Instance.BanPlayer, both require the client's steam id
using LobbyManager = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique;

// stuff relating to steam id's which are used for kicking and banning
// SteamManager.Instance.originalLobbyOwnerId.m_SteamID - gets the host's steam id
// SteamManager.Instance.prop_CSteamID_0.m_SteamID - gets the client's steam id
using SteamManager = MonoBehaviourPublicObInUIgaStCSBoStcuCSUnique;

// for some reason UnityEngine.Random is prioritized over System.Random
// these two lines fix that, ensuring System.Random appears before UnityEngine.Random
using Random = System.Random;
using UnityRandom = UnityEngine.Random;

// what AntiAntiBepinex uses to detect AntiBepinex
// credits to o7moon, all from https://github.com/o7Moon/CrabGame.AntiAntiBepinex/blob/main/Plugin.vb
using EffectManager = MonoBehaviourPublicGataInefObInUnique; // used to check for effect seed not being set to 4200069
using LobbyManager = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique; // already here, used to check if connectedToSteam is set to true
using MenuSnowSpeedModdingDetector = MonoBehaviourPublicVesnUnique; // used to check if snow speed is modified, but it only flags if its set to Vector3.zero which it's never set to because it's immediately set to Vector3.one, thanks Dani
using MenuUiCreateLobbySettings = MonoBehaviourPublicObjomaOblogaTMObseprUnique; // not sure what this one is used to check for, but it's present in the code
using PlayerListCount = MonoBehaviourPublicTeplUnique; // also not sure what this one is used to check for, but is also present in the code
