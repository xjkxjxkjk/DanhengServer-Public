// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueTournCurGameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueTournCurGameInfo.proto</summary>
  public static partial class RogueTournCurGameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueTournCurGameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueTournCurGameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZVRvdXJuQ3VyR2FtZUluZm8ucHJvdG8aFlJvZ3VlRExDQnVmZklu",
            "Zm8ucHJvdG8aEUFCRkNKR0hETklILnByb3RvGhtSb2d1ZVRvdXJuVmlydHVh",
            "bEl0ZW0ucHJvdG8aGVJvZ3VlVG91cm5MYXllckluZm8ucHJvdG8aF0tleXdv",
            "cmRVbmxvY2tJbmZvLnByb3RvGhFESkFGUE5OT01NRi5wcm90bxobUm9ndWVU",
            "b3VybkZvcm11bGFJbmZvLnByb3RvGhdSb2d1ZUdhbWVJdGVtSW5mby5wcm90",
            "bxocUm9ndWVUb3VybkdhbWVBcmVhSW5mby5wcm90bxobQ2hlc3NSb2d1ZU1p",
            "cmFjbGVJbmZvLnByb3RvIpYEChVSb2d1ZVRvdXJuQ3VyR2FtZUluZm8SOwoa",
            "cm9ndWVfdG91cm5fZ2FtZV9hcmVhX2luZm8YAiABKAsyFy5Sb2d1ZVRvdXJu",
            "R2FtZUFyZWFJbmZvEjgKGHJvZ3VlX3RvdXJuX21pcmFjbGVfaW5mbxgKIAEo",
            "CzIWLkNoZXNzUm9ndWVNaXJhY2xlSW5mbxI4Chhyb2d1ZV90b3Vybl9mb3Jt",
            "dWxhX2luZm8YASABKAsyFi5Sb2d1ZVRvdXJuRm9ybXVsYUluZm8SMwoXcm9n",
            "dWVfdG91cm5fdmFsdWVzX2l0ZW0YCyABKAsyEi5Sb2d1ZUdhbWVJdGVtSW5m",
            "bxIhCgtETENMTklKQkhCRBgGIAEoCzIMLkRKQUZQTk5PTU1GEiEKC0VOR0NN",
            "S0ZQS0xIGAcgASgLMgwuQUJGQ0pHSEROSUgSNAoWcm9ndWVfdG91cm5fbGF5",
            "ZXJfaW5mbxgEIAEoCzIULlJvZ3VlVG91cm5MYXllckluZm8SOAoYcm9ndWVf",
            "dG91cm5fdmlydHVhbF9pdGVtGA0gASgLMhYuUm9ndWVUb3VyblZpcnR1YWxJ",
            "dGVtEjAKFXJvZ3VlX3RvdXJuX2J1ZmZfaW5mbxgJIAEoCzIRLlJvZ3VlRExD",
            "QnVmZkluZm8SLwoTa2V5d29yZF91bmxvY2tfaW5mbxgIIAEoCzISLktleXdv",
            "cmRVbmxvY2tJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueDLCBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ABFCJGHDNIHReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournVirtualItemReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournLayerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.KeywordUnlockInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DJAFPNNOMMFReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournFormulaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueGameItemInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo), global::EggLink.DanhengServer.Proto.RogueTournCurGameInfo.Parser, new[]{ "RogueTournGameAreaInfo", "RogueTournMiracleInfo", "RogueTournFormulaInfo", "RogueTournValuesItem", "DLCLNIJBHBD", "ENGCMKFPKLH", "RogueTournLayerInfo", "RogueTournVirtualItem", "RogueTournBuffInfo", "KeywordUnlockInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueTournCurGameInfo : pb::IMessage<RogueTournCurGameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueTournCurGameInfo> _parser = new pb::MessageParser<RogueTournCurGameInfo>(() => new RogueTournCurGameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueTournCurGameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueTournCurGameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo(RogueTournCurGameInfo other) : this() {
      rogueTournGameAreaInfo_ = other.rogueTournGameAreaInfo_ != null ? other.rogueTournGameAreaInfo_.Clone() : null;
      rogueTournMiracleInfo_ = other.rogueTournMiracleInfo_ != null ? other.rogueTournMiracleInfo_.Clone() : null;
      rogueTournFormulaInfo_ = other.rogueTournFormulaInfo_ != null ? other.rogueTournFormulaInfo_.Clone() : null;
      rogueTournValuesItem_ = other.rogueTournValuesItem_ != null ? other.rogueTournValuesItem_.Clone() : null;
      dLCLNIJBHBD_ = other.dLCLNIJBHBD_ != null ? other.dLCLNIJBHBD_.Clone() : null;
      eNGCMKFPKLH_ = other.eNGCMKFPKLH_ != null ? other.eNGCMKFPKLH_.Clone() : null;
      rogueTournLayerInfo_ = other.rogueTournLayerInfo_ != null ? other.rogueTournLayerInfo_.Clone() : null;
      rogueTournVirtualItem_ = other.rogueTournVirtualItem_ != null ? other.rogueTournVirtualItem_.Clone() : null;
      rogueTournBuffInfo_ = other.rogueTournBuffInfo_ != null ? other.rogueTournBuffInfo_.Clone() : null;
      keywordUnlockInfo_ = other.keywordUnlockInfo_ != null ? other.keywordUnlockInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueTournCurGameInfo Clone() {
      return new RogueTournCurGameInfo(this);
    }

    /// <summary>Field number for the "rogue_tourn_game_area_info" field.</summary>
    public const int RogueTournGameAreaInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo rogueTournGameAreaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo RogueTournGameAreaInfo {
      get { return rogueTournGameAreaInfo_; }
      set {
        rogueTournGameAreaInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_miracle_info" field.</summary>
    public const int RogueTournMiracleInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo rogueTournMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo RogueTournMiracleInfo {
      get { return rogueTournMiracleInfo_; }
      set {
        rogueTournMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_formula_info" field.</summary>
    public const int RogueTournFormulaInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo rogueTournFormulaInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo RogueTournFormulaInfo {
      get { return rogueTournFormulaInfo_; }
      set {
        rogueTournFormulaInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_values_item" field.</summary>
    public const int RogueTournValuesItemFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueGameItemInfo rogueTournValuesItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueGameItemInfo RogueTournValuesItem {
      get { return rogueTournValuesItem_; }
      set {
        rogueTournValuesItem_ = value;
      }
    }

    /// <summary>Field number for the "DLCLNIJBHBD" field.</summary>
    public const int DLCLNIJBHBDFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.DJAFPNNOMMF dLCLNIJBHBD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DJAFPNNOMMF DLCLNIJBHBD {
      get { return dLCLNIJBHBD_; }
      set {
        dLCLNIJBHBD_ = value;
      }
    }

    /// <summary>Field number for the "ENGCMKFPKLH" field.</summary>
    public const int ENGCMKFPKLHFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.ABFCJGHDNIH eNGCMKFPKLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ABFCJGHDNIH ENGCMKFPKLH {
      get { return eNGCMKFPKLH_; }
      set {
        eNGCMKFPKLH_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_layer_info" field.</summary>
    public const int RogueTournLayerInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueTournLayerInfo rogueTournLayerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournLayerInfo RogueTournLayerInfo {
      get { return rogueTournLayerInfo_; }
      set {
        rogueTournLayerInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_virtual_item" field.</summary>
    public const int RogueTournVirtualItemFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueTournVirtualItem rogueTournVirtualItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueTournVirtualItem RogueTournVirtualItem {
      get { return rogueTournVirtualItem_; }
      set {
        rogueTournVirtualItem_ = value;
      }
    }

    /// <summary>Field number for the "rogue_tourn_buff_info" field.</summary>
    public const int RogueTournBuffInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.RogueDLCBuffInfo rogueTournBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueDLCBuffInfo RogueTournBuffInfo {
      get { return rogueTournBuffInfo_; }
      set {
        rogueTournBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "keyword_unlock_info" field.</summary>
    public const int KeywordUnlockInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.KeywordUnlockInfo keywordUnlockInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KeywordUnlockInfo KeywordUnlockInfo {
      get { return keywordUnlockInfo_; }
      set {
        keywordUnlockInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueTournCurGameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueTournCurGameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueTournGameAreaInfo, other.RogueTournGameAreaInfo)) return false;
      if (!object.Equals(RogueTournMiracleInfo, other.RogueTournMiracleInfo)) return false;
      if (!object.Equals(RogueTournFormulaInfo, other.RogueTournFormulaInfo)) return false;
      if (!object.Equals(RogueTournValuesItem, other.RogueTournValuesItem)) return false;
      if (!object.Equals(DLCLNIJBHBD, other.DLCLNIJBHBD)) return false;
      if (!object.Equals(ENGCMKFPKLH, other.ENGCMKFPKLH)) return false;
      if (!object.Equals(RogueTournLayerInfo, other.RogueTournLayerInfo)) return false;
      if (!object.Equals(RogueTournVirtualItem, other.RogueTournVirtualItem)) return false;
      if (!object.Equals(RogueTournBuffInfo, other.RogueTournBuffInfo)) return false;
      if (!object.Equals(KeywordUnlockInfo, other.KeywordUnlockInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueTournGameAreaInfo_ != null) hash ^= RogueTournGameAreaInfo.GetHashCode();
      if (rogueTournMiracleInfo_ != null) hash ^= RogueTournMiracleInfo.GetHashCode();
      if (rogueTournFormulaInfo_ != null) hash ^= RogueTournFormulaInfo.GetHashCode();
      if (rogueTournValuesItem_ != null) hash ^= RogueTournValuesItem.GetHashCode();
      if (dLCLNIJBHBD_ != null) hash ^= DLCLNIJBHBD.GetHashCode();
      if (eNGCMKFPKLH_ != null) hash ^= ENGCMKFPKLH.GetHashCode();
      if (rogueTournLayerInfo_ != null) hash ^= RogueTournLayerInfo.GetHashCode();
      if (rogueTournVirtualItem_ != null) hash ^= RogueTournVirtualItem.GetHashCode();
      if (rogueTournBuffInfo_ != null) hash ^= RogueTournBuffInfo.GetHashCode();
      if (keywordUnlockInfo_ != null) hash ^= KeywordUnlockInfo.GetHashCode();
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
      if (rogueTournFormulaInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueTournFormulaInfo);
      }
      if (rogueTournGameAreaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournGameAreaInfo);
      }
      if (rogueTournLayerInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournLayerInfo);
      }
      if (dLCLNIJBHBD_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DLCLNIJBHBD);
      }
      if (eNGCMKFPKLH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ENGCMKFPKLH);
      }
      if (keywordUnlockInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(KeywordUnlockInfo);
      }
      if (rogueTournBuffInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueTournBuffInfo);
      }
      if (rogueTournMiracleInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueTournMiracleInfo);
      }
      if (rogueTournValuesItem_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournValuesItem);
      }
      if (rogueTournVirtualItem_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(RogueTournVirtualItem);
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
      if (rogueTournFormulaInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueTournFormulaInfo);
      }
      if (rogueTournGameAreaInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RogueTournGameAreaInfo);
      }
      if (rogueTournLayerInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueTournLayerInfo);
      }
      if (dLCLNIJBHBD_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(DLCLNIJBHBD);
      }
      if (eNGCMKFPKLH_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ENGCMKFPKLH);
      }
      if (keywordUnlockInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(KeywordUnlockInfo);
      }
      if (rogueTournBuffInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RogueTournBuffInfo);
      }
      if (rogueTournMiracleInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueTournMiracleInfo);
      }
      if (rogueTournValuesItem_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueTournValuesItem);
      }
      if (rogueTournVirtualItem_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(RogueTournVirtualItem);
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
      if (rogueTournGameAreaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournGameAreaInfo);
      }
      if (rogueTournMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournMiracleInfo);
      }
      if (rogueTournFormulaInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournFormulaInfo);
      }
      if (rogueTournValuesItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournValuesItem);
      }
      if (dLCLNIJBHBD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DLCLNIJBHBD);
      }
      if (eNGCMKFPKLH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ENGCMKFPKLH);
      }
      if (rogueTournLayerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournLayerInfo);
      }
      if (rogueTournVirtualItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournVirtualItem);
      }
      if (rogueTournBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueTournBuffInfo);
      }
      if (keywordUnlockInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KeywordUnlockInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueTournCurGameInfo other) {
      if (other == null) {
        return;
      }
      if (other.rogueTournGameAreaInfo_ != null) {
        if (rogueTournGameAreaInfo_ == null) {
          RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
        }
        RogueTournGameAreaInfo.MergeFrom(other.RogueTournGameAreaInfo);
      }
      if (other.rogueTournMiracleInfo_ != null) {
        if (rogueTournMiracleInfo_ == null) {
          RogueTournMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
        }
        RogueTournMiracleInfo.MergeFrom(other.RogueTournMiracleInfo);
      }
      if (other.rogueTournFormulaInfo_ != null) {
        if (rogueTournFormulaInfo_ == null) {
          RogueTournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
        }
        RogueTournFormulaInfo.MergeFrom(other.RogueTournFormulaInfo);
      }
      if (other.rogueTournValuesItem_ != null) {
        if (rogueTournValuesItem_ == null) {
          RogueTournValuesItem = new global::EggLink.DanhengServer.Proto.RogueGameItemInfo();
        }
        RogueTournValuesItem.MergeFrom(other.RogueTournValuesItem);
      }
      if (other.dLCLNIJBHBD_ != null) {
        if (dLCLNIJBHBD_ == null) {
          DLCLNIJBHBD = new global::EggLink.DanhengServer.Proto.DJAFPNNOMMF();
        }
        DLCLNIJBHBD.MergeFrom(other.DLCLNIJBHBD);
      }
      if (other.eNGCMKFPKLH_ != null) {
        if (eNGCMKFPKLH_ == null) {
          ENGCMKFPKLH = new global::EggLink.DanhengServer.Proto.ABFCJGHDNIH();
        }
        ENGCMKFPKLH.MergeFrom(other.ENGCMKFPKLH);
      }
      if (other.rogueTournLayerInfo_ != null) {
        if (rogueTournLayerInfo_ == null) {
          RogueTournLayerInfo = new global::EggLink.DanhengServer.Proto.RogueTournLayerInfo();
        }
        RogueTournLayerInfo.MergeFrom(other.RogueTournLayerInfo);
      }
      if (other.rogueTournVirtualItem_ != null) {
        if (rogueTournVirtualItem_ == null) {
          RogueTournVirtualItem = new global::EggLink.DanhengServer.Proto.RogueTournVirtualItem();
        }
        RogueTournVirtualItem.MergeFrom(other.RogueTournVirtualItem);
      }
      if (other.rogueTournBuffInfo_ != null) {
        if (rogueTournBuffInfo_ == null) {
          RogueTournBuffInfo = new global::EggLink.DanhengServer.Proto.RogueDLCBuffInfo();
        }
        RogueTournBuffInfo.MergeFrom(other.RogueTournBuffInfo);
      }
      if (other.keywordUnlockInfo_ != null) {
        if (keywordUnlockInfo_ == null) {
          KeywordUnlockInfo = new global::EggLink.DanhengServer.Proto.KeywordUnlockInfo();
        }
        KeywordUnlockInfo.MergeFrom(other.KeywordUnlockInfo);
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
          case 10: {
            if (rogueTournFormulaInfo_ == null) {
              RogueTournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            }
            input.ReadMessage(RogueTournFormulaInfo);
            break;
          }
          case 18: {
            if (rogueTournGameAreaInfo_ == null) {
              RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
            }
            input.ReadMessage(RogueTournGameAreaInfo);
            break;
          }
          case 34: {
            if (rogueTournLayerInfo_ == null) {
              RogueTournLayerInfo = new global::EggLink.DanhengServer.Proto.RogueTournLayerInfo();
            }
            input.ReadMessage(RogueTournLayerInfo);
            break;
          }
          case 50: {
            if (dLCLNIJBHBD_ == null) {
              DLCLNIJBHBD = new global::EggLink.DanhengServer.Proto.DJAFPNNOMMF();
            }
            input.ReadMessage(DLCLNIJBHBD);
            break;
          }
          case 58: {
            if (eNGCMKFPKLH_ == null) {
              ENGCMKFPKLH = new global::EggLink.DanhengServer.Proto.ABFCJGHDNIH();
            }
            input.ReadMessage(ENGCMKFPKLH);
            break;
          }
          case 66: {
            if (keywordUnlockInfo_ == null) {
              KeywordUnlockInfo = new global::EggLink.DanhengServer.Proto.KeywordUnlockInfo();
            }
            input.ReadMessage(KeywordUnlockInfo);
            break;
          }
          case 74: {
            if (rogueTournBuffInfo_ == null) {
              RogueTournBuffInfo = new global::EggLink.DanhengServer.Proto.RogueDLCBuffInfo();
            }
            input.ReadMessage(RogueTournBuffInfo);
            break;
          }
          case 82: {
            if (rogueTournMiracleInfo_ == null) {
              RogueTournMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(RogueTournMiracleInfo);
            break;
          }
          case 90: {
            if (rogueTournValuesItem_ == null) {
              RogueTournValuesItem = new global::EggLink.DanhengServer.Proto.RogueGameItemInfo();
            }
            input.ReadMessage(RogueTournValuesItem);
            break;
          }
          case 106: {
            if (rogueTournVirtualItem_ == null) {
              RogueTournVirtualItem = new global::EggLink.DanhengServer.Proto.RogueTournVirtualItem();
            }
            input.ReadMessage(RogueTournVirtualItem);
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
          case 10: {
            if (rogueTournFormulaInfo_ == null) {
              RogueTournFormulaInfo = new global::EggLink.DanhengServer.Proto.RogueTournFormulaInfo();
            }
            input.ReadMessage(RogueTournFormulaInfo);
            break;
          }
          case 18: {
            if (rogueTournGameAreaInfo_ == null) {
              RogueTournGameAreaInfo = new global::EggLink.DanhengServer.Proto.RogueTournGameAreaInfo();
            }
            input.ReadMessage(RogueTournGameAreaInfo);
            break;
          }
          case 34: {
            if (rogueTournLayerInfo_ == null) {
              RogueTournLayerInfo = new global::EggLink.DanhengServer.Proto.RogueTournLayerInfo();
            }
            input.ReadMessage(RogueTournLayerInfo);
            break;
          }
          case 50: {
            if (dLCLNIJBHBD_ == null) {
              DLCLNIJBHBD = new global::EggLink.DanhengServer.Proto.DJAFPNNOMMF();
            }
            input.ReadMessage(DLCLNIJBHBD);
            break;
          }
          case 58: {
            if (eNGCMKFPKLH_ == null) {
              ENGCMKFPKLH = new global::EggLink.DanhengServer.Proto.ABFCJGHDNIH();
            }
            input.ReadMessage(ENGCMKFPKLH);
            break;
          }
          case 66: {
            if (keywordUnlockInfo_ == null) {
              KeywordUnlockInfo = new global::EggLink.DanhengServer.Proto.KeywordUnlockInfo();
            }
            input.ReadMessage(KeywordUnlockInfo);
            break;
          }
          case 74: {
            if (rogueTournBuffInfo_ == null) {
              RogueTournBuffInfo = new global::EggLink.DanhengServer.Proto.RogueDLCBuffInfo();
            }
            input.ReadMessage(RogueTournBuffInfo);
            break;
          }
          case 82: {
            if (rogueTournMiracleInfo_ == null) {
              RogueTournMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(RogueTournMiracleInfo);
            break;
          }
          case 90: {
            if (rogueTournValuesItem_ == null) {
              RogueTournValuesItem = new global::EggLink.DanhengServer.Proto.RogueGameItemInfo();
            }
            input.ReadMessage(RogueTournValuesItem);
            break;
          }
          case 106: {
            if (rogueTournVirtualItem_ == null) {
              RogueTournVirtualItem = new global::EggLink.DanhengServer.Proto.RogueTournVirtualItem();
            }
            input.ReadMessage(RogueTournVirtualItem);
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
