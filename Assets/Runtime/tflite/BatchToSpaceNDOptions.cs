// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct BatchToSpaceNDOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static BatchToSpaceNDOptions GetRootAsBatchToSpaceNDOptions(ByteBuffer _bb) { return GetRootAsBatchToSpaceNDOptions(_bb, new BatchToSpaceNDOptions()); }
  public static BatchToSpaceNDOptions GetRootAsBatchToSpaceNDOptions(ByteBuffer _bb, BatchToSpaceNDOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BatchToSpaceNDOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartBatchToSpaceNDOptions(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<tflite.BatchToSpaceNDOptions> EndBatchToSpaceNDOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.BatchToSpaceNDOptions>(o);
  }
};


}