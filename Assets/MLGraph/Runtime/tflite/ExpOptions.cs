// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct ExpOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static ExpOptions GetRootAsExpOptions(ByteBuffer _bb) { return GetRootAsExpOptions(_bb, new ExpOptions()); }
  public static ExpOptions GetRootAsExpOptions(ByteBuffer _bb, ExpOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ExpOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartExpOptions(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.ExpOptions> EndExpOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.ExpOptions>(o);
  }
};


}
