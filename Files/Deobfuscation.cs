/* ===================================================================================================== //
 * Bepinex Unhollowed Type Deobfuscation for Crab Game v1.362
 *
 * This isn't a complete deobfuscation, as some types may have more or less uses than its name here
 * suggests, and some types had too little functionality to figure out what their purpose was for if
 * they weren't attached to any Game Objects in any scenes, leaving them with obfuscated names.
 *
 * Some places that could use some work include anything relating to the game's UI and the menu.
 * Additionally, anything to do with sfx and the Misc category could use better names or categorization.
 * Anything that's UNKNOWN or UNUSED could be looked into more to confirm its categorization.
// ===================================================================================================== */
// thanks lammas123, taken from https://github.com/lammas321/CrabGameFloatingPlayerPatch/blob/main/FloatingPlayerPatch/Deobfuscation.cs
// the 'global' keyword is deprecated so copy n paste what you need

// GeneralUi
using GeneralUiButton = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerClickHandlerUnique;
using GeneralUiHoverEffect = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerTrteSiBoVeSiUnique;
using GeneralUiTextAlignment = MonoBehaviourPublicTeteRereUnique;

using GeneralUiInventory = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique;
using GeneralUiInventorySortType = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique.EnumNPublicSealedvaDeRa3vUnique;
using GeneralUiInventoryTabs = MonoBehaviourPublicGaseRabtCoidseCoBousUnique;
using GeneralUiInventoryItemHover = MonoBehaviourPublicRebaTrliTeTrlinataTeUnique;
using GeneralUiInventoryItemClick = MonoBehaviourPublicGapaCacaTrCacawiReSiUnique;
using GeneralUiInventoryItem = MonoBehaviourPublicGaitTrcoObplmeObTenIUnique.ObjectNPrivateSealedInitUIObitprObUnique;

using GeneralUiSettings = MonoBehaviourPublicBubaObcafoObseingrObUnique;
using GeneralUiSettingsTypeCheckbox = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfOn3vUnique;
using GeneralUiSettingsTypeVSync = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfAlHa4vUnique;
using GeneralUiSettingsTypeShadowQuality = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfHaSo4vUnique;
using GeneralUiSettingsTypeShadowResolution = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v0;
using GeneralUiSettingsTypeShadowDistance = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v1;
using GeneralUiSettingsTypeShadowCascades = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaNoTwFo4vUnique;
using GeneralUiSettingsTypeTextureResolution = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaLoMeHiUl5v2;
using GeneralUiSettingsTypeAntiAliasing = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfx2x4x85vUnique;
using GeneralUiSettingsTypeBloom = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfFa4vFaUnique;
using GeneralUiSettingsTypeMicrophoneUsage = MonoBehaviourPublicBubaObcafoObseingrObUnique.EnumNPublicSealedvaOfHoVo4vUnique;
using GeneralUiSettingsOnClickHandler = MonoBehaviourPublicIncuObm_ObUnique; // May be used for more, but seems to mostly be used by settings
using GeneralUiSettingsOnClickEvent = MonoBehaviourPublicIncuObm_ObUnique.UnityEventNPublicUnique; // Same
using GeneralUiSettingsGameplayResetSave = MonoBehaviourPublicVoReVoVoVoVoVoVoVoVoUnique;
using GeneralUiSettingsAudioMicSetting = MonoBehaviourPublicTemiUnique;
using GeneralUiSettingsAudioMicDropDown = MonoBehaviour1PublicTMdrTeseLi1StUnique;
using GeneralUiSettingsCheckbox = MonoBehaviour1PublicGachUnique;
using GeneralUiSettingsDropDown = MonoBehaviour1PublicTMdrTeseReUnique;
using GeneralUiSettingsDropDownItem = MonoBehaviourPublicTrcoGaalObInQu1drObUnique.ObjectNPublicUICoDi2StStUnique;
using GeneralUiSettingsKeyInput = MonoBehaviour1PublicTekeIncuStUnique;
using GeneralUiSettingsKeyInputAlert = MonoBehaviourPublicObcuTealGaovBoInObBoUnique;
using GeneralUiSettingsScroll = MonoBehaviour1PublicTeseStRascRascUnique;
using GeneralUiSettingsSlider = MonoBehaviour1PublicSlslTevaUnique;
using GeneralUiSettingsResolution = MonoBehaviour1PublicRascTeRascseReUnique;

using GeneralUiShadowMeshModifier = ShadowPublicUnique; // Not entirely sure what this is for, didn't come across it on any Game Objects by scanning all of the game's scenes, but it probably has to be used somewhere
using GeneralUiBaseMeshEffectModifier = BaseMeshEffectPublicCom_VeBom_Li1UIm_CoUnique; // Same with this



// Menu
using MenuCameraPositioner = MonoBehaviourPublicObcaCaSicacoSiVeQuSiUnique;
using MenuCameraIdle = MonoBehaviourPublicSispsiSifrVeSiUnique;

using MenuUi = MonoBehaviourPublicGalomeGacrsemiGaupObUnique;
using MenuUiVersion = MonoBehaviourPublicTeveObInUnique;
using MenuUiItemStore = MonoBehaviourPublicObcoTeciInCoGaInloprUnique;
using MenuUiItemStoreItem = MonoBehaviourPublicObcoTeciInCoGaInloprUnique.ObjectNPublicIComparableStInUIUnique;
using MenuUiDailyQuest = MonoBehaviourPublicGachbuGaTebuqutiGaTeUnique;

using MenuUiCreateLobbySettings = MonoBehaviourPublicObjomaOblogaTMObseprUnique;
using MenuUiCreateLobbyGameModesAndMaps = MonoBehaviourPublicGamomaGaTrmoTrmaUnique;
using MenuUiCreateLobbyPractice = MonoBehaviourPublicGamaTrInmanoGaprsrVo0;

using MenuUiServerList = MonoBehaviourPublicGaseliGaVibuToclmiToUnique;
using MenuUiServerListCodeInput = MonoBehaviourPublicTMinUnique;
using MenuUiServerListing = MonoBehaviourPublicRaprTetiplTelovemiTeUnique;
using MenuUiServerListingGameModesAndMaps = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerObseStStUnique;
using MenuUiServerListingGameModesAndMapsInfo = MonoBehaviourPublicGaprTrmomaTrTehegaGaUnique;

using MenuUiItemsDisplay = MonoBehaviourPublicObcoTeciInSiInLi1TrUnique;
using MenuUiItemsDisplayDetails = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerRaicbgRashovTeRaitquUnique;
using MenuUiRecycleItem = MonoBehaviourPublicGareTecoObinpaGaIninUnique;
using MenuUiRecycleItemDisplay = MonoBehaviourPublicTeteTritMeMaitMeyiQuUnique;
using MenuUiRecycleItemDisplaySpin = MonoBehaviourPublicIPointerDownHandlerIEventSystemHandlerIPointerUpHandlerSiVeTrobBoUnique;
using MenuUiCrafting = MonoBehaviourPublicRacrbuRaBuIncrTeraprUnique;
using MenuUiCrateRates = MonoBehaviourPublicTeVoAwSlVoVoVoVoVoVoUnique;

