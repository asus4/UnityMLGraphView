// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct SquaredDifferenceOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static SquaredDifferenceOptions GetRootAsSquaredDifferenceOptions(ByteBuffer _bb) { return GetRootAsSquaredDifferenceOptions(_bb, new SquaredDifferenceOptions()); }
  public static SquaredDifferenceOptions GetRootAsSquaredDifferenceOptions(ByteBuffer _bb, SquaredDifferenceOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public SquaredDifferenceOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartSquaredDifferenceOptions(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.SquaredDifferenceOptions> EndSquaredDifferenceOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.SquaredDifferenceOptions>(o);
  }
};


}
