--Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf.protobuf"
local prototype_pb = require("Protol.prototype_pb")
local pvptype_pb = require("Protol.pvptype_pb")
module('Protol.pvp_pb')

PVPMATCHREQ = protobuf.Descriptor();
PVPMATCHREQ_ID_FIELD = protobuf.FieldDescriptor();
PVPMATCHCANCEL = protobuf.Descriptor();
PVPMATCHCANCEL_ID_FIELD = protobuf.FieldDescriptor();
PVPMATCHRET = protobuf.Descriptor();
PVPMATCHRET_ID_FIELD = protobuf.FieldDescriptor();
PVPMATCHRET_SVRIP_FIELD = protobuf.FieldDescriptor();
PVPMATCHRET_SVRPORT_FIELD = protobuf.FieldDescriptor();
PVPMATCHRET_TEMPID_FIELD = protobuf.FieldDescriptor();
BATTLEINFOSYNC = protobuf.Descriptor();
BATTLEINFOSYNC_ID_FIELD = protobuf.FieldDescriptor();
BATTLEINFOSYNC_FIGHTERS_FIELD = protobuf.FieldDescriptor();
BATTLECLIENTREADY = protobuf.Descriptor();
BATTLECLIENTREADY_ID_FIELD = protobuf.FieldDescriptor();
BATTLEALLREADY = protobuf.Descriptor();
BATTLEALLREADY_ID_FIELD = protobuf.FieldDescriptor();
BATTLEALLREADY_RANDOM_SEED_FIELD = protobuf.FieldDescriptor();
BATTLEALLREADY_FRAME_SEC_FIELD = protobuf.FieldDescriptor();
BATTLECOUNTDOWN = protobuf.Descriptor();
BATTLECOUNTDOWN_ID_FIELD = protobuf.FieldDescriptor();
BATTLECOUNTDOWN_INDEX_FIELD = protobuf.FieldDescriptor();
BATTLECOUNTDOWN_SVRTIME_FIELD = protobuf.FieldDescriptor();

PVPMATCHREQ_ID_FIELD.name = "id"
PVPMATCHREQ_ID_FIELD.full_name = ".Cmd.PvpMatchReq.id"
PVPMATCHREQ_ID_FIELD.number = 1
PVPMATCHREQ_ID_FIELD.index = 0
PVPMATCHREQ_ID_FIELD.label = 1
PVPMATCHREQ_ID_FIELD.has_default_value = true
PVPMATCHREQ_ID_FIELD.default_value = PVP_MATCH_CS
PVPMATCHREQ_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
PVPMATCHREQ_ID_FIELD.type = 14
PVPMATCHREQ_ID_FIELD.cpp_type = 8

PVPMATCHREQ.name = "PvpMatchReq"
PVPMATCHREQ.full_name = ".Cmd.PvpMatchReq"
PVPMATCHREQ.nested_types = {}
PVPMATCHREQ.enum_types = {}
PVPMATCHREQ.fields = {PVPMATCHREQ_ID_FIELD}
PVPMATCHREQ.is_extendable = false
PVPMATCHREQ.extensions = {}
PVPMATCHCANCEL_ID_FIELD.name = "id"
PVPMATCHCANCEL_ID_FIELD.full_name = ".Cmd.PvpMatchCancel.id"
PVPMATCHCANCEL_ID_FIELD.number = 1
PVPMATCHCANCEL_ID_FIELD.index = 0
PVPMATCHCANCEL_ID_FIELD.label = 1
PVPMATCHCANCEL_ID_FIELD.has_default_value = true
PVPMATCHCANCEL_ID_FIELD.default_value = PVP_MATCH_CANCEL_CS
PVPMATCHCANCEL_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
PVPMATCHCANCEL_ID_FIELD.type = 14
PVPMATCHCANCEL_ID_FIELD.cpp_type = 8