using MenuUiMicPrompt = MonoBehaviourPublicObmiGamaUnique;

using MenuUiCreditsWindow = MonoBehaviourPublicVoStOpVoStVoStVoStVoUnique;
using MenuUiCreditsContent = MonoBehaviourPublicIPointerClickHandlerIEventSystemHandlerStStUnique;

using MenuPlayerCosmetics = MonoBehaviourPublicObPlInObUnique;
using MenuPlayerDragToSpin = MonoBehaviourPublicSiVeBoUnique;

using MenuCheckPromoItems = MonoBehaviourPublicInprUnique;

using MenuSnowSpeedModdingDetector = MonoBehaviourPublicVesnUnique;



// GameUi
using GameUi = MonoBehaviourPublicGaroloGaObInCacachGaUnique;
using GameUiCrosshair = MonoBehaviourPublicRedoleReritoboReBoenUnique;
using GameUiCrosshairReloadProgress = MonoBehaviourPublicRacuObInSiSiUnique;
using GameUiDamageVignette = MonoBehaviourPublicRadaSiSiSiUnique;
using GameUiGoldVignette = MonoBehaviourPublicGaviObInUnique;
using GameUiStandoffVignette = MonoBehaviourPublicRaviAusfhiAumicaObAuUnique;
using GameUiIntro = MonoBehaviourPublicGapaTenagaTedeObInTeUnique;
using GameUiReward = MonoBehaviourPublicRaliTehereTeTrtoboTrUnique;
using GameUiTimer = MonoBehaviourPublicTetifrTeStBoStfoSiTiUnique;

using GameUiStatus = MonoBehaviourPublicObhpamObTeplcoTeloreUnique;
using GameUiStatusReadyCountdown = MonoBehaviourPublicTeSiBoUnique;
using GameUiStatusTopRight = MonoBehaviourPublicGaplTeGaplhnTeCoreplUnique;
using GameUiStatusTopRightHatKingScore = MonoBehaviourPublicTescneTeRaovCosadaCo0;
using GameUiStatusTopRightKingOfTheHillScore = MonoBehaviourPublicTescneTeRaovCosadaCo1;
using GameUiStatusTopRightRaceFinishers = MonoBehaviourPublicTescRaovCosadaCoObObUnique;
using GameUiStatusTopRightStandoffPenalties = MonoBehaviourPublicTescplTeRaovCosadaCoUnique;
using GameUiStatusTopRightTileDriveScores = MonoBehaviourPublicRabaTescteTeObInBoObUnique;
using GameUiStatusTopRightAlert = MonoBehaviourPublicVeSiBoSimoUnique;
using GameUiStatusBottomRightMic = MonoBehaviourPublicObRaObicUnique;
using GameUiStatusBottomRightAmmo = MonoBehaviourPublicImciTetemaTeSiInSiBoUnique;

using GameUiChatBox = MonoBehaviourPublicRaovTMinTemeColoonCoUnique;
using GameUiInventory = MonoBehaviourPublicRepoTrinObCacaInObpaUnique;
using GameUiInventoryItem = MonoBehaviourPublicCacaTeslnaTeRaimseRaUnique;
using GameUiDebugNet = MonoBehaviourPublicTefpGacoBoSiBoLi1BoUnique;
using GameUiSharedObjectDebugManager = MonoBehaviourPublicTeteVoUpVoVoVoVoVoVo0;

using GameUiPlayerList = MonoBehaviourPublicBubaUnique;

using GameUiStation = MonoBehaviourPublicObshGacuInObUnique;
using GameUiStationBuyWindow = MonoBehaviourPublicGaitshGataTrbaGataTrUnique;
using GameUiStationBuyWindowTabs = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique;
using GameUiStationBuyWindowTabs_ObjectNPrivateSealedIninObUnique = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique.ObjectNPrivateSealedIninObUnique;
using GameUiStationBuyWindowTabs_ObjectNPrivateSealedObIninUnique = MonoBehaviourPublicTrtabtTrLi1RaGaLi1Unique.ObjectNPrivateSealedObIninUnique;
using GameUiStationBuyWindowShopItemIPointerHandler = MonoBehaviourPublicIPointerEnterHandlerIEventSystemHandlerIPointerExitHandlerIPointerClickHandlerInItTeitRaTeitcaRaCaUnique;

using GameUiPause = MonoBehaviourPublicTrpaGasemaGainBoGapaUnique;
using GameUiPauseMenuInvite = MonoBehaviourPublicTecoRahiUnique;
using GameUiPauseMenuDailyQuest = MonoBehaviourPublicObqucuObTrcoBoInObUnique;
using GameUiPausePracticeMapSelection = MonoBehaviourPublicGamaTrmaUnique;
using GameUiPausePracticeMapSelectionButton = MonoBehaviourPublicGamaTrmaUnique.ObjectNPrivateSealedBubuObUnique;

using LoadingScreen = MonoBehaviourPublicTeprUIObUIBotiRabamaUnique;
using LoadingScreenState = MonoBehaviourPublicTeprUIObUIBotiRabamaUnique.EnumNPublicSealedvaLoWaJoWa5vUnique;
using LoadingScreenThumbnailZoom = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo3;
using LoadingTransition = MonoBehaviourPublicObRaovInObSiSiUnique;
using LoadingTransitionDelegate = MonoBehaviourPublicObRaovInObSiSiUnique.MulticastDelegateNPublicSealedVoUnique;

using PlayerList = MonoBehaviourPublicGapaTrconaGaDi2UIObUnique;
using PlayerListCount = MonoBehaviourPublicTeplUnique;
using PlayerListPlayer = MonoBehaviourPublicRabaicRaTeusscTepiObUnique;
using PlayerListManagePlayer = MonoBehaviourPublicTrwiReGakibaGaTeplmuUnique;



// Managers
using Managers = MonoBehaviourPublicObInVoAwVoVoVoVoVoVoUnique; // Responsible for moving the entire "Managers" Game Object into Don't Destroy On Load
using GameLoop = MonoBehaviourPublicObInLi1GagasmLi1GaUnique;
using GameManager = MonoBehaviourPublicDi2UIObacspDi2UIObUnique;
using LobbyManager = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique;

using SteamManager = MonoBehaviourPublicObInUIgaStCSBoStcuCSUnique;
using SteamPacketManager = MonoBehaviourPublicInStInpabyDiInpaby2Unique;

