// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct PadV2Options : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static PadV2Options GetRootAsPadV2Options(ByteBuffer _bb) { return GetRootAsPadV2Options(_bb, new PadV2Options()); }
  public static PadV2Options GetRootAsPadV2Options(ByteBuffer _bb, PadV2Options obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PadV2Options __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartPadV2Options(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.PadV2Options> EndPadV2Options(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.PadV2Options>(o);
  }
};


}
