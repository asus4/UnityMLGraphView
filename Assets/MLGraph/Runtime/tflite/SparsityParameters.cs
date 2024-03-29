// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct SparsityParameters : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static SparsityParameters GetRootAsSparsityParameters(ByteBuffer _bb) { return GetRootAsSparsityParameters(_bb, new SparsityParameters()); }
  public static SparsityParameters GetRootAsSparsityParameters(ByteBuffer _bb, SparsityParameters obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SparsityParameters __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int TraversalOrder(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int TraversalOrderLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetTraversalOrderBytes() { return __p.__vector_as_span<int>(4, 4); }
#else
  public ArraySegment<byte>? GetTraversalOrderBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public int[] GetTraversalOrderArray() { return __p.__vector_as_array<int>(4); }
  public int BlockMap(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BlockMapLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBlockMapBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetBlockMapBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetBlockMapArray() { return __p.__vector_as_array<int>(6); }
  public tflite.DimensionMetadata? DimMetadata(int j) { int o = __p.__offset(8); return o != 0 ? (tflite.DimensionMetadata?)(new tflite.DimensionMetadata()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DimMetadataLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<tflite.SparsityParameters> CreateSparsityParameters(FlatBufferBuilder builder,
      VectorOffset traversal_orderOffset = default(VectorOffset),
      VectorOffset block_mapOffset = default(VectorOffset),
      VectorOffset dim_metadataOffset = default(VectorOffset)) {
    builder.StartTable(3);
    SparsityParameters.AddDimMetadata(builder, dim_metadataOffset);
    SparsityParameters.AddBlockMap(builder, block_mapOffset);
    SparsityParameters.AddTraversalOrder(builder, traversal_orderOffset);
    return SparsityParameters.EndSparsityParameters(builder);
  }

  public static void StartSparsityParameters(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddTraversalOrder(FlatBufferBuilder builder, VectorOffset traversalOrderOffset) { builder.AddOffset(0, traversalOrderOffset.Value, 0); }
  public static VectorOffset CreateTraversalOrderVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTraversalOrderVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTraversalOrderVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBlockMap(FlatBufferBuilder builder, VectorOffset blockMapOffset) { builder.AddOffset(1, blockMapOffset.Value, 0); }
  public static VectorOffset CreateBlockMapVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBlockMapVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartBlockMapVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDimMetadata(FlatBufferBuilder builder, VectorOffset dimMetadataOffset) { builder.AddOffset(2, dimMetadataOffset.Value, 0); }
  public static VectorOffset CreateDimMetadataVector(FlatBufferBuilder builder, Offset<tflite.DimensionMetadata>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDimMetadataVectorBlock(FlatBufferBuilder builder, Offset<tflite.DimensionMetadata>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDimMetadataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<tflite.SparsityParameters> EndSparsityParameters(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.SparsityParameters>(o);
  }
};


}