using CosmeticsManager = MonoBehaviourPublicLi1CoalDi2InitCoUIUnique;
using CrateRoomManager = MonoBehaviourPublicGacrgrGaTrhiObsfSkreUnique;
using CrateOpeningDisplayManager = MonoBehaviourPublicObInTeteTrpaAuitraAuUnique;
using CrateOpeningSfx = MonoBehaviourPublicAuwoopAureAuUnique;
using EffectManager = MonoBehaviourPublicGataInefObInUnique;
using PromptManager = MonoBehaviourPublicGaprLi1ObGaprInUnique;
using Prompt = MonoBehaviourPublicTehefiTeVeSiVeUnique;
using QuestManager = MonoBehaviourPublicLi1QudaDi2InquQuacUnique;
using TotallyJustSfxACTk = MonoBehaviourPublicObsfObsfUnique;

using GameModeManager = MonoBehaviourPublicGadealGaLi1pralObInUnique;
using MapManager = MonoBehaviourPublicObInMamaLi1plMadeMaUnique;

using AlertManager = MonoBehaviourPublicGaalTrcoObInUnique;
using Alert = MonoBehaviourPublicTeteVoStSeVoStVoStVoUnique;
using ItemManager = MonoBehaviourPublicDi2InItidGamoObInUnique;
using SharedObjectManager = MonoBehaviourPublicDi2InObInObInUnique;
using SharedObjectDebugManager = MonoBehaviourPublicLi1ObUnique;
using SpawnManager = MonoBehaviourPublicObInGaspUnique;
using WinManager = MonoBehaviourPublicTenaprTeotplUITeStprUnique;

using ServerClock = MonoBehaviourPublicSiObSiInSiUnique;


using PPController = MonoBehaviourPublicMoBlAmChPoObInUnique;
using PersistentPlayerData = MonoBehaviourPublicBofrhnBoObInUnique;
using PlayerStatus = MonoBehaviourPublicObcumaObInplInObUnique;
using PlayerDamageType = MonoBehaviourPublicObcumaObInplInObUnique.EnumNPublicSealedvaFa2vUnique;
using PunchPlayers = MonoBehaviourPublicObsfBoLawhSiUnique;
using LocalAudioSource = MonoBehaviourPublicAuhibuAusoObInAuUnique;

// A lot of this Dissonance stuff was skimmed over, names may not be entirely accurate
using DissonanceInitializer = MonoBehaviourPublicGadiUnique;
using Dissonance = MonoBehaviourPublicObdicoObInGaObdiUnique;
using DissonanceP2P = MonoBehaviour1PublicIn_cObIn_cObInInUnique;
using DissonanceSource = MonoBehaviourPublicAusoMeInObInInInInUnique;
using DissonanceNetworking = Object1PublicObByCSTiDaLiBy1CSUnique;
using DissonanceNetworking2 = Object1PublicObByUnique;
using DissonanceTracking = MonoBehaviourPublicBoStBoObVeStQuObBoUnique;
using DissonancePlayerPrefabInitializer = MonoBehaviourPublicUIObGaDi2StVeObQuDaUnique;
using DissonanceSomethingTarget = MonoBehaviourPublicObChSiVeQuBoVeQuSiUnique;



// Steam Inventory
using SteamInventory = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique;
using SteamInventoryCallbackType = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.EnumNPublicSealedvaGeSeDeItGeExStDaPlUnique;
using SteamInventoryCosmeticItem = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.ObjectNPublicIComparableStDi2InStStUnique;
using SteamInventoryPlayerInventory = MonoBehaviourPublicStCaSt1ObSthaUIStmaUnique.ObjectNPublicByObUIUnique;

using UpdateInventoryInGame = MonoBehaviourPublicStUnique;

using WorkshopUtility = MonoBehaviourPublicStwodeStUnique;



// Networking
using Packet = ObjectPublicIDisposableLi1ByInByBoUnique;

using SteamServerPacketHandler = MonoBehaviourPublicInStInpabyDiInpaby2Unique.MulticastDelegateNPublicSealedVoUIObUnique; // Handles packets sent from clients to you has the host
using SteamClientPacketHandler = MonoBehaviourPublicInStInpabyDiInpaby2Unique.MulticastDelegateNPublicSealedVoObUnique; // Handles packets sent from other clients to you
using SteamPacketDestination = MonoBehaviourPublicInStInpabyDiInpaby2Unique.EnumNPublicSealedvaTo3vToUnique;

using GameServer = MonoBehaviourPublicObInCoIE85SiAwVoFoCoUnique; // Server to client (usually ends up using ServerSend, but its methods have some other important sync logic for giving items)
using ServerSend = MonoBehaviourPublicInInUnique; // Server to client
using ServerSendType = EnumPublicSealedvawesepilorelogasespUnique;
using ClientHandle = MonoBehaviourPublicUIInUIByUIUnique; // Handles receiving client bound packets
using ClientSend = MonoBehaviourPublicInpabyInInInUnique; // Client to anyone
using ClientSendType = EnumPublicSealedvahawesepirepiselostUnique;
using ServerHandle = MonoBehaviourPublicPlVoUI9GaVoUI9UsPlUnique; // Handles receiving server bound packets

using NetStatus = MonoBehaviourPublicStLi1InInUnique; // Player ping

using PlayerCommunication = MonoBehaviourPublicTrrocaTrInSiVeSipoObUnique; // For client to client position and rotation sharing (why did you do this to us Dani, now we have floating players :despair:)
using PlayerCommunicationDistance = MonoBehaviourPublicTrrocaTrInSiVeSipoObUnique.EnumNPublicSealedvaClMeFaAn5vUnique;

using LobbyGameState = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique.EnumNPublicSealedvaMeLoPrStGa6vUnique;
using PlayerDisconnectReason = MonoBehaviourPublicCSDi2UIInstObUIloDiUnique.EnumNPublicSealedvaSeKiBaLo5vUnique;



// Shared Objects and Items
using SharedObject = MonoBehaviourPublicInidBoskUnique;
using IInteractable = InterfacePublicAbstractTrVoLoSeVoUIAlCaVoUIUnique;
using InteractableItem = MonoBehaviour1PublicAbstractItitBoGapiTrrileTrObUnique;
using InteractableItemMelee = MonoBehaviour2PublicObauTrSiVeSiGahiUnique;
using InteractableItemGun = MonoBehaviour2PublicTrguGamubuGaSiBoSiUnique;

using WaitingReadyButton = MonoBehaviour1PublicTrbuObreunObBoVeVeVeUnique;
using BustlingButtonsButton = MonoBehaviour1PublicInbuBoacAumobtAuVeSiUnique;
using SteppingStonesFakePiece = MonoBehaviour1PublicGasoglGaVefxUnique;

using SnowballPile = MonoBehaviour1PublicBoInSiUnique;
using ThrownSnowball = MonoBehaviour1PublicTrtrGahiRiCoBoItVeBoUnique;


using ItemType = ItemData.EnumNPublicSealedvaPrSeMeThOtAm7vUnique;