PVPMATCHCANCEL.name = "PvpMatchCancel"
PVPMATCHCANCEL.full_name = ".Cmd.PvpMatchCancel"
PVPMATCHCANCEL.nested_types = {}
PVPMATCHCANCEL.enum_types = {}
PVPMATCHCANCEL.fields = {PVPMATCHCANCEL_ID_FIELD}
PVPMATCHCANCEL.is_extendable = false
PVPMATCHCANCEL.extensions = {}
PVPMATCHRET_ID_FIELD.name = "id"
PVPMATCHRET_ID_FIELD.full_name = ".Cmd.PvpMatchRet.id"
PVPMATCHRET_ID_FIELD.number = 1
PVPMATCHRET_ID_FIELD.index = 0
PVPMATCHRET_ID_FIELD.label = 1
PVPMATCHRET_ID_FIELD.has_default_value = true
PVPMATCHRET_ID_FIELD.default_value = PVP_MATCH_SC
PVPMATCHRET_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
PVPMATCHRET_ID_FIELD.type = 14
PVPMATCHRET_ID_FIELD.cpp_type = 8

PVPMATCHRET_SVRIP_FIELD.name = "svrip"
PVPMATCHRET_SVRIP_FIELD.full_name = ".Cmd.PvpMatchRet.svrip"
PVPMATCHRET_SVRIP_FIELD.number = 2
PVPMATCHRET_SVRIP_FIELD.index = 1
PVPMATCHRET_SVRIP_FIELD.label = 1
PVPMATCHRET_SVRIP_FIELD.has_default_value = false
PVPMATCHRET_SVRIP_FIELD.default_value = ""
PVPMATCHRET_SVRIP_FIELD.type = 12
PVPMATCHRET_SVRIP_FIELD.cpp_type = 9

PVPMATCHRET_SVRPORT_FIELD.name = "svrport"
PVPMATCHRET_SVRPORT_FIELD.full_name = ".Cmd.PvpMatchRet.svrport"
PVPMATCHRET_SVRPORT_FIELD.number = 3
PVPMATCHRET_SVRPORT_FIELD.index = 2
PVPMATCHRET_SVRPORT_FIELD.label = 1
PVPMATCHRET_SVRPORT_FIELD.has_default_value = false
PVPMATCHRET_SVRPORT_FIELD.default_value = 0
PVPMATCHRET_SVRPORT_FIELD.type = 5
PVPMATCHRET_SVRPORT_FIELD.cpp_type = 1

PVPMATCHRET_TEMPID_FIELD.name = "tempid"
PVPMATCHRET_TEMPID_FIELD.full_name = ".Cmd.PvpMatchRet.tempid"
PVPMATCHRET_TEMPID_FIELD.number = 4
PVPMATCHRET_TEMPID_FIELD.index = 3
PVPMATCHRET_TEMPID_FIELD.label = 1
PVPMATCHRET_TEMPID_FIELD.has_default_value = false
PVPMATCHRET_TEMPID_FIELD.default_value = 0
PVPMATCHRET_TEMPID_FIELD.type = 13
PVPMATCHRET_TEMPID_FIELD.cpp_type = 3

PVPMATCHRET.name = "PvpMatchRet"
PVPMATCHRET.full_name = ".Cmd.PvpMatchRet"
PVPMATCHRET.nested_types = {}
PVPMATCHRET.enum_types = {}
PVPMATCHRET.fields = {PVPMATCHRET_ID_FIELD, PVPMATCHRET_SVRIP_FIELD, PVPMATCHRET_SVRPORT_FIELD, PVPMATCHRET_TEMPID_FIELD}
PVPMATCHRET.is_extendable = false
PVPMATCHRET.extensions = {}
BATTLEINFOSYNC_ID_FIELD.name = "id"
BATTLEINFOSYNC_ID_FIELD.full_name = ".Cmd.BattleInfoSync.id"
BATTLEINFOSYNC_ID_FIELD.number = 1
BATTLEINFOSYNC_ID_FIELD.index = 0
BATTLEINFOSYNC_ID_FIELD.label = 1
BATTLEINFOSYNC_ID_FIELD.has_default_value = true
BATTLEINFOSYNC_ID_FIELD.default_value = BATTLE_INFO_S
BATTLEINFOSYNC_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
BATTLEINFOSYNC_ID_FIELD.type = 14
BATTLEINFOSYNC_ID_FIELD.cpp_type = 8

