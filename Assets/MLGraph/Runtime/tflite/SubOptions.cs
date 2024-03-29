// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct SubOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static SubOptions GetRootAsSubOptions(ByteBuffer _bb) { return GetRootAsSubOptions(_bb, new SubOptions()); }
  public static SubOptions GetRootAsSubOptions(ByteBuffer _bb, SubOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SubOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.ActivationFunctionType FusedActivationFunction { get { int o = __p.__offset(4); return o != 0 ? (tflite.ActivationFunctionType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.ActivationFunctionType.NONE; } }

  public static Offset<tflite.SubOptions> CreateSubOptions(FlatBufferBuilder builder,
      tflite.ActivationFunctionType fused_activation_function = tflite.ActivationFunctionType.NONE) {
    builder.StartTable(1);
    SubOptions.AddFusedActivationFunction(builder, fused_activation_function);
    return SubOptions.EndSubOptions(builder);
  }

  public static void StartSubOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddFusedActivationFunction(FlatBufferBuilder builder, tflite.ActivationFunctionType fusedActivationFunction) { builder.AddSbyte(0, (sbyte)fusedActivationFunction, 0); }
  public static Offset<tflite.SubOptions> EndSubOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.SubOptions>(o);
  }
};


}
