//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: chat.proto
// Note: requires additional types generated from: basetype.proto
namespace Cmd
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatPrivateReq")]
  public partial class ChatPrivateReq : global::ProtoBuf.IExtensible
  {
    public ChatPrivateReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_PRIVATE_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_PRIVATE_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _roleid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong roleid
    {
      get { return _roleid; }
      set { _roleid = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatWorldReq")]
  public partial class ChatWorldReq : global::ProtoBuf.IExtensible
  {
    public ChatWorldReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_WORLD_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_WORLD_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatWorldRet")]
  public partial class ChatWorldRet : global::ProtoBuf.IExtensible
  {
    public ChatWorldRet() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_WORLD_RET;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_WORLD_RET)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _roleid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong roleid
    {
      get { return _roleid; }
      set { _roleid = value; }
    }
    private uint _viplv;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint viplv
    {
      get { return _viplv; }
      set { _viplv = value; }
    }
    private byte[] _rolename;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] rolename
    {
      get { return _rolename; }
      set { _rolename = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatCityReq")]
  public partial class ChatCityReq : global::ProtoBuf.IExtensible
  {
    public ChatCityReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_CITY_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_CITY_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _viplv;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint viplv
    {
      get { return _viplv; }
      set { _viplv = value; }
    }
    private byte[] _rolename;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] rolename
    {
      get { return _rolename; }
      set { _rolename = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatCityRet")]
  public partial class ChatCityRet : global::ProtoBuf.IExtensible
  {
    public ChatCityRet() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_CITY_RET;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_CITY_RET)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _roleid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong roleid
    {
      get { return _roleid; }
      set { _roleid = value; }
    }
    private uint _viplv;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint viplv
    {
      get { return _viplv; }
      set { _viplv = value; }
    }
    private byte[] _rolename;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] rolename
    {
      get { return _rolename; }
      set { _rolename = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatSociatyReq")]
  public partial class ChatSociatyReq : global::ProtoBuf.IExtensible
  {
    public ChatSociatyReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_SOCIATY_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_SOCIATY_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _viplv;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint viplv
    {
      get { return _viplv; }
      set { _viplv = value; }
    }
    private byte[] _rolename;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] rolename
    {
      get { return _rolename; }
      set { _rolename = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatSociatyRet")]
  public partial class ChatSociatyRet : global::ProtoBuf.IExtensible
  {
    public ChatSociatyRet() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_SOCIATY_RET;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_SOCIATY_RET)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _roleid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"roleid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong roleid
    {
      get { return _roleid; }
      set { _roleid = value; }
    }
    private uint _viplv;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint viplv
    {
      get { return _viplv; }
      set { _viplv = value; }
    }
    private byte[] _rolename;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"rolename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] rolename
    {
      get { return _rolename; }
      set { _rolename = value; }
    }
    private byte[] _text;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] text
    {
      get { return _text; }
      set { _text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatInvitePKReq")]
  public partial class ChatInvitePKReq : global::ProtoBuf.IExtensible
  {
    public ChatInvitePKReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_INVITEPK_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_INVITEPK_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _invitedid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"invitedid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong invitedid
    {
      get { return _invitedid; }
      set { _invitedid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatInvitePKRet")]
  public partial class ChatInvitePKRet : global::ProtoBuf.IExtensible
  {
    public ChatInvitePKRet() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.CHAT_INVITEPK_RET;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.CHAT_INVITEPK_RET)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _inviteid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"inviteid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong inviteid
    {
      get { return _inviteid; }
      set { _inviteid = value; }
    }
    private uint _serverid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"serverid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint serverid
    {
      get { return _serverid; }
      set { _serverid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuySpeakerReq")]
  public partial class BuySpeakerReq : global::ProtoBuf.IExtensible
  {
    public BuySpeakerReq() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.BUY_SPEAKER_REQ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.BUY_SPEAKER_REQ)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuySpeakerRet")]
  public partial class BuySpeakerRet : global::ProtoBuf.IExtensible
  {
    public BuySpeakerRet() {}
    
    private Cmd.EProtoId _id = Cmd.EProtoId.BUY_SPEAKER_RET;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Cmd.EProtoId.BUY_SPEAKER_RET)]
    public Cmd.EProtoId id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}