// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RevcMsgScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RevcMsgScNotify.proto</summary>
  public static partial class RevcMsgScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RevcMsgScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RevcMsgScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSZXZjTXNnU2NOb3RpZnkucHJvdG8aDkNoYXRUeXBlLnByb3RvGhFCSUVO",
            "RUJDRUlPRi5wcm90bxoNTXNnVHlwZS5wcm90byLCAQoPUmV2Y01zZ1NjTm90",
            "aWZ5EiEKC09CRktJRE9JSkJDGAwgASgLMgwuQklFTkVCQ0VJT0YSEgoKdGFy",
            "Z2V0X3VpZBgLIAEoDRIcCgljaGF0X3R5cGUYBCABKA4yCS5DaGF0VHlwZRIQ",
            "CghleHRyYV9pZBgHIAEoDRIeCgxtZXNzYWdlX3R5cGUYCCABKA4yCC5Nc2dU",
            "eXBlEhQKDG1lc3NhZ2VfdGV4dBgGIAEoCRISCgpzb3VyY2VfdWlkGA8gASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChatTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.BIENEBCEIOFReflection.Descriptor, global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RevcMsgScNotify), global::EggLink.DanhengServer.Proto.RevcMsgScNotify.Parser, new[]{ "OBFKIDOIJBC", "TargetUid", "ChatType", "ExtraId", "MessageType", "MessageText", "SourceUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RevcMsgScNotify : pb::IMessage<RevcMsgScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RevcMsgScNotify> _parser = new pb::MessageParser<RevcMsgScNotify>(() => new RevcMsgScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RevcMsgScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RevcMsgScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify(RevcMsgScNotify other) : this() {
      oBFKIDOIJBC_ = other.oBFKIDOIJBC_ != null ? other.oBFKIDOIJBC_.Clone() : null;
      targetUid_ = other.targetUid_;
      chatType_ = other.chatType_;
      extraId_ = other.extraId_;
      messageType_ = other.messageType_;
      messageText_ = other.messageText_;
      sourceUid_ = other.sourceUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RevcMsgScNotify Clone() {
      return new RevcMsgScNotify(this);
    }

    /// <summary>Field number for the "OBFKIDOIJBC" field.</summary>
    public const int OBFKIDOIJBCFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.BIENEBCEIOF oBFKIDOIJBC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BIENEBCEIOF OBFKIDOIJBC {
      get { return oBFKIDOIJBC_; }
      set {
        oBFKIDOIJBC_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 11;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "chat_type" field.</summary>
    public const int ChatTypeFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ChatType chatType_ = global::EggLink.DanhengServer.Proto.ChatType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChatType ChatType {
      get { return chatType_; }
      set {
        chatType_ = value;
      }
    }

    /// <summary>Field number for the "extra_id" field.</summary>
    public const int ExtraIdFieldNumber = 7;
    private uint extraId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraId {
      get { return extraId_; }
      set {
        extraId_ = value;
      }
    }

    /// <summary>Field number for the "message_type" field.</summary>
    public const int MessageTypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.MsgType messageType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MessageType {
      get { return messageType_; }
      set {
        messageType_ = value;
      }
    }

    /// <summary>Field number for the "message_text" field.</summary>
    public const int MessageTextFieldNumber = 6;
    private string messageText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MessageText {
      get { return messageText_; }
      set {
        messageText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "source_uid" field.</summary>
    public const int SourceUidFieldNumber = 15;
    private uint sourceUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceUid {
      get { return sourceUid_; }
      set {
        sourceUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RevcMsgScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RevcMsgScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OBFKIDOIJBC, other.OBFKIDOIJBC)) return false;
      if (TargetUid != other.TargetUid) return false;
      if (ChatType != other.ChatType) return false;
      if (ExtraId != other.ExtraId) return false;
      if (MessageType != other.MessageType) return false;
      if (MessageText != other.MessageText) return false;
      if (SourceUid != other.SourceUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (oBFKIDOIJBC_ != null) hash ^= OBFKIDOIJBC.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) hash ^= ChatType.GetHashCode();
      if (ExtraId != 0) hash ^= ExtraId.GetHashCode();
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MessageType.GetHashCode();
      if (MessageText.Length != 0) hash ^= MessageText.GetHashCode();
      if (SourceUid != 0) hash ^= SourceUid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ChatType);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(MessageText);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ExtraId);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) MessageType);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetUid);
      }
      if (oBFKIDOIJBC_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(OBFKIDOIJBC);
      }
      if (SourceUid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceUid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ChatType);
      }
      if (MessageText.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(MessageText);
      }
      if (ExtraId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ExtraId);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) MessageType);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TargetUid);
      }
      if (oBFKIDOIJBC_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(OBFKIDOIJBC);
      }
      if (SourceUid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceUid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (oBFKIDOIJBC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OBFKIDOIJBC);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
      }
      if (ExtraId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraId);
      }
      if (MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
      }
      if (MessageText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageText);
      }
      if (SourceUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RevcMsgScNotify other) {
      if (other == null) {
        return;
      }
      if (other.oBFKIDOIJBC_ != null) {
        if (oBFKIDOIJBC_ == null) {
          OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
        }
        OBFKIDOIJBC.MergeFrom(other.OBFKIDOIJBC);
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        ChatType = other.ChatType;
      }
      if (other.ExtraId != 0) {
        ExtraId = other.ExtraId;
      }
      if (other.MessageType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MessageType = other.MessageType;
      }
      if (other.MessageText.Length != 0) {
        MessageText = other.MessageText;
      }
      if (other.SourceUid != 0) {
        SourceUid = other.SourceUid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 32: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 50: {
            MessageText = input.ReadString();
            break;
          }
          case 56: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 64: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 88: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 98: {
            if (oBFKIDOIJBC_ == null) {
              OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
            }
            input.ReadMessage(OBFKIDOIJBC);
            break;
          }
          case 120: {
            SourceUid = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 32: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 50: {
            MessageText = input.ReadString();
            break;
          }
          case 56: {
            ExtraId = input.ReadUInt32();
            break;
          }
          case 64: {
            MessageType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 88: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 98: {
            if (oBFKIDOIJBC_ == null) {
              OBFKIDOIJBC = new global::EggLink.DanhengServer.Proto.BIENEBCEIOF();
            }
            input.ReadMessage(OBFKIDOIJBC);
            break;
          }
          case 120: {
            SourceUid = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
