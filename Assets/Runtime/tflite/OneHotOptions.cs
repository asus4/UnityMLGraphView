// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct OneHotOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static OneHotOptions GetRootAsOneHotOptions(ByteBuffer _bb) { return GetRootAsOneHotOptions(_bb, new OneHotOptions()); }
  public static OneHotOptions GetRootAsOneHotOptions(ByteBuffer _bb, OneHotOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OneHotOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Axis { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<tflite.OneHotOptions> CreateOneHotOptions(FlatBufferBuilder builder,
      int axis = 0) {
    builder.StartTable(1);
    OneHotOptions.AddAxis(builder, axis);
    return OneHotOptions.EndOneHotOptions(builder);
  }

  public static void StartOneHotOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddAxis(FlatBufferBuilder builder, int axis) { builder.AddInt(0, axis, 0); }
  public static Offset<tflite.OneHotOptions> EndOneHotOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.OneHotOptions>(o);
  }
};


}
