// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct SplitVOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static SplitVOptions GetRootAsSplitVOptions(ByteBuffer _bb) { return GetRootAsSplitVOptions(_bb, new SplitVOptions()); }
  public static SplitVOptions GetRootAsSplitVOptions(ByteBuffer _bb, SplitVOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SplitVOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int NumSplits { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<tflite.SplitVOptions> CreateSplitVOptions(FlatBufferBuilder builder,
      int num_splits = 0) {
    builder.StartTable(1);
    SplitVOptions.AddNumSplits(builder, num_splits);
    return SplitVOptions.EndSplitVOptions(builder);
  }

  public static void StartSplitVOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddNumSplits(FlatBufferBuilder builder, int numSplits) { builder.AddInt(0, numSplits, 0); }
  public static Offset<tflite.SplitVOptions> EndSplitVOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.SplitVOptions>(o);
  }
};


}
