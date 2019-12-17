// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct EmbeddingLookupSparseOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static EmbeddingLookupSparseOptions GetRootAsEmbeddingLookupSparseOptions(ByteBuffer _bb) { return GetRootAsEmbeddingLookupSparseOptions(_bb, new EmbeddingLookupSparseOptions()); }
  public static EmbeddingLookupSparseOptions GetRootAsEmbeddingLookupSparseOptions(ByteBuffer _bb, EmbeddingLookupSparseOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EmbeddingLookupSparseOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.CombinerType Combiner { get { int o = __p.__offset(4); return o != 0 ? (tflite.CombinerType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.CombinerType.SUM; } }

  public static Offset<tflite.EmbeddingLookupSparseOptions> CreateEmbeddingLookupSparseOptions(FlatBufferBuilder builder,
      tflite.CombinerType combiner = tflite.CombinerType.SUM) {
    builder.StartTable(1);
    EmbeddingLookupSparseOptions.AddCombiner(builder, combiner);
    return EmbeddingLookupSparseOptions.EndEmbeddingLookupSparseOptions(builder);
  }

  public static void StartEmbeddingLookupSparseOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddCombiner(FlatBufferBuilder builder, tflite.CombinerType combiner) { builder.AddSbyte(0, (sbyte)combiner, 0); }
  public static Offset<tflite.EmbeddingLookupSparseOptions> EndEmbeddingLookupSparseOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.EmbeddingLookupSparseOptions>(o);
  }
};


}