// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FBANOMONEAE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FBANOMONEAE.proto</summary>
  public static partial class FBANOMONEAEReflection {

    #region Descriptor
    /// <summary>File descriptor for FBANOMONEAE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FBANOMONEAEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGQkFOT01PTkVBRS5wcm90bxoRQUJIRlBGRVBNRUgucHJvdG8aEUpJT0VL",
            "QURBQUZJLnByb3RvIlMKC0ZCQU5PTU9ORUFFEiEKC0VCQU1QT05BRFBKGAUg",
            "ASgLMgwuQUJIRlBGRVBNRUgSIQoLSUxOTk5OTVBMT08YAiABKAsyDC5KSU9F",
            "S0FEQUFGSUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ABHFPFEPMEHReflection.Descriptor, global::EggLink.DanhengServer.Proto.JIOEKADAAFIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FBANOMONEAE), global::EggLink.DanhengServer.Proto.FBANOMONEAE.Parser, new[]{ "EBAMPONADPJ", "ILNNNNMPLOO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FBANOMONEAE : pb::IMessage<FBANOMONEAE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FBANOMONEAE> _parser = new pb::MessageParser<FBANOMONEAE>(() => new FBANOMONEAE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FBANOMONEAE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FBANOMONEAEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FBANOMONEAE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FBANOMONEAE(FBANOMONEAE other) : this() {
      eBAMPONADPJ_ = other.eBAMPONADPJ_ != null ? other.eBAMPONADPJ_.Clone() : null;
      iLNNNNMPLOO_ = other.iLNNNNMPLOO_ != null ? other.iLNNNNMPLOO_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FBANOMONEAE Clone() {
      return new FBANOMONEAE(this);
    }

    /// <summary>Field number for the "EBAMPONADPJ" field.</summary>
    public const int EBAMPONADPJFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.ABHFPFEPMEH eBAMPONADPJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ABHFPFEPMEH EBAMPONADPJ {
      get { return eBAMPONADPJ_; }
      set {
        eBAMPONADPJ_ = value;
      }
    }

    /// <summary>Field number for the "ILNNNNMPLOO" field.</summary>
    public const int ILNNNNMPLOOFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.JIOEKADAAFI iLNNNNMPLOO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JIOEKADAAFI ILNNNNMPLOO {
      get { return iLNNNNMPLOO_; }
      set {
        iLNNNNMPLOO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FBANOMONEAE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FBANOMONEAE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EBAMPONADPJ, other.EBAMPONADPJ)) return false;
      if (!object.Equals(ILNNNNMPLOO, other.ILNNNNMPLOO)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (eBAMPONADPJ_ != null) hash ^= EBAMPONADPJ.GetHashCode();
      if (iLNNNNMPLOO_ != null) hash ^= ILNNNNMPLOO.GetHashCode();
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
      if (iLNNNNMPLOO_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ILNNNNMPLOO);
      }
      if (eBAMPONADPJ_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EBAMPONADPJ);
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
      if (iLNNNNMPLOO_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ILNNNNMPLOO);
      }
      if (eBAMPONADPJ_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EBAMPONADPJ);
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
      if (eBAMPONADPJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EBAMPONADPJ);
      }
      if (iLNNNNMPLOO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ILNNNNMPLOO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FBANOMONEAE other) {
      if (other == null) {
        return;
      }
      if (other.eBAMPONADPJ_ != null) {
        if (eBAMPONADPJ_ == null) {
          EBAMPONADPJ = new global::EggLink.DanhengServer.Proto.ABHFPFEPMEH();
        }
        EBAMPONADPJ.MergeFrom(other.EBAMPONADPJ);
      }
      if (other.iLNNNNMPLOO_ != null) {
        if (iLNNNNMPLOO_ == null) {
          ILNNNNMPLOO = new global::EggLink.DanhengServer.Proto.JIOEKADAAFI();
        }
        ILNNNNMPLOO.MergeFrom(other.ILNNNNMPLOO);
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
          case 18: {
            if (iLNNNNMPLOO_ == null) {
              ILNNNNMPLOO = new global::EggLink.DanhengServer.Proto.JIOEKADAAFI();
            }
            input.ReadMessage(ILNNNNMPLOO);
            break;
          }
          case 42: {
            if (eBAMPONADPJ_ == null) {
              EBAMPONADPJ = new global::EggLink.DanhengServer.Proto.ABHFPFEPMEH();
            }
            input.ReadMessage(EBAMPONADPJ);
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
          case 18: {
            if (iLNNNNMPLOO_ == null) {
              ILNNNNMPLOO = new global::EggLink.DanhengServer.Proto.JIOEKADAAFI();
            }
            input.ReadMessage(ILNNNNMPLOO);
            break;
          }
          case 42: {
            if (eBAMPONADPJ_ == null) {
              EBAMPONADPJ = new global::EggLink.DanhengServer.Proto.ABHFPFEPMEH();
            }
            input.ReadMessage(EBAMPONADPJ);
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
