// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct PadOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static PadOptions GetRootAsPadOptions(ByteBuffer _bb) { return GetRootAsPadOptions(_bb, new PadOptions()); }
  public static PadOptions GetRootAsPadOptions(ByteBuffer _bb, PadOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PadOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartPadOptions(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.PadOptions> EndPadOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.PadOptions>(o);
  }
};


}
