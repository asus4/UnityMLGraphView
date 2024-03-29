// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct MirrorPadOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static MirrorPadOptions GetRootAsMirrorPadOptions(ByteBuffer _bb) { return GetRootAsMirrorPadOptions(_bb, new MirrorPadOptions()); }
  public static MirrorPadOptions GetRootAsMirrorPadOptions(ByteBuffer _bb, MirrorPadOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MirrorPadOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public tflite.MirrorPadMode Mode { get { int o = __p.__offset(4); return o != 0 ? (tflite.MirrorPadMode)__p.bb.GetSbyte(o + __p.bb_pos) : tflite.MirrorPadMode.REFLECT; } }

  public static Offset<tflite.MirrorPadOptions> CreateMirrorPadOptions(FlatBufferBuilder builder,
      tflite.MirrorPadMode mode = tflite.MirrorPadMode.REFLECT) {
    builder.StartTable(1);
    MirrorPadOptions.AddMode(builder, mode);
    return MirrorPadOptions.EndMirrorPadOptions(builder);
  }

  public static void StartMirrorPadOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddMode(FlatBufferBuilder builder, tflite.MirrorPadMode mode) { builder.AddSbyte(0, (sbyte)mode, 0); }
  public static Offset<tflite.MirrorPadOptions> EndMirrorPadOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.MirrorPadOptions>(o);
  }
};


}
