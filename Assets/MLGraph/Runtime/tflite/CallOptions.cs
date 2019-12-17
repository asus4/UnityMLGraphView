// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct CallOptions : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static CallOptions GetRootAsCallOptions(ByteBuffer _bb) { return GetRootAsCallOptions(_bb, new CallOptions()); }
  public static CallOptions GetRootAsCallOptions(ByteBuffer _bb, CallOptions obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CallOptions __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Subgraph { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<tflite.CallOptions> CreateCallOptions(FlatBufferBuilder builder,
      uint subgraph = 0) {
    builder.StartTable(1);
    CallOptions.AddSubgraph(builder, subgraph);
    return CallOptions.EndCallOptions(builder);
  }

  public static void StartCallOptions(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddSubgraph(FlatBufferBuilder builder, uint subgraph) { builder.AddUint(0, subgraph, 0); }
  public static Offset<tflite.CallOptions> EndCallOptions(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.CallOptions>(o);
  }
};


}