// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct PackOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static PackOptions GetRootAsPackOptions(ByteBuffer _bb) { return GetRootAsPackOptions(_bb, new PackOptions()); }
  public static PackOptions GetRootAsPackOptions(ByteBuffer _bb, PackOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PackOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int ValuesCount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Axis { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<tflite.PackOptions> CreatePackOptions(FlatBufferBuilder builder,
      int values_count = 0,
      int axis = 0) {
    builder.StartTable(2);
    PackOptions.AddAxis(builder, axis);
    PackOptions.AddValuesCount(builder, values_count);
    return PackOptions.EndPackOptions(builder);
  }

  public static void StartPackOptions(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddValuesCount(FlatBufferBuilder builder, int valuesCount) { builder.AddInt(0, valuesCount, 0); }
  public static void AddAxis(FlatBufferBuilder builder, int axis) { builder.AddInt(1, axis, 0); }
  public static Offset<tflite.PackOptions> EndPackOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.PackOptions>(o);
  }
};


}
