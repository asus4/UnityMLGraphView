// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct LeakyReluOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static LeakyReluOptions GetRootAsLeakyReluOptions(ByteBuffer _bb) { return GetRootAsLeakyReluOptions(_bb, new LeakyReluOptions()); }
  public static LeakyReluOptions GetRootAsLeakyReluOptions(ByteBuffer _bb, LeakyReluOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LeakyReluOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float Alpha { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<tflite.LeakyReluOptions> CreateLeakyReluOptions(FlatBufferBuilder builder,
      float alpha = 0.0f) {
    builder.StartTable(1);
    LeakyReluOptions.AddAlpha(builder, alpha);
    return LeakyReluOptions.EndLeakyReluOptions(builder);
  }

  public static void StartLeakyReluOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddAlpha(FlatBufferBuilder builder, float alpha) { builder.AddFloat(0, alpha, 0.0f); }
  public static Offset<tflite.LeakyReluOptions> EndLeakyReluOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.LeakyReluOptions>(o);
  }
};


}