using MuzzlePrefabOffsetTarget = MonoBehaviourPublicTrtaBokeVeUnique;
using BulletTrailParticle = MonoBehaviourPublicInPabusmPaGahiUnique;
using ObjectHitFx = MonoBehaviourPublicAugemeAuObsfUnique;
using ObjectHitFxType = MonoBehaviourPublicAugemeAuObsfUnique.EnumNPublicSealedvaGeMe3vUnique;
using ItemHitFx = MonoBehaviourPublicDebublDeGaobplGaUnique;
using ItemHitFxType = MonoBehaviourPublicDebublDeGaobplGaUnique.EnumNPublicSealedvaObPl3vUnique;



// GameModes and Maps
using GameModeBaseball = GameModePublicItitUnique;
using GameModeBlockDrop = GameModePublicObSiInSiSiUnique;
using GameModeBombTag = GameModePublicInSiLiSiIn1UIObBoUnique;
using GameModeBustlingButtons = GameModePublicInSiUISiIncuneSiUIBoUnique;
using GameModeBustlingButtonsState = GameModePublicInSiUISiIncuneSiUIBoUnique.EnumNPublicSealedvaReShRe5vReUnique;
using GameModeCrabFight = GameModePublicUnique;
using GameModeDeathFromAbove = GameModePublicRaSiInSiInSiUnique;
using GameModeDodgeball = GameModePublicLi1UIBoLi1UIUnique;
using GameModeFloorIsLava = GameModePublicInSiInSiInInUnique;
using GameModeHatKing = GameModePublicLi1UItaDi2InUIplSiUnique;
using GameModeHideAndSeek = GameModePublicLi1UIsehiLi1UIDi2Unique;
using GameModeKingOfTheHill = GameModePublicDi2UIInplSielSiLiInUnique;
using GameModeLightsOut = GameModePublicSiprBoStBoUnique;
using GameModePractice = GameModePublicObObUnique;
using GameModeRace = GameModePublicInquUnique;
using GameModeRedLightGreenLight = GameModePublicSiBoDi2UIObmoSiroSiUnique;
using GameModeRedLightGreenLightPlayerInfo = GameModePublicSiBoDi2UIObmoSiroSiUnique.ObjectNPrivateVeQuUnique;
using GameModeSnowBrawl = GameModePublicInUnique;
using GameModeStandoff = GameModePublicDi2UIObstBocaSiacwaUnique;
using GameModeStandoffPlayerInfo = GameModePublicDi2UIObstBocaSiacwaUnique.ObjectNPublicInObInUnique;
using GameModeSteppingStones = GameModePublicLi1InLi1InUnique;
using GameModeTag = GameModePublicLi1UIUnique;
using GameModeTileDrive = GameModePublicDi2UIInidnTInUnique;
using GameModeState = GameMode.EnumNPublicSealedvaFrPlEnGa5vUnique;
using GameModeType = GameModeData.EnumNPublicSealedvaWaReBaStTaHiBoLiFaUnique;

using MapSizeType = Map.EnumNPublicSealedvasmmelaan5vUnique;



// GameMode Multipurpose Components
using GameModeTimer = ObjectPublicSiBoSiSiSiUnique; // Often used in a field named freezeTimer, but it's actually used for more than that
using SafeZone = MonoBehaviourPublicLi1ObsaInObUnique; // Used for several game modes: Red Light Green Light, Race, and King of The Hill



// GameMode Specific Components
using BlockDropBlockManager = MonoBehaviourPublicInwiheInblSiflInblGaUnique;
using BlockDropBlock = MonoBehaviourPublicRirbMemereMeAusfspAuUnique;

using BustlingButtonsStageController = MonoBehaviourPublicObbuMafoGaMafoAuGaObUnique;
using BustlingButtonsStageCollider = MonoBehaviourPublicVepuBoUnique;
using BustlingButtonsTimerAndIndicator = MonoBehaviourPublicTetinoTeneRacoTeCogrUnique;

using CrabFightCrabManager = MonoBehaviourPublicGacrspGacrObInGaTrObUnique; // So many components for this game mode :eyes:
using CrabFightCrabCurrentState = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaWaAtDe4vUnique;
using CrabFightCrabSpawnAttackType = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaBaSp3vUnique;
using CrabFightCrabPlayAnimationType = MonoBehaviourPublicGacrspGacrObInGaTrObUnique.EnumNPublicSealedvaJuSlRaSpDoDe7vUnique;
using CrabFightCrabBossBar = MonoBehaviourPublicSiRaSihpTrpaUnique;
using CrabFightCrabAnimator = MonoBehaviourPublicGacrshGastcrTrlaGacrUnique;
using CrabFightCrabEyesFacePlayer = MonoBehaviourPublicTrleriTrhetaSiTrandiUnique;
using CrabFightCrabAttackHitbox = MonoBehaviourPublicSimimaSioufoupSiIndaUnique;
using CrabFightCrabAttackWarning = MonoBehaviourPublicVeofLawhPrprVeUnique;
using CrabFightCrabAttackShake = MonoBehaviourPublicShcaSimaUnique;
using CrabFightCrabBallAttackController = MonoBehaviourPublicSiIndeSibaInRaVoAw20Unique;
using CrabFightCrabBallAttack = MonoBehaviourPublicGawaspGaObprObUnique;
using CrabFightCrabBallAttackFalling = MonoBehaviourPublicGawaSispUnique;
using CrabFightCrabBallAttackLandingFx = MonoBehaviourPublicGahiBoInInUnique;
using CrabFightCrabSpikeAttackController = MonoBehaviourPublicSiIndeSibaInRa20Vo20Unique;
using CrabFightCrabSpikeAttack = MonoBehaviourPublicGawaspGaSiObSiUnique;
using CrabFightCrabSpikeAttackDamage  = MonoBehaviourPublicSioufoSiupIndaSiBoUnique;

using DeathFromAboveBlockManager = MonoBehaviourPublicInwiheInblflblVeInPaUnique;
using DeathFromAboveVoxelRenderer = MonoBehaviourPublicMeLi1VeInLi1SiscSiUnique;
using DeathFromAboveBlockCollider = MonoBehaviourPublicRiUnique;

using DodgeballSpawnManager = MonoBehaviourPublicObzoTeswpaTeInObUnique;
using DodgeballChangeTeamTrigger = MonoBehaviourPublicInteLi1ObObUnique;
using DodgeballChangeTeam = MonoBehaviourPublicInteLi1ObObUnique;

using FloorIsLavaPieceManager = MonoBehaviourPublicSipiGaLipi1InGaLi11;
using FloorIsLavaPiece = MonoBehaviourPublicBoGasobrGaSiSiSiUnique;

using HatKingScoreboard = MonoBehaviourPublicTescLi15599StCoStcy0;
using HatKingScoreboardPlayer = MonoBehaviourPublicTescLi15599StCoStcy0.ObjectNPublicIComparable1ObfUIStInUnique;

using KingOfTheHillScoringVisuals = MonoBehaviourPublicPapsEmemAusfGaObUnique;
using KingOfTheHillScoreboard = MonoBehaviourPublicTescLi15599StCoStcy1;
using KingOfTheHillScoreboardPlayer = MonoBehaviourPublicTescLi15599StCoStcy1.ObjectNPublicIComparable1ObfUIStInUnique;

