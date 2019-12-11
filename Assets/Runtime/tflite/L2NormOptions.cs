// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct L2NormOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static L2NormOptions GetRootAsL2NormOptions(ByteBuffer _bb) { return GetRootAsL2NormOptions(_bb, new L2NormOptions()); }
  public static L2NormOptions GetRootAsL2NormOptions(ByteBuffer _bb, L2NormOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public L2NormOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.ActivationFunctionType FusedActivationFunction { get { int o = __p.__offset(4); return o != 0 ? (tflite.ActivationFunctionType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.ActivationFunctionType.NONE; } }

  public static Offset<tflite.L2NormOptions> CreateL2NormOptions(FlatBufferBuilder builder,
      tflite.ActivationFunctionType fused_activation_function = tflite.ActivationFunctionType.NONE) {
    builder.StartTable(1);
    L2NormOptions.AddFusedActivationFunction(builder, fused_activation_function);
    return L2NormOptions.EndL2NormOptions(builder);
  }

  public static void StartL2NormOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddFusedActivationFunction(FlatBufferBuilder builder, tflite.ActivationFunctionType fusedActivationFunction) { builder.AddSbyte(0, (sbyte)fusedActivationFunction, 0); }
  public static Offset<tflite.L2NormOptions> EndL2NormOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.L2NormOptions>(o);
  }
};


}