BATTLEINFOSYNC_FIGHTERS_FIELD.name = "fighters"
BATTLEINFOSYNC_FIGHTERS_FIELD.full_name = ".Cmd.BattleInfoSync.fighters"
BATTLEINFOSYNC_FIGHTERS_FIELD.number = 2
BATTLEINFOSYNC_FIGHTERS_FIELD.index = 1
BATTLEINFOSYNC_FIGHTERS_FIELD.label = 3
BATTLEINFOSYNC_FIGHTERS_FIELD.has_default_value = false
BATTLEINFOSYNC_FIGHTERS_FIELD.default_value = {}
BATTLEINFOSYNC_FIGHTERS_FIELD.message_type = pvptype_pb.FIGHTERINFO
BATTLEINFOSYNC_FIGHTERS_FIELD.type = 11
BATTLEINFOSYNC_FIGHTERS_FIELD.cpp_type = 10

BATTLEINFOSYNC.name = "BattleInfoSync"
BATTLEINFOSYNC.full_name = ".Cmd.BattleInfoSync"
BATTLEINFOSYNC.nested_types = {}
BATTLEINFOSYNC.enum_types = {}
BATTLEINFOSYNC.fields = {BATTLEINFOSYNC_ID_FIELD, BATTLEINFOSYNC_FIGHTERS_FIELD}
BATTLEINFOSYNC.is_extendable = false
BATTLEINFOSYNC.extensions = {}
BATTLECLIENTREADY_ID_FIELD.name = "id"
BATTLECLIENTREADY_ID_FIELD.full_name = ".Cmd.BattleClientReady.id"
BATTLECLIENTREADY_ID_FIELD.number = 1
BATTLECLIENTREADY_ID_FIELD.index = 0
BATTLECLIENTREADY_ID_FIELD.label = 1
BATTLECLIENTREADY_ID_FIELD.has_default_value = true
BATTLECLIENTREADY_ID_FIELD.default_value = BATTLE_CLIENT_READY_CS
BATTLECLIENTREADY_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
BATTLECLIENTREADY_ID_FIELD.type = 14
BATTLECLIENTREADY_ID_FIELD.cpp_type = 8

BATTLECLIENTREADY.name = "BattleClientReady"
BATTLECLIENTREADY.full_name = ".Cmd.BattleClientReady"
BATTLECLIENTREADY.nested_types = {}
BATTLECLIENTREADY.enum_types = {}
BATTLECLIENTREADY.fields = {BATTLECLIENTREADY_ID_FIELD}
BATTLECLIENTREADY.is_extendable = false
BATTLECLIENTREADY.extensions = {}
BATTLEALLREADY_ID_FIELD.name = "id"
BATTLEALLREADY_ID_FIELD.full_name = ".Cmd.BattleAllReady.id"
BATTLEALLREADY_ID_FIELD.number = 1
BATTLEALLREADY_ID_FIELD.index = 0
BATTLEALLREADY_ID_FIELD.label = 1
BATTLEALLREADY_ID_FIELD.has_default_value = true
BATTLEALLREADY_ID_FIELD.default_value = BATTLE_ALL_READY_S
BATTLEALLREADY_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
BATTLEALLREADY_ID_FIELD.type = 14
BATTLEALLREADY_ID_FIELD.cpp_type = 8

BATTLEALLREADY_RANDOM_SEED_FIELD.name = "random_seed"
BATTLEALLREADY_RANDOM_SEED_FIELD.full_name = ".Cmd.BattleAllReady.random_seed"
BATTLEALLREADY_RANDOM_SEED_FIELD.number = 2
BATTLEALLREADY_RANDOM_SEED_FIELD.index = 1
BATTLEALLREADY_RANDOM_SEED_FIELD.label = 2
BATTLEALLREADY_RANDOM_SEED_FIELD.has_default_value = false
BATTLEALLREADY_RANDOM_SEED_FIELD.default_value = 0
BATTLEALLREADY_RANDOM_SEED_FIELD.type = 13
BATTLEALLREADY_RANDOM_SEED_FIELD.cpp_type = 3

BATTLEALLREADY_FRAME_SEC_FIELD.name = "frame_sec"
BATTLEALLREADY_FRAME_SEC_FIELD.full_name = ".Cmd.BattleAllReady.frame_sec"
BATTLEALLREADY_FRAME_SEC_FIELD.number = 3
BATTLEALLREADY_FRAME_SEC_FIELD.index = 2
BATTLEALLREADY_FRAME_SEC_FIELD.label = 1
BATTLEALLREADY_FRAME_SEC_FIELD.has_default_value = false
BATTLEALLREADY_FRAME_SEC_FIELD.default_value = 0
BATTLEALLREADY_FRAME_SEC_FIELD.type = 13
BATTLEALLREADY_FRAME_SEC_FIELD.cpp_type = 3