using RaceGasQuestProgression = MonoBehaviourPublicVoCoOnVoCoVoCoVoCoVo1; // Why wasn't this just a part of the SafeZone component, or why not make the finish its own component and not a SafeZone :skull:

using RedLightGreenLightStatue = MonoBehaviourPublicQuSiQuTrSiheQuLawhQuUnique;

using StandoffScoreboard = MonoBehaviourPublicTescLi15580StCoStcyUnique;
using StandoffScoreboardPlayer = MonoBehaviourPublicTescLi15580StCoStcyUnique.ObjectNPublicIComparable1ObfUIStInUnique;

using SteppingStonesPieceManager = MonoBehaviourPublicObpiInObUnique;

using TileDriveTileManager = MonoBehaviourPublicObtionObofDi2ObUIInUnique;
using TileDriveTile = MonoBehaviourPublicVeMeVemeMaVeTrmoInLiUnique;



// Map Specific Components
using DormMapAdjustToGamemode = MonoBehaviourPublicGaloliGabuGaUnique;
using DormMapLightsManager = MonoBehaviourPublicGaliRereAusfObInUnique;
using DormMapReadyDisplay = MonoBehaviourPublicGaprTrcoDi2UIObLi1Unique;
using DormMapReadyDisplayPlayer = MonoBehaviourPublicTeusRaovObCorenoCoUnique;
using DormMapReadyDisplayVotingTimer = MonoBehaviourPublicTeteVoUpVoVoVoVoVoVo1;
using LankyLavaMapLava = MonoBehaviourPublicVeSioflaSiAulasiBoSiUnique;
using LavaClimbMapBoulderController = MonoBehaviourPublicTrspGaboSiObInUnique;
using LavaClimbMapLava = MonoBehaviourPublicVespdeVeSilaUnique;
using PlainsMapGrass = MonoBehaviourPublicMeCoMeAdIngrVetoInLiUnique;



// Player
using LobbyPlayer = MonoBehaviourPublicCSstInscpiInUnique;
using Client = ObjectPublicBoInBoCSItBoInSiBySiUnique;

using Player = MonoBehaviourPublicCSstReshTrheObplBojuUnique;
using PlayerMovement = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique;
using PlayerCrouchState = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique.EnumNPrivateSealedvaNoCrSl4vUnique;
using PlayerGroundFriction = MonoBehaviourPublicGaplfoGaTrorplTrRiBoUnique.EnumNPrivateSealedvaGeIc4vIcUnique;
using PlayerInventory = MonoBehaviourPublicItDi2ObIninInTrweGaUnique;

using OnlinePlayer = MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique;
using OnlinePlayerSetAnimation = MonoBehaviourPublicObVeSiVeRiSiAnVeanTrUnique.EnumNPublicSealedvaCrMe3vUnique;
using OnlinePlayerCosmetics = MonoBehaviourPublicSkhafaSkshtobaSkMeMaUnique;

using OnlinePlayerNameTag = MonoBehaviourPublicTenaBoUnique;
using OnlinePlayerNameTagFacePlayer = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo1;
using OnlinePlayerHatKingCrownOutline = MonoBehaviourPublicGacrswGapaCoObGacrcoUnique;
using OnlinePlayerStandoffPenalties = MonoBehaviourPublicTescObpmObInStUnique;

using OnlinePlayerFootstepDetection = MonoBehaviourPublicGafoBoSiUnique;
using OnlinePlayerFootstep = MonoBehaviourPublicLawhObraAugegrAuUnique;
using OnlinePlayerEquippedItem = MonoBehaviourPublicObTritleObriVeQuObVeUnique;
using OnlinePlayerEquippedItemIK = MonoBehaviourPublicInChTrTaPoTrItInSiDeUnique;

using OnlinePlayerDissonanceTracker = MonoBehaviourPublicBoloStBoTrorBoObpmSpUnique;
using OnlinePlayerDissonanceSource = MonoBehaviourPublicSiBoSimudiSiAusofiAuUnique;
using OnlinePlayerDissonanceJawMovement = MonoBehaviourPublicTrjaObpmObBoObUnique;
using OnlinePlayerDissonanceTargetMuter = MonoBehaviourPublicTrtaObpmUnique;

using ExplodedPlayerBodyParts = MonoBehaviourPublicRiboSiUnique; // Created on player death when the killer's steam id is 1 (meaning should explode)
using DeadPlayerMakeRagdoll = MonoBehaviourPublicObmaReshUnique; // Created on player death when the killer's steam id is not 1 (meaning should make a ragdoll)
using DeadPlayerCreateRagdoll = MonoBehaviourPublicTrarPhmaUnique; // Part of the process of making a player ragdoll



// Camera
using CameraController = MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique;
using CameraControllerState = MonoBehaviourPublicTrplVeofdeVevaCaRiVeUnique.EnumNPublicSealedvaPlSpPlFr5vUnique;
using CameraRecoil = MonoBehaviourPublicVeVeUnique;
using CameraShaker = MonoBehaviourPublicShdaguShpuheObShInShUnique;
using CameraWeaponPos = MonoBehaviourPublicRiTrVeLi1SiVeweSiTrUnique;
using CameraFallSfxPlayer = MonoBehaviourPublicObfaInObUnique;
using CameraWeaponMelee = MonoBehaviourPublicAnObInObUnique;
using CameraUnderwaterFilter = MonoBehaviourPublicAufiUnique;
using CameraLerpDesiredFov = MonoBehaviourPublicCacaSideUnique;

using CameraHighlightPointedInteractable = MonoBehaviourPublicLawhTrcaGacuMaouUnique;
using CameraRevealPlayerNames = MonoBehaviourPublicLi1ObplLawhRaUnique;

using CinematicCameraController = MonoBehaviourPublicTrtaBoleSisploBoUnique;
using CinematicCameraCloser = MonoBehaviourPublicBoObInUnique;
using CinematicCameraPanning = MonoBehaviourPublicTrtaSispUnique;

using DepthTextureMode = MonoBehaviourPublicCaUnique; // Sets the DepthTextureMode of the camera it's attached to to Depth



// Win Screen
using WinScreenCameraController = MonoBehaviourPublicGacaInSiAucamuclAumoUnique;
using WinScreenSpotlightActivator = MonoBehaviourPublicGaauSitiUnique; // Activates the accompanying spotlight and plays the sound effect for each camera in the sequence
using WinScreenCameraShaker = MonoBehaviourPublicShshmeShShUnique;
using WinScreenUiDropAlerts = MonoBehaviourPublicTrcoGaalObInQu1drObUnique;
using WinScreenUiDropAlert = MonoBehaviourPublicTenaObitStfrStseStUnique;



