// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct LSTMOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static LSTMOptions GetRootAsLSTMOptions(ByteBuffer _bb) { return GetRootAsLSTMOptions(_bb, new LSTMOptions()); }
  public static LSTMOptions GetRootAsLSTMOptions(ByteBuffer _bb, LSTMOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LSTMOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.ActivationFunctionType FusedActivationFunction { get { int o = __p.__offset(4); return o != 0 ? (tflite.ActivationFunctionType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.ActivationFunctionType.NONE; } }
  public float CellClip { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ProjClip { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public tflite.LSTMKernelType KernelType { get { int o = __p.__offset(10); return o != 0 ? (tflite.LSTMKernelType)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.LSTMKernelType.FULL; } }

  public static Offset<tflite.LSTMOptions> CreateLSTMOptions(FlatBufferBuilder builder,
      tflite.ActivationFunctionType fused_activation_function = tflite.ActivationFunctionType.NONE,
      float cell_clip = 0.0f,
      float proj_clip = 0.0f,
      tflite.LSTMKernelType kernel_type = tflite.LSTMKernelType.FULL) {
    builder.StartTable(4);
    LSTMOptions.AddProjClip(builder, proj_clip);
    LSTMOptions.AddCellClip(builder, cell_clip);
    LSTMOptions.AddKernelType(builder, kernel_type);
    LSTMOptions.AddFusedActivationFunction(builder, fused_activation_function);
    return LSTMOptions.EndLSTMOptions(builder);
  }

  public static void StartLSTMOptions(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddFusedActivationFunction(FlatBufferBuilder builder, tflite.ActivationFunctionType fusedActivationFunction) { builder.AddSbyte(0, (sbyte)fusedActivationFunction, 0); }
  public static void AddCellClip(FlatBufferBuilder builder, float cellClip) { builder.AddFloat(1, cellClip, 0.0f); }
  public static void AddProjClip(FlatBufferBuilder builder, float projClip) { builder.AddFloat(2, projClip, 0.0f); }
  public static void AddKernelType(FlatBufferBuilder builder, tflite.LSTMKernelType kernelType) { builder.AddSbyte(3, (sbyte)kernelType, 0); }
  public static Offset<tflite.LSTMOptions> EndLSTMOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.LSTMOptions>(o);
  }
};


}