BATTLEALLREADY.name = "BattleAllReady"
BATTLEALLREADY.full_name = ".Cmd.BattleAllReady"
BATTLEALLREADY.nested_types = {}
BATTLEALLREADY.enum_types = {}
BATTLEALLREADY.fields = {BATTLEALLREADY_ID_FIELD, BATTLEALLREADY_RANDOM_SEED_FIELD, BATTLEALLREADY_FRAME_SEC_FIELD}
BATTLEALLREADY.is_extendable = false
BATTLEALLREADY.extensions = {}
BATTLECOUNTDOWN_ID_FIELD.name = "id"
BATTLECOUNTDOWN_ID_FIELD.full_name = ".Cmd.BattleCountdown.id"
BATTLECOUNTDOWN_ID_FIELD.number = 1
BATTLECOUNTDOWN_ID_FIELD.index = 0
BATTLECOUNTDOWN_ID_FIELD.label = 1
BATTLECOUNTDOWN_ID_FIELD.has_default_value = true
BATTLECOUNTDOWN_ID_FIELD.default_value = BATTLE_COUNTDOWN_S
BATTLECOUNTDOWN_ID_FIELD.enum_type = prototype_pb.EMESSAGEID
BATTLECOUNTDOWN_ID_FIELD.type = 14
BATTLECOUNTDOWN_ID_FIELD.cpp_type = 8

BATTLECOUNTDOWN_INDEX_FIELD.name = "index"
BATTLECOUNTDOWN_INDEX_FIELD.full_name = ".Cmd.BattleCountdown.index"
BATTLECOUNTDOWN_INDEX_FIELD.number = 2
BATTLECOUNTDOWN_INDEX_FIELD.index = 1
BATTLECOUNTDOWN_INDEX_FIELD.label = 1
BATTLECOUNTDOWN_INDEX_FIELD.has_default_value = false
BATTLECOUNTDOWN_INDEX_FIELD.default_value = 0
BATTLECOUNTDOWN_INDEX_FIELD.type = 5
BATTLECOUNTDOWN_INDEX_FIELD.cpp_type = 1

BATTLECOUNTDOWN_SVRTIME_FIELD.name = "svrtime"
BATTLECOUNTDOWN_SVRTIME_FIELD.full_name = ".Cmd.BattleCountdown.svrtime"
BATTLECOUNTDOWN_SVRTIME_FIELD.number = 3
BATTLECOUNTDOWN_SVRTIME_FIELD.index = 2
BATTLECOUNTDOWN_SVRTIME_FIELD.label = 1
BATTLECOUNTDOWN_SVRTIME_FIELD.has_default_value = false
BATTLECOUNTDOWN_SVRTIME_FIELD.default_value = 0
BATTLECOUNTDOWN_SVRTIME_FIELD.type = 4
BATTLECOUNTDOWN_SVRTIME_FIELD.cpp_type = 4

BATTLECOUNTDOWN.name = "BattleCountdown"
BATTLECOUNTDOWN.full_name = ".Cmd.BattleCountdown"
BATTLECOUNTDOWN.nested_types = {}
BATTLECOUNTDOWN.enum_types = {}
BATTLECOUNTDOWN.fields = {BATTLECOUNTDOWN_ID_FIELD, BATTLECOUNTDOWN_INDEX_FIELD, BATTLECOUNTDOWN_SVRTIME_FIELD}
BATTLECOUNTDOWN.is_extendable = false
BATTLECOUNTDOWN.extensions = {}

BattleAllReady = protobuf.Message(BATTLEALLREADY)
BattleClientReady = protobuf.Message(BATTLECLIENTREADY)
BattleCountdown = protobuf.Message(BATTLECOUNTDOWN)
BattleInfoSync = protobuf.Message(BATTLEINFOSYNC)
PvpMatchCancel = protobuf.Message(PVPMATCHCANCEL)
PvpMatchReq = protobuf.Message(PVPMATCHREQ)
PvpMatchRet = protobuf.Message(PVPMATCHRET)
