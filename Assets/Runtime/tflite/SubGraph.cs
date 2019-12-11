// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct SubGraph : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static SubGraph GetRootAsSubGraph(ByteBuffer _bb) { return GetRootAsSubGraph(_bb, new SubGraph()); }
  public static SubGraph GetRootAsSubGraph(ByteBuffer _bb, SubGraph obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SubGraph __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.Tensor? Tensors(int j) { int o = __p.__offset(4); return o != 0 ? (tflite.Tensor?)(new tflite.Tensor()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int TensorsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int Inputs(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InputsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetInputsBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetInputsBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetInputsArray() { return __p.__vector_as_array<int>(6); }
  public int Outputs(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OutputsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetOutputsBytes() { return __p.__vector_as_span<int>(8, 4); }
#else
  public ArraySegment<byte>? GetOutputsBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public int[] GetOutputsArray() { return __p.__vector_as_array<int>(8); }
  public tflite.Operator? Operators(int j) { int o = __p.__offset(10); return o != 0 ? (tflite.Operator?)(new tflite.Operator()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int OperatorsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Name { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<tflite.SubGraph> CreateSubGraph(FlatBufferBuilder builder,
      VectorOffset tensorsOffset = default(VectorOffset),
      VectorOffset inputsOffset = default(VectorOffset),
      VectorOffset outputsOffset = default(VectorOffset),
      VectorOffset operatorsOffset = default(VectorOffset),
      StringOffset nameOffset = default(StringOffset)) {
    builder.StartTable(5);
    SubGraph.AddName(builder, nameOffset);
    SubGraph.AddOperators(builder, operatorsOffset);
    SubGraph.AddOutputs(builder, outputsOffset);
    SubGraph.AddInputs(builder, inputsOffset);
    SubGraph.AddTensors(builder, tensorsOffset);
    return SubGraph.EndSubGraph(builder);
  }

  public static void StartSubGraph(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddTensors(FlatBufferBuilder builder, VectorOffset tensorsOffset) { builder.AddOffset(0, tensorsOffset.Value, 0); }
  public static VectorOffset CreateTensorsVector(FlatBufferBuilder builder, Offset<tflite.Tensor>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTensorsVectorBlock(FlatBufferBuilder builder, Offset<tflite.Tensor>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartTensorsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInputs(FlatBufferBuilder builder, VectorOffset inputsOffset) { builder.AddOffset(1, inputsOffset.Value, 0); }
  public static VectorOffset CreateInputsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInputsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartInputsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOutputs(FlatBufferBuilder builder, VectorOffset outputsOffset) { builder.AddOffset(2, outputsOffset.Value, 0); }
  public static VectorOffset CreateOutputsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOutputsVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartOutputsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOperators(FlatBufferBuilder builder, VectorOffset operatorsOffset) { builder.AddOffset(3, operatorsOffset.Value, 0); }
  public static VectorOffset CreateOperatorsVector(FlatBufferBuilder builder, Offset<tflite.Operator>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateOperatorsVectorBlock(FlatBufferBuilder builder, Offset<tflite.Operator>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartOperatorsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(4, nameOffset.Value, 0); }
  public static Offset<tflite.SubGraph> EndSubGraph(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.SubGraph>(o);
  }
};


}
