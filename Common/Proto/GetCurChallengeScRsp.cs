// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetCurChallengeScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetCurChallengeScRsp.proto</summary>
  public static partial class GetCurChallengeScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetCurChallengeScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetCurChallengeScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRDdXJDaGFsbGVuZ2VTY1JzcC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnBy",
            "b3RvGhBMaW5ldXBJbmZvLnByb3RvIm8KFEdldEN1ckNoYWxsZW5nZVNjUnNw",
            "Eg8KB3JldGNvZGUYBCABKA0SIAoLbGluZXVwX2xpc3QYBiADKAsyCy5MaW5l",
            "dXBJbmZvEiQKDWN1cl9jaGFsbGVuZ2UYDyABKAsyDS5DdXJDaGFsbGVuZ2VC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CurChallengeReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetCurChallengeScRsp), global::EggLink.DanhengServer.Proto.GetCurChallengeScRsp.Parser, new[]{ "Retcode", "LineupList", "CurChallenge" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetCurChallengeScRsp : pb::IMessage<GetCurChallengeScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCurChallengeScRsp> _parser = new pb::MessageParser<GetCurChallengeScRsp>(() => new GetCurChallengeScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetCurChallengeScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetCurChallengeScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurChallengeScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurChallengeScRsp(GetCurChallengeScRsp other) : this() {
      retcode_ = other.retcode_;
      lineupList_ = other.lineupList_.Clone();
      curChallenge_ = other.curChallenge_ != null ? other.curChallenge_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurChallengeScRsp Clone() {
      return new GetCurChallengeScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "lineup_list" field.</summary>
    public const int LineupListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LineupInfo> _repeated_lineupList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.LineupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo> lineupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LineupInfo> LineupList {
      get { return lineupList_; }
    }

    /// <summary>Field number for the "cur_challenge" field.</summary>
    public const int CurChallengeFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.CurChallenge curChallenge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CurChallenge CurChallenge {
      get { return curChallenge_; }
      set {
        curChallenge_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetCurChallengeScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetCurChallengeScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!lineupList_.Equals(other.lineupList_)) return false;
      if (!object.Equals(CurChallenge, other.CurChallenge)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= lineupList_.GetHashCode();
      if (curChallenge_ != null) hash ^= CurChallenge.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      lineupList_.WriteTo(output, _repeated_lineupList_codec);
      if (curChallenge_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CurChallenge);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
      if (curChallenge_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(CurChallenge);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += lineupList_.CalculateSize(_repeated_lineupList_codec);
      if (curChallenge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurChallenge);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetCurChallengeScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      lineupList_.Add(other.lineupList_);
      if (other.curChallenge_ != null) {
        if (curChallenge_ == null) {
          CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
        }
        CurChallenge.MergeFrom(other.CurChallenge);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            lineupList_.AddEntriesFrom(input, _repeated_lineupList_codec);
            break;
          }
          case 122: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 50: {
            lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
            break;
          }
          case 122: {
            if (curChallenge_ == null) {
              CurChallenge = new global::EggLink.DanhengServer.Proto.CurChallenge();
            }
            input.ReadMessage(CurChallenge);
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
