// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MessageGroup.proto</summary>
  public static partial class MessageGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJNZXNzYWdlR3JvdXAucHJvdG8aFE1lc3NhZ2VTZWN0aW9uLnByb3RvGhhN",
            "ZXNzYWdlR3JvdXBTdGF0dXMucHJvdG8ioAEKDE1lc3NhZ2VHcm91cBIUCgxy",
            "ZWZyZXNoX3RpbWUYBCABKAMSGgoSbWVzc2FnZV9zZWN0aW9uX2lkGA0gASgN",
            "Ei0KFG1lc3NhZ2Vfc2VjdGlvbl9saXN0GAwgAygLMg8uTWVzc2FnZVNlY3Rp",
            "b24SCgoCaWQYCCABKA0SIwoGc3RhdHVzGAsgASgOMhMuTWVzc2FnZUdyb3Vw",
            "U3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MessageSectionReflection.Descriptor, global::EggLink.DanhengServer.Proto.MessageGroupStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MessageGroup), global::EggLink.DanhengServer.Proto.MessageGroup.Parser, new[]{ "RefreshTime", "MessageSectionId", "MessageSectionList", "Id", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MessageGroup : pb::IMessage<MessageGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MessageGroup> _parser = new pb::MessageParser<MessageGroup>(() => new MessageGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MessageGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MessageGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageGroup(MessageGroup other) : this() {
      refreshTime_ = other.refreshTime_;
      messageSectionId_ = other.messageSectionId_;
      messageSectionList_ = other.messageSectionList_.Clone();
      id_ = other.id_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MessageGroup Clone() {
      return new MessageGroup(this);
    }

    /// <summary>Field number for the "refresh_time" field.</summary>
    public const int RefreshTimeFieldNumber = 4;
    private long refreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RefreshTime {
      get { return refreshTime_; }
      set {
        refreshTime_ = value;
      }
    }

    /// <summary>Field number for the "message_section_id" field.</summary>
    public const int MessageSectionIdFieldNumber = 13;
    private uint messageSectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MessageSectionId {
      get { return messageSectionId_; }
      set {
        messageSectionId_ = value;
      }
    }

    /// <summary>Field number for the "message_section_list" field.</summary>
    public const int MessageSectionListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MessageSection> _repeated_messageSectionList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.MessageSection.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageSection> messageSectionList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageSection>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MessageSection> MessageSectionList {
      get { return messageSectionList_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 8;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.MessageGroupStatus status_ = global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MessageGroupStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MessageGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MessageGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RefreshTime != other.RefreshTime) return false;
      if (MessageSectionId != other.MessageSectionId) return false;
      if(!messageSectionList_.Equals(other.messageSectionList_)) return false;
      if (Id != other.Id) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RefreshTime != 0L) hash ^= RefreshTime.GetHashCode();
      if (MessageSectionId != 0) hash ^= MessageSectionId.GetHashCode();
      hash ^= messageSectionList_.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) hash ^= Status.GetHashCode();
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
      if (RefreshTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(RefreshTime);
      }
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
      }
      if (Status != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      messageSectionList_.WriteTo(output, _repeated_messageSectionList_codec);
      if (MessageSectionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MessageSectionId);
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
      if (RefreshTime != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(RefreshTime);
      }
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
      }
      if (Status != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      messageSectionList_.WriteTo(ref output, _repeated_messageSectionList_codec);
      if (MessageSectionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MessageSectionId);
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
      if (RefreshTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RefreshTime);
      }
      if (MessageSectionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MessageSectionId);
      }
      size += messageSectionList_.CalculateSize(_repeated_messageSectionList_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Status != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MessageGroup other) {
      if (other == null) {
        return;
      }
      if (other.RefreshTime != 0L) {
        RefreshTime = other.RefreshTime;
      }
      if (other.MessageSectionId != 0) {
        MessageSectionId = other.MessageSectionId;
      }
      messageSectionList_.Add(other.messageSectionList_);
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.MessageGroupStatus.MessageGroupNone) {
        Status = other.Status;
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
            RefreshTime = input.ReadInt64();
            break;
          }
          case 64: {
            Id = input.ReadUInt32();
            break;
          }
          case 88: {
            Status = (global::EggLink.DanhengServer.Proto.MessageGroupStatus) input.ReadEnum();
            break;
          }
          case 98: {
            messageSectionList_.AddEntriesFrom(input, _repeated_messageSectionList_codec);
            break;
          }
          case 104: {
            MessageSectionId = input.ReadUInt32();
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
            RefreshTime = input.ReadInt64();
            break;
          }
          case 64: {
            Id = input.ReadUInt32();
            break;
          }
          case 88: {
            Status = (global::EggLink.DanhengServer.Proto.MessageGroupStatus) input.ReadEnum();
            break;
          }
          case 98: {
            messageSectionList_.AddEntriesFrom(ref input, _repeated_messageSectionList_codec);
            break;
          }
          case 104: {
            MessageSectionId = input.ReadUInt32();
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
