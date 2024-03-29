// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct FullyConnectedOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static FullyConnectedOptions GetRootAsFullyConnectedOptions(ByteBuffer _bb) { return GetRootAsFullyConnectedOptions(_bb, new FullyConnectedOptions()); }
  public static FullyConnectedOptions GetRootAsFullyConnectedOptions(ByteBuffer _bb, FullyConnectedOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FullyConnectedOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.ActivationFunctionType FusedActivationFunction { get { int o = __p.__offset(4); return o != 0 ? (tflite.ActivationFunctionType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.ActivationFunctionType.NONE; } }
  public tflite.FullyConnectedOptionsWeightsFormat WeightsFormat { get { int o = __p.__offset(6); return o != 0 ? (tflite.FullyConnectedOptionsWeightsFormat)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.FullyConnectedOptionsWeightsFormat.DEFAULT; } }
  public bool KeepNumDims { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<tflite.FullyConnectedOptions> CreateFullyConnectedOptions(FlatBufferBuilder builder,
      tflite.ActivationFunctionType fused_activation_function = tflite.ActivationFunctionType.NONE,
      tflite.FullyConnectedOptionsWeightsFormat weights_format = tflite.FullyConnectedOptionsWeightsFormat.DEFAULT,
      bool keep_num_dims = false) {
    builder.StartTable(3);
    FullyConnectedOptions.AddKeepNumDims(builder, keep_num_dims);
    FullyConnectedOptions.AddWeightsFormat(builder, weights_format);
    FullyConnectedOptions.AddFusedActivationFunction(builder, fused_activation_function);
    return FullyConnectedOptions.EndFullyConnectedOptions(builder);
  }

  public static void StartFullyConnectedOptions(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddFusedActivationFunction(FlatBufferBuilder builder, tflite.ActivationFunctionType fusedActivationFunction) { builder.AddSbyte(0, (sbyte)fusedActivationFunction, 0); }
  public static void AddWeightsFormat(FlatBufferBuilder builder, tflite.FullyConnectedOptionsWeightsFormat weightsFormat) { builder.AddSbyte(1, (sbyte)weightsFormat, 0); }
  public static void AddKeepNumDims(FlatBufferBuilder builder, bool keepNumDims) { builder.AddBool(2, keepNumDims, false); }
  public static Offset<tflite.FullyConnectedOptions> EndFullyConnectedOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.FullyConnectedOptions>(o);
  }
};


}
