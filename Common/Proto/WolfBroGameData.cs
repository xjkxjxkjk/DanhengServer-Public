// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WolfBroGameData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from WolfBroGameData.proto</summary>
  public static partial class WolfBroGameDataReflection {

    #region Descriptor
    /// <summary>File descriptor for WolfBroGameData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WolfBroGameDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXb2xmQnJvR2FtZURhdGEucHJvdG8aDFZlY3Rvci5wcm90bxoVV29sZkJy",
            "b0dhbWVJbmZvLnByb3RvIqEBCg9Xb2xmQnJvR2FtZURhdGESCgoCaWQYCiAB",
            "KA0SEwoLQk9MREZHT0pHSUkYCyABKA0SJQoLS0hPR05GRUdOTEMYBCABKAsy",
            "EC5Xb2xmQnJvR2FtZUluZm8SHAoLQURMSkpJR0dCSEUYByADKAsyBy5WZWN0",
            "b3ISEwoLT0FPTE1ITEhOQUkYDCABKAgSEwoLTElOTE1IQkVBUEMYBSABKAlC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.VectorReflection.Descriptor, global::EggLink.DanhengServer.Proto.WolfBroGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.WolfBroGameData), global::EggLink.DanhengServer.Proto.WolfBroGameData.Parser, new[]{ "Id", "BOLDFGOJGII", "KHOGNFEGNLC", "ADLJJIGGBHE", "OAOLMHLHNAI", "LINLMHBEAPC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class WolfBroGameData : pb::IMessage<WolfBroGameData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WolfBroGameData> _parser = new pb::MessageParser<WolfBroGameData>(() => new WolfBroGameData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WolfBroGameData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.WolfBroGameDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData(WolfBroGameData other) : this() {
      id_ = other.id_;
      bOLDFGOJGII_ = other.bOLDFGOJGII_;
      kHOGNFEGNLC_ = other.kHOGNFEGNLC_ != null ? other.kHOGNFEGNLC_.Clone() : null;
      aDLJJIGGBHE_ = other.aDLJJIGGBHE_.Clone();
      oAOLMHLHNAI_ = other.oAOLMHLHNAI_;
      lINLMHBEAPC_ = other.lINLMHBEAPC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WolfBroGameData Clone() {
      return new WolfBroGameData(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 10;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "BOLDFGOJGII" field.</summary>
    public const int BOLDFGOJGIIFieldNumber = 11;
    private uint bOLDFGOJGII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BOLDFGOJGII {
      get { return bOLDFGOJGII_; }
      set {
        bOLDFGOJGII_ = value;
      }
    }

    /// <summary>Field number for the "KHOGNFEGNLC" field.</summary>
    public const int KHOGNFEGNLCFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.WolfBroGameInfo kHOGNFEGNLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.WolfBroGameInfo KHOGNFEGNLC {
      get { return kHOGNFEGNLC_; }
      set {
        kHOGNFEGNLC_ = value;
      }
    }

    /// <summary>Field number for the "ADLJJIGGBHE" field.</summary>
    public const int ADLJJIGGBHEFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Vector> _repeated_aDLJJIGGBHE_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.Vector.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> aDLJJIGGBHE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Vector> ADLJJIGGBHE {
      get { return aDLJJIGGBHE_; }
    }

    /// <summary>Field number for the "OAOLMHLHNAI" field.</summary>
    public const int OAOLMHLHNAIFieldNumber = 12;
    private bool oAOLMHLHNAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OAOLMHLHNAI {
      get { return oAOLMHLHNAI_; }
      set {
        oAOLMHLHNAI_ = value;
      }
    }

    /// <summary>Field number for the "LINLMHBEAPC" field.</summary>
    public const int LINLMHBEAPCFieldNumber = 5;
    private string lINLMHBEAPC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LINLMHBEAPC {
      get { return lINLMHBEAPC_; }
      set {
        lINLMHBEAPC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WolfBroGameData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WolfBroGameData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (BOLDFGOJGII != other.BOLDFGOJGII) return false;
      if (!object.Equals(KHOGNFEGNLC, other.KHOGNFEGNLC)) return false;
      if(!aDLJJIGGBHE_.Equals(other.aDLJJIGGBHE_)) return false;
      if (OAOLMHLHNAI != other.OAOLMHLHNAI) return false;
      if (LINLMHBEAPC != other.LINLMHBEAPC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (BOLDFGOJGII != 0) hash ^= BOLDFGOJGII.GetHashCode();
      if (kHOGNFEGNLC_ != null) hash ^= KHOGNFEGNLC.GetHashCode();
      hash ^= aDLJJIGGBHE_.GetHashCode();
      if (OAOLMHLHNAI != false) hash ^= OAOLMHLHNAI.GetHashCode();
      if (LINLMHBEAPC.Length != 0) hash ^= LINLMHBEAPC.GetHashCode();
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
      if (kHOGNFEGNLC_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(KHOGNFEGNLC);
      }
      if (LINLMHBEAPC.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LINLMHBEAPC);
      }
      aDLJJIGGBHE_.WriteTo(output, _repeated_aDLJJIGGBHE_codec);
      if (Id != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Id);
      }
      if (BOLDFGOJGII != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BOLDFGOJGII);
      }
      if (OAOLMHLHNAI != false) {
        output.WriteRawTag(96);
        output.WriteBool(OAOLMHLHNAI);
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
      if (kHOGNFEGNLC_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(KHOGNFEGNLC);
      }
      if (LINLMHBEAPC.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(LINLMHBEAPC);
      }
      aDLJJIGGBHE_.WriteTo(ref output, _repeated_aDLJJIGGBHE_codec);
      if (Id != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Id);
      }
      if (BOLDFGOJGII != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(BOLDFGOJGII);
      }
      if (OAOLMHLHNAI != false) {
        output.WriteRawTag(96);
        output.WriteBool(OAOLMHLHNAI);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (BOLDFGOJGII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BOLDFGOJGII);
      }
      if (kHOGNFEGNLC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KHOGNFEGNLC);
      }
      size += aDLJJIGGBHE_.CalculateSize(_repeated_aDLJJIGGBHE_codec);
      if (OAOLMHLHNAI != false) {
        size += 1 + 1;
      }
      if (LINLMHBEAPC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LINLMHBEAPC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WolfBroGameData other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.BOLDFGOJGII != 0) {
        BOLDFGOJGII = other.BOLDFGOJGII;
      }
      if (other.kHOGNFEGNLC_ != null) {
        if (kHOGNFEGNLC_ == null) {
          KHOGNFEGNLC = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
        }
        KHOGNFEGNLC.MergeFrom(other.KHOGNFEGNLC);
      }
      aDLJJIGGBHE_.Add(other.aDLJJIGGBHE_);
      if (other.OAOLMHLHNAI != false) {
        OAOLMHLHNAI = other.OAOLMHLHNAI;
      }
      if (other.LINLMHBEAPC.Length != 0) {
        LINLMHBEAPC = other.LINLMHBEAPC;
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
          case 34: {
            if (kHOGNFEGNLC_ == null) {
              KHOGNFEGNLC = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
            }
            input.ReadMessage(KHOGNFEGNLC);
            break;
          }
          case 42: {
            LINLMHBEAPC = input.ReadString();
            break;
          }
          case 58: {
            aDLJJIGGBHE_.AddEntriesFrom(input, _repeated_aDLJJIGGBHE_codec);
            break;
          }
          case 80: {
            Id = input.ReadUInt32();
            break;
          }
          case 88: {
            BOLDFGOJGII = input.ReadUInt32();
            break;
          }
          case 96: {
            OAOLMHLHNAI = input.ReadBool();
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
          case 34: {
            if (kHOGNFEGNLC_ == null) {
              KHOGNFEGNLC = new global::EggLink.DanhengServer.Proto.WolfBroGameInfo();
            }
            input.ReadMessage(KHOGNFEGNLC);
            break;
          }
          case 42: {
            LINLMHBEAPC = input.ReadString();
            break;
          }
          case 58: {
            aDLJJIGGBHE_.AddEntriesFrom(ref input, _repeated_aDLJJIGGBHE_codec);
            break;
          }
          case 80: {
            Id = input.ReadUInt32();
            break;
          }
          case 88: {
            BOLDFGOJGII = input.ReadUInt32();
            break;
          }
          case 96: {
            OAOLMHLHNAI = input.ReadBool();
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
