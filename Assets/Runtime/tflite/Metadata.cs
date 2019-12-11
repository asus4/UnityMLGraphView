// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace tflite
{

using global::System;
using global::FlatBuffers;

public struct Metadata : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
  public static Metadata GetRootAsMetadata(ByteBuffer _bb) { return GetRootAsMetadata(_bb, new Metadata()); }
  public static Metadata GetRootAsMetadata(ByteBuffer _bb, Metadata obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Metadata __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public uint Buffer { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<tflite.Metadata> CreateMetadata(FlatBufferBuilder builder,
      StringOffset nameOffset = default(StringOffset),
      uint buffer = 0) {
    builder.StartTable(2);
    Metadata.AddBuffer(builder, buffer);
    Metadata.AddName(builder, nameOffset);
    return Metadata.EndMetadata(builder);
  }

  public static void StartMetadata(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddBuffer(FlatBufferBuilder builder, uint buffer) { builder.AddUint(1, buffer, 0); }
  public static Offset<tflite.Metadata> EndMetadata(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<tflite.Metadata>(o);
  }
};


}