// Obstacles and Misc Map Components
using BounceObstacle = MonoBehaviourPublicSicofoSimuupInSiboVeUnique; // Almost anything that knocks you away when you collide with it uses this
using SlidingObstacle = MonoBehaviourPublicVeofSispRiVeSiofUnique; // Doesn't deal knockback itself, using BounceObstacle, but makes the object move back and forth between 2 positions
using SpinnerObstacle = MonoBehaviourPublicVeaxSispRiVeofSiBoUnique; // Doesn't deal knockback itself, using BounceObstacle, but makes the object go spiiIIIIIIIIIiiiiiIIIIn
using TireBounceObstacle = MonoBehaviourPublicSiBopuSiUnique; // Could be used for other vertical launchers, but only used for tire bouces in the game

using ScrollingGroundController = MonoBehaviourPublicSigrReMagrVetrVeReShUnique; // Used in Toxic Train
using ScrollingGroundCollider = MonoBehaviourPublicVefoUnique;

using KillPlayerOnTrigger = MonoBehaviourPublicVoCoOnVoCoVoCoVoCoVo0; // Wasn't able to find a usage in game, but kills the player when they enter a trigger Collider
using KillPlayerOutOfBounds = MonoBehaviourPublicSikiUnique;
using LavaDamage = MonoBehaviourPublicGasfUnique;
using UnderwaterZone = MonoBehaviourPublicVoCoOnVoCoOnVoCoVoCoUnique;

using SpawnZone = MonoBehaviourPublicVesiUnique;
using OnlyShowForGameMode = MonoBehaviourPublicObgaGaobUnique;

using Ladder = MonoBehaviourPublicLi1CoonUnique;

using CameraFollowingSnowParticles = MonoBehaviourPublicVeofUnique;
using WaterSplash = MonoBehaviourPublicGaspLi1ObUnique;



// Misc
using StaticConstants = ObjectPublicInSiInInInInInInInInUnique; // Several static constants used in several parts of Crab Game for different purposes

using CustomRandom = RandomPublicInInInInInInUnique; // A custom System.Random used in several parts of Crab Game

using MeshGenerationFrom2dGridHelper = ObjectPublicAbstractSealedVeInUnique; // Seems to be used in the process of generating meshes from 2d grids
using MeshGeneratedFrom2dGrid = MonoBehaviourPublicMeLi1VeInLi1SiscpoUnique; // Uses the above type in the process of generating itself
using Direction = EnumPublicSealedvaNoEaSoWeUpDo7vUnique;

using CosmeticItemUtils = MonoBehaviourPublicStStStStStStStStStStUnique;
using CosmeticItemType = CosmeticItem.EnumNPublicSealedvaNoHaFaHaShOtBoToBaUnique;
using CosmeticItemRarity = CosmeticItem.EnumNPublicSealedvaCoUnRaExLeOr8vUnUnique;

using PlayerClothingColors = MonoBehaviourPublicCoInConCCoCoCoCoCoCoUnique; // Changes the player's undershirt color. The default color is white and the default value in Player.colorId is 0. The method Player.SetColor is never called and Player.colorId is never changed. This has the indirect effect of giving the player a red shirt when they die and become a ragdoll   0 = Red, 1 = Orange, 2 = Yellow, 3 = Lime, 4 = Green, 5 = Spring Green, 6 = Cyan, 7 = Light Blue, 8 = Blue, 9 = Purple, 10 = Magenta, 11 = Pink, 12 = White, 13 = Black

using QuestType = Quest.EnumNPublicSealedvaChSiSuGaCaBo7vUnique;

using ChatFilter = MonoBehaviourPublicTeprLi1StUnique;

using PlayerKeybinds = MonoBehaviourPublicInfobaInlerijuIncrspUnique;

using LobbyManagerGameSettings = ObjectPublicObInUIInStInUIInInUnique;
using LobbyManagerGameVisibility = ObjectPublicObInUIInStInUIInInUnique.EnumNPublicSealedvaLoFrPu4vUnique;
using LobbyManagerGameState = ObjectPublicInBoUnique;

using MusicController = MonoBehaviourPublicAuInMeAufuscwiAuObSiUnique;
using SongType = MonoBehaviourPublicAuInMeAufuscwiAuObSiUnique.EnumNPublicSealedvaNoInMeFuScWi7vUnique;

using DecalPool = MonoBehaviourPublicGadeLi1MeInObInInUnique;
using DecalPoolDecal = MonoBehaviourPublicGadeLi1MeInObInInUnique.Decal;
using CombatUtility = MonoBehaviourPublicGadahiGaObInUnique;
using DamageNumber = MonoBehaviourPublicTeteVeVeUnique;

using RoundStartSfx = MonoBehaviourPublicAuroObAuroclriAuroObUnique;
using RoundSfxPlayer = MonoBehaviourPublicAusoSimamiSiBoAuplSiUnique;

using ObjectOutliner = MonoBehaviourPublicHa1MeObouCoSiouBoprUnique;
using ObjectOutlineType = MonoBehaviourPublicHa1MeObouCoSiouBoprUnique.EnumNPublicSealedvaOuSiOu6vOuOuUnique;

using OverrideShadowSettings = MonoBehaviourPublicSiShSiShUnique;

using DestroyGameObjectAfterTime = MonoBehaviourPublicSitiUnique;

using StringObfuscator = ObjectPublicStByVoByStByStByStBy5; // Used by Dani to obfuscate some strings, though deobduscating them didn't really find anything interesting *shrug*

using PlayerRadius = MonoBehaviourPublicSiplUnique; // Only used by GameServer.PlayerSpawnRequest to find an open spawn location for the player, not too close to anything else

using FindGround = ObjectPublicVeVoVeVeVeVeVeVeVeVeUnique; // Used to find the ground position below a point, usually for finding at what height to spawn a player at

using FlipTexture = MonoBehaviourPublicTeFlTeVoTeTeTeTeTeTeUnique; // Flips a given texture vertically (over a horizontal line)

using FlattenVector3 = MonoBehaviourPublicVeXZVeVoVeVeVeVeVeVeUnique; // Takes in a Vector3 and returns a new one with y set to 0, doesn't normalize it

using EatShitIdiot = MonoBehaviourPublicVoEaVoVoVoVoVoVoVoVoUnique; // Contains the method EatShit called when hacking is detected, which forces the client to leave the lobby they're currently in, deletes the Game Object the current instance of SteamManager is on, and shows the prompt in the menu "nice" "eat shit idiot"

using ServerNameProfanityDetectorBase = ObjectPublicLi1StInStUnique; // Mac mono type name is Ⴃ\u109D\u109C\u109BႡႧ\u109A\u109CႢ႙႙. Guessing this is the profanity detection base class
using IServerNameProfanityDetectorBase = InterfacePublicAbstractObInBoStRe1ChStRe1Unique;
using ServerNameProfanityDetector = Object1PublicObObUnique; // Inherits from the above, seems to only ever be used to censor server list names and not chat?
using ServerNameProfanityDetectorDetectAllProfanities = Object1PublicObObUnique.ObjectNPrivateSealedLi1StswUnique; // swearList
using ServerNameProfanityDetectorDetectAllProfanities2 = Object1PublicObObUnique.ObjectNPrivateSealedStxUnique; // x
using ServerNameProfanityDetectorContainsProfanity = Object1PublicObObUnique.ObjectNPrivateSealedStteUnique; // term
using ServerNameProfanityDetectorAddMultiWordProfanities = Object1PublicObObUnique.ObjectNPrivateSealedStpoUnique; // postAllowListSentence
using ServerNameProfanityWordList = ObjectPublicLi1StReIn1StUnique; // Name in the mac mono assembly is "\u109AႦ\u109EႧႦ\u109A\u109A\u109E\u109CႢ\u109F"
using IServerNameProfanityWordListBase = InterfacePublicAbstractInRe1StVoBoStBoVoInUnique;

using MaintainAngleToTarget = MonoBehaviourPublicTrTaVeQuUnique; // Uses Quaterion.FromToRotation to forever keep its initial angle making the same face always face its target





// === Remnants from Dani developing the game === //

using DaniUnusedHexagonHeatBlockManager = MonoBehaviourPublicSipiGaLipi1InGaLi10; // Present in the unused map Color Crunch, it works similar to The Floor is Lava, but it generates a bunch of large cubes (those aren't Hexagons Dani!!!) rather than the smaller islands
using DaniUnusedTntRunBlockManager = MonoBehaviourPublicSipiGaLipi1InGaLi12; // Present in the unused map Lava Run, it also generates a bunch of slightly smaller cubes that would presumably break as you run on them, like how TNT Run works in Minecraft

using DaniUnusedMenuUiCreateLobbySpeedrun = MonoBehaviourPublicGamaTrInmanoGaprsrVo1; // There looks to have been a speedrunning mode planned for some time during development
using DaniUnusedStation = MonoBehaviourPublicObtyUnique; // It seems Dani originally wanted there to be stations you could interact with to purchase things, namely weapons using the interactable money that was never used
using DaniUnusedStationType = MonoBehaviourPublicObtyUnique.EnumNPublicSealedvaWe2vUnique;

using DaniUnusedInteractableItemThrowable = MonoBehaviour2PublicGathObauTrgumuGaSiBoUnique; // This component is attached to the Grenade and PizzaSteve, though it seems to have some functionality in its methods it doesn't seem to call any of it
using DaniUnusedInteractableItemDropped = MonoBehaviourPublicObRiSiupVeSiQuVeLiQuUnique; // This is only present when the item is not in anyone's inventory. It seems like it should allow the item to be hit (taking knockback) but it can't/doesn't, and that there's supposed to be some PhysicsObjectSnapshot system that it doesn't have functionality for
using DaniUnusedInteractableMilk = MonoBehaviour2PublicUnique; // Seems to only be attached to the Milk item prefab, all of it's overridden methods throw the NotImplementedException exception
using DaniUnusedInteractableMoney = MonoBehaviour1PublicInamUnique; // When picked up, it increments one of the integer fields (presumably called money) on the player's Client object used in LobbyManager by the integer amount field of this component, this was most likely currency for the stations Dani also didn't use
using DaniUnusedInteractableAmmo = MonoBehaviour2PublicObamUnique; // It seems that there was originally going to be a way to reload using these ammo packs, but picking them up doesn't seem to reload any weapons, simply deleting the ammo, and all of it's overridden methods throw the NotImplementedException exception
using DaniUnusedInteractableAmmoType = MonoBehaviour2PublicObamUnique.EnumNPublicSealedvaSmShRiSnEx6vUnique;

using DaniTestGameModeAvailableMaps = MonoBehaviourPublicGagaUnique; // Present on the Islands and Sandy Islands maps, calls a method in this.gameMode (GameModeData) on Start() that picks a random compatible map for 8 players
using DaniTestLobby = MonoBehaviourPublicBoUnique; // Present on serveral maps, assuming it would create a lobby and spawn Dani in any scene in the Unity Editor he had active, for quicker testing purposes
using DaniTestDummySpawner = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo1; // Seems to not be on any Game Objects at all, but will spawn 3 dummy players with player numbers 1-3 (client ids 0-2) at 0 0 0 on top of each other, Mac mono type name is Ⴅ\u109DႤႤႢ႙Ⴁ\u109B\u109F\u109EႤ
using DaniTestUngroupPlayerAndCamera = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo0; // Attached to the PlayerAndCamera Game Object in the Waiting room scene. It is disabled by default, but would loop through all children (those being Player and Camera) and set their parents to null, and then destroy its Game Object. Mac mono type is \u109BႥ\u109D\u109A\u109AႦႧႠႢ\u109BႢ
using DaniTestMovingInteractable = MonoBehaviour1PublicGaobSimoVemoVeUnique; // This component isn't present anywhere, but I believe Dani used it to test interactables, guessing from the Debug.LogError message "interacted with move interact lol" when doing so, present in its AllInteract method
using DaniTestRagdollButton = MonoBehaviourPublicGaraUnique; // Not entirely certain of this, but this component may have been used by Dani to make the ragdoll button spam bit in his first Crab Game video
using DaniTestScreenshotKeyListener = MonoBehaviourPublicIEVocaIEUpVoIEVoIEVoUnique; // This may have been used by Dani so he could get clean screenshots, possibly for the map thumbnails
using DaniTestScreenshotTaker = ObjectPublicTeReCoTeVoCoReStSiCoUnique;

using DaniUnknownOnlinePlayerBaka = MonoBehaviourPublicObonUnique; // Present on the OnlinePlayer prefab with a single field/property pointing to the OnlinePlayer MonoBehaviour and a method called Baka that has no functionality





// === Unknown / Seemingly Unused / Skimmed Over Quickly === //

using _UNKNOWN___MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo2 = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo2; // Has no functionality besides an empty Start method, 18 garbage methods, and no fields/properties
using _UNKNOWN___MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo3 = MonoBehaviourPublicVoStVoVoVoVoVoVoVoVo3; // No functionality, empty Start method, 30 garbage methods, no fields/properties
using _UNKNOWN___MonoBehaviourPublicVoStVoUpVoVoVoVoVoVoUnique = MonoBehaviourPublicVoStVoUpVoVoVoVoVoVoUnique; // No functionality, empty Start and Update methods, 31 garbage methods, and no fields/properties

using _UNKNOWN___MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo0 = MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo0; // Sends the Debug.LogError $"trying to flood servers, steam: {CSteamID from SteamManager?}" on Start, and Update has no functionality
using _UNKNOWN___MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo1 = MonoBehaviourPublicVoUpVoStVoVoVoVoVoVo1;// Sends the Debug.LogError "Doing something..." on Start, and Update has no functionality

using _UNKNOWN___MonoBehaviourPublicVo1 = MonoBehaviourPublicVo1; // Has literally no methods or fields
using _UNKNOWN___MonoBehaviourPublicVo2 = MonoBehaviourPublicVo2; // Same
using _UNKNOWN___MonoBehaviourPublicVo3 = MonoBehaviourPublicVo3; // Same
using _UNKNOWN___MonoBehaviourPublicVo4 = MonoBehaviourPublicVo4; // SAME
using _UNKNOWN___ObjectPublicVoUnique = ObjectPublicVoUnique; // Literally same

using _UNKNOWN___ObjectPublicInObInInUnique = ObjectPublicInObInInUnique; // Very obscure what this could be for
using _UNKNOWN___ObjectPublicInObInInUnique_ValueTypeNPrivateSealedInInInUnique = ObjectPublicInObInInUnique.ValueTypeNPrivateSealedInInInUnique;

using _UNKNOWN___MonoBehaviourPublicGamabtGaLi1ObInmaStUnique = MonoBehaviourPublicGamabtGaLi1ObInmaStUnique; // Seems to be for a map selector button manager of some sort, but can't find any usage of it in the game?
using _UNKNOWN___MonoBehaviourPublicTetiRaimUIwoUnique = MonoBehaviourPublicTetiRaimUIwoUnique;

using _UNKNOWN___MonoBehaviourPublicGasmSicoBoUnique = MonoBehaviourPublicGasmSicoBoUnique; // Something that creates smokeFx when contacting Ground

using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo0 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo0; // Used to make a transform always face the main camera

using _UNKNOWN___MonoBehaviourPublicSiscUnique = MonoBehaviourPublicSiscUnique; // Putting this on a game object will make it scale to 5.5x over some time, then start flattening while continuing to scale horizontally until the y scale is less than 0.1, at which point the game object will be deleted

using _UNKNOWN___MonoBehaviourPublicMefiUnique = MonoBehaviourPublicMefiUnique; // Draws a debug line between a transform and its mesh bounds center

using _UNKNOWN___MonoBehaviourPublicGaroObspUnique = MonoBehaviourPublicGaroObspUnique; // Spawns 50 rocks(?) at random positions within a spawn zone

using _UNKNOWN___MonoBehaviourPublicTrheUnique = MonoBehaviourPublicTrheUnique; // Used to make a head(?) constantly rotate towards the euler angles -4, 180, 0

using _UNKNOWN___MonoBehaviourPublicGaotUnique = MonoBehaviourPublicGaotUnique; // Something that seems to link a game object to another. Only seems to be used by ScrollingGroundCollider, allowing both the colliding object and the one it's linked to to be deleted together

using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo2 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo2; // Makes the transform face the player camera

using _UNKNOWN___MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo4 = MonoBehaviourPublicVoUpVoVoVoVoVoVoVoVo4; // Makes the transform spin at 90 degrees a second

using _UNKNOWN___MonoBehaviourPublicVeDiStVeUnique = MonoBehaviourPublicVeDiStVeUnique; // Makes a transform move in a constant direction from level load


using _UNUSED___MonoBehaviourPublicVedeTrVetaUnique = MonoBehaviourPublicVedeTrVetaUnique; // Makes a Game Object strictly follow a target Transform

using _UNUSED___InterfacePublicAbstractStUnique = InterfacePublicAbstractStUnique; // The interface is never inherited from, has a single method, and has no base functionality to conclude what it could have been for

using _UNUSED___InterfacePublicAbstractVo1 = InterfacePublicAbstractVo1; // The interface is never inherited from, has a single method, and has no base functionality, but is used by the PlayerInput.NotFrozenInput method when interacting with the currently highlighted object

using _UNUSED___MonoBehaviourPublicRemaheRecoSiRecoUnique = MonoBehaviourPublicRemaheRecoSiRecoUnique; // Doesn't seem to be used, but seems to have been used to scale a ui vertically by a percentage for a header and some content

using _UNUSED___MonoBehaviourPublicMeVeInSicegrVeIngrUnique = MonoBehaviourPublicMeVeInSicegrVeIngrUnique; // Has something to do with a mesh being generated for itself, but doesn't appear to be used anywhere
using _UNUSED___MonoBehaviourPublicSiquVeMequInVeUnique = MonoBehaviourPublicSiquVeMequInVeUnique; // Same
using _UNUSED___MonoBehaviourPublicMeVeInUnique = MonoBehaviourPublicMeVeInUnique; // SAME
using _UNUSED___MonoBehaviourPublicSiyVObinUnique = MonoBehaviourPublicSiyVObinUnique; // Used by the above type for its yValue field, for some reason?

using _UNUSED___ObjectPublicVoLi1TRaLi1TInVoUnique = ObjectPublicVoLi1TRaLi1TInVoUnique; // A type with only static methods that randomizes the order of a given List's contents, though it doesn't seem to be used anywhere
using _UNUSED___MonoBehaviourPublicVoLi1ByInBySpLi1InUnique = MonoBehaviourPublicVoLi1ByInBySpLi1InUnique; // A type with a single static method called SplitByteDateBySize that splits an array of bytes into several arrays of bytes with a given size in a List

using _UNUSED___MonoBehaviourPrivateTrFoLoTrHaStHaAtTrTrUnique = MonoBehaviourPrivateTrFoLoTrHaStHaAtTrTrUnique; // Potentially for some kind of inverse kinematics? Not entirely sure

using _UNUSED___MonoBehaviourPublicStObStBoObUnique = MonoBehaviourPublicStObStBoObUnique; // Has a LOT of functionality that just seamingly goes unused. Maybe was some centralized manager Dani used early on and swapped out for serveral less centralized components?
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_ObjectNPrivateCSStCSStUnique = MonoBehaviourPublicStObStBoObUnique.ObjectNPrivateCSStCSStUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_ObjectNPrivateAbstractUnique = MonoBehaviourPublicStObStBoObUnique.ObjectNPrivateAbstractUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableCa1LoLiOb1Unique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableCa1LoLiOb1Unique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObVeUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObVeUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique_Object1NPrivateIDisposableCSCa1LoBoDaBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique.Object1NPrivateIDisposableCSCa1LoBoDaBoUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedObUnique_Object1NPrivateIDisposableCSTiCSDaStDaBoCaBo1Unique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedObUnique.Object1NPrivateIDisposableCSTiCSDaStDaBoCaBo1Unique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableBoCa1LoObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableBoCa1LoObUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedIDisposableBoCSBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedIDisposableBoCSBoUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateSealedBoObCSAsBoUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateSealedBoObCSAsBoUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique_ObjectNPrivateSealedObP2paUnique = MonoBehaviourPublicStObStBoObUnique.Object1NPrivateAbstractIDisposableCa1P2LoCa1CSStCSObUnique.ObjectNPrivateSealedObP2paUnique;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object2NPrivateSealedVoCS0 = MonoBehaviourPublicStObStBoObUnique.Object2NPrivateSealedVoCS0;
using _UNUSED___MonoBehaviourPublicStObStBoObUnique_Object2NPrivateSealedVoCS1 = MonoBehaviourPublicStObStBoObUnique.Object2NPrivateSealedVoCS